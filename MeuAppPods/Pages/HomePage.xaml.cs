
using MeuAppPods.Model;

namespace MeuAppPods.Pages;

public partial class HomePage : ContentPage
{
    private Usuario _usuario;
	public HomePage(Usuario usuario)
	{
        _usuario = usuario;
		InitializeComponent();
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
        await Navigation.PushAsync(new OXBAR(_usuario));
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new IGNITE(_usuario));
    }

    private async void Button_Clicked_2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ELFBAR(_usuario));
    }

    private async void Button_Clicked_3(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LOSTMARY(_usuario));
    }
}