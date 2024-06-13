using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MeuAppPods.Model;
using System.Collections.ObjectModel;

namespace MeuAppPods.Pages;

public partial class OXBAR : ContentPage
{
    private Usuario _usuario;
    private Itens _item;
    public OXBAR(Usuario usuario)
	{
        _usuario = usuario;
        _item = new Itens();
        this.BindingContext = _item;
        InitializeComponent();
	}


    private async void btnAdicionar_Clicked(object sender, EventArgs e)
    {
        if (!ValidateFields())
        {
            await DisplayAlert("Erro!", "Campos inválidos. Por favor verifique e tente novamente.", "OK");
            return;
        }
        var adicionarItem = await App.BancoDados.ItemDataTable.SalvarItem(_item);

        if (adicionarItem > 0)
        {
            await DisplayAlert("Sucesso!", "Item cadastrado com sucesso!", "OK");
            return;
        }
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

    private bool ValidateFields()
    {
        if (string.IsNullOrWhiteSpace(itemEntry.Text))
            return false;
        if (string.IsNullOrWhiteSpace(quantEntry.Text))
            return false;

        return true;
    }
}