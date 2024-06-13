using MeuAppPods.Model;

namespace MeuAppPods.Pages;

public partial class ELFBAR : ContentPage
{
    private Usuario _usuario;
    private Carrinho _carrinho = new Carrinho();
    public ELFBAR(Usuario usuario)
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

   

    private async void ImageButton_Clicked_3(object sender, EventArgs e)
    {
        var nomeItem = (string)((ImageButton)sender).CommandParameter;

        var item = new Itens { Nome = nomeItem, Quantidade = 1 }; // Inicializa a quantidade como 1

        _carrinho.AddItem(item);

        // Talvez você queira exibir uma mensagem de confirmação ou atualizar a interface do usuário de alguma forma aqui
    }
}