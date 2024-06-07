using MeuAppPods.Model;

namespace MeuAppPods.Pages;

public partial class EsqueceuSenhaPage : ContentPage
{
    Usuario _usuario;
    public EsqueceuSenhaPage()
    {
        _usuario = new Usuario();

        this.BindingContext = _usuario;

        InitializeComponent();
    }

    private async void btnSalvar_Clicked(object sender, EventArgs e)
    {
        string email = txtEmail.Text;
        string novasenha = txtSenha.Text;

        if (string.IsNullOrWhiteSpace(email))
        {
            await DisplayAlert("Erro!", "Preencha o campo e-mail!", "OK");
            return;
        }
        if(string.IsNullOrWhiteSpace(novasenha))
        {
            await DisplayAlert("Erro!", "Preencha o campo senha!", "OK");
            return;
        }

        try
        {
            var usuario = await App.BancoDados.UsuarioDataTable.ObtemEmailUsuario(email);

            if(usuario != null)
            {
                usuario.Senha = novasenha;
                await App.BancoDados.UsuarioDataTable.AtualizarUsuario(usuario);
                await DisplayAlert("Sucesso", "Senha atualizada com sucesso", "OK");
                await Navigation.PopAsync();
            }
            else
            {
                await DisplayAlert("Erro", "Usuário não encontrado", "OK");
            }
        }
        catch(Exception ex)
        {
            await DisplayAlert("Erro", $"Ocorreu um erro ao acessar o banco de dados: {ex.Message}", "OK");
        }
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}