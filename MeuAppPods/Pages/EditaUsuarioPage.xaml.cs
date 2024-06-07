using MeuAppPods.Model;

namespace MeuAppPods.Pages
{
    public partial class EditaUsuarioPage : ContentPage
    {
        Usuario _usuario;
        public EditaUsuarioPage()
        {
            _usuario = new Usuario();
            this.BindingContext = _usuario;
            InitializeComponent();
        }

        private bool ValidateFields()
        {
            var senha = senhaEntry.Text;

            if (string.IsNullOrWhiteSpace(nomeEntry.Text))
                return false;
            if (string.IsNullOrWhiteSpace(sobrenomeEntry.Text))
                return false;
            if (string.IsNullOrWhiteSpace(emailEntry.Text) || !emailEntry.Text.Contains("@"))
                return false;
            if (string.IsNullOrWhiteSpace(cpfEntry.Text) || cpfEntry.Text.Length < 11)
                return false;
            if (dataNascimentoDatePicker.Date == null)
                return false;
            if (string.IsNullOrWhiteSpace(senhaEntry.Text) || senhaEntry.Text.Length < 8)
                return false;
            if (string.IsNullOrWhiteSpace(confirmarSenhaEntry.Text) || confirmarSenhaEntry.Text != senha)
                return false;

            return true;
        }

        private async void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                await DisplayAlert("Erro!", "Campos inválidos. Por favor verifique e tente novamente.", "OK");
                return;
            }
            var cadastro = await App.BancoDados.UsuarioDataTable.SalvarUsuario(_usuario);

            if (cadastro > 0)
            {
                await DisplayAlert("Sucesso!", "Usuário cadastrado com sucesso!", "OK");
                await Navigation.PopAsync();
            }
        }

    }
}