using ContadorMaunal.Maui.Models;

namespace ContadorMaunal.Maui.Views;

public partial class MainPage : ContentPage
{
    private Contador _contador;

    public MainPage()
    {
        InitializeComponent();
        _contador = new Contador();
        BindingContext = _contador;

    }

    private void OnContarButtonClicked(object sender, EventArgs e)
    {
        _contador.Contar();

    }

    private void OnReiniciarButtonClicked(object sender, EventArgs e)
    {
        _contador.Reiniciar();


    }
}