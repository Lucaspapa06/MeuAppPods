using SQLite;
using MeuAppPods.Model;

namespace MeuAppPods.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _conexaoDB;

        public UsuarioData UsuarioDataTable { get; set; }
        public ItemData ItemDataTable { get; set; }

        public SQLiteData(string path)
        {
            _conexaoDB = new SQLiteAsyncConnection(path);
            _conexaoDB.CreateTableAsync<Usuario>().Wait();
            _conexaoDB = new SQLiteAsyncConnection(path);
            _conexaoDB.CreateTableAsync<Itens>().Wait();

            UsuarioDataTable = new UsuarioData(_conexaoDB);
            ItemDataTable = new ItemData(_conexaoDB);
        }
    }
}
