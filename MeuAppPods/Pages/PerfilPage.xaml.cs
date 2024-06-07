using MeuAppPods.Model;

namespace MeuAppPods.Pages;

public partial class PerfilPage : ContentPage
{
	private Usuario _usuario;
	public PerfilPage( Usuario usuario)
	{
		InitializeComponent();
		_usuario = usuario;
		txtNome.Text = _usuario.Nome;
		txtEmail.Text = _usuario.Email;
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage(_usuario));
    }

    private async void ImageButton_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CarrinhoPage(_usuario));
    }

    private async void ImageButton_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PerfilPage(_usuario));
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}