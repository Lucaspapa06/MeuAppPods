using MeuAppPods.Model;
using System.ComponentModel;

namespace MeuAppPods.Pages;

public partial class CarrinhoPage : ContentPage
{
    private Carrinho _carrinho = new Carrinho(); // Instanciando o carrinho aqui

    private Usuario _usuario;
	public CarrinhoPage(Usuario usuario)
	{
		_usuario = usuario;
		InitializeComponent();

        this.BindingContext = _carrinho;
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

    public class Carrinho : INotifyPropertyChanged
    {
        private List<Itens> _itens = new List<Itens>();

        public List<Itens> Itens
        {
            get { return _itens; }
            set
            {
                _itens = value;
                OnPropertyChanged(nameof(Itens));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void AddItem(Itens item)
        {
            _itens.Add(item);
            OnPropertyChanged(nameof(Itens));
        }

        public void RemoveItem(Itens item)
        {
            _itens.Remove(item);
            OnPropertyChanged(nameof(Itens));
        }
    }
}