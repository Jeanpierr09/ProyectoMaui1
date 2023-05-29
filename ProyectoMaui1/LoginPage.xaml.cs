using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProyectoMaui1;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
		
	}

    async void Pp(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new PaginaPrincipal(NombreIngresado));
    }
	
	public string NombreIngresado { get; set; }	
	private void SaveName(object sender, EventArgs e)
	{
		NombreIngresado = NombreEntry.Text;
    }
}