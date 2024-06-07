namespace MeuAppPods.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditaUsuarioPage());
    }

    private async void btnEsquecSEnha_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EsqueceuSenhaPage());
    }

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string senha = txtSenha.Text;

        if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(senha))
        {
            var usuario = await App.BancoDados.UsuarioDataTable.ObtemUsuario(email, senha);

            if (usuario != null)
            {
                await DisplayAlert("Sucesso", "Login efetuado com sucesso", "Ok");
                await Navigation.PushAsync(new HomePage(usuario));
                App.Usuario = usuario;
            }
            else
            {
                await DisplayAlert("Erro", "Credenciais erradas", "Ok");
                return;
            }
        }
        else
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                await DisplayAlert("Erro", "Preencha o campo de e-mail", "Ok");
            }
            else if (string.IsNullOrWhiteSpace(senha))
            {
                await DisplayAlert("Erro", "Preencha o campo de senha", "Ok");
            }
        }
    }
}