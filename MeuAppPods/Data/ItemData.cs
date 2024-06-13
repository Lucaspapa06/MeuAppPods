using SQLite;
using MeuAppPods.Model;

namespace MeuAppPods.Data
{
    public class ItemData
    {
        private SQLiteAsyncConnection _conexaoDB;

        public ItemData(SQLiteAsyncConnection conexaoDB)
        {
            _conexaoDB = conexaoDB;
        }

        public async Task CriarTabelaAsync()
        {
            await _conexaoDB.CreateTableAsync<Itens>();
        }

        public Task<Itens> ObtemIdItem(Guid id)
        {
            var item = _conexaoDB
                .Table<Itens>()
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
            return item;
        }

        public async Task<int> SalvarItem(Itens item)
        {
            var novoUsuario = await ObtemIdItem(item.Id);

            if (novoUsuario == null)
            {
                return await _conexaoDB.InsertAsync(item);
            }
            else
            {
                return await _conexaoDB.UpdateAsync(item);
            }
        }
    }
}
