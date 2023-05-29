using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProyectoMaui1;

public partial class PaginaPrincipal : ContentPage
{
    public PaginaPrincipal(string nombre)
    {
		InitializeComponent();
        LabelNombre.Text = nombre;
    }

    async void Agregar_PickUp(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PagPickUp());
    }

    async void Agregar_Camioneta(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PagCamioneta());
    }

    async void Agregar_Sedan(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PagSedan());
    }

    async void ListadoDeAutos(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListadoDeAutos());
    }

}