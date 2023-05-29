using System.Runtime.CompilerServices;

namespace ProyectoMaui1;

public partial class PagPickUp : ContentPage
{
	public PagPickUp()
	{
		InitializeComponent();
	}
	
	PickUp Nissan = new PickUp("Label.Nombre", "Nissan", "Rojo", 2019, "P-123", "PickUp", 200, 0, 300, 10);
	private void Agregar_PickUp_Nissan(object sender, EventArgs e)
	{
		
	}

    private void Agregar_PickUp_Ford(object sender, EventArgs e)
    {
		
    }

}