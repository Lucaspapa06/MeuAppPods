using MeuAppPods.Model;

namespace MeuAppPods.Pages;

public partial class LOSTMARY : ContentPage
{
    private Usuario _usuario;
    public LOSTMARY(Usuario usuario)
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
}