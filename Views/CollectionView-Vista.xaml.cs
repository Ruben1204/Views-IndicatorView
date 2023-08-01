using ControlesTipoVista.Data;

namespace ControlesTipoVista.Views;

public partial class CollectionView_Vista : ContentPage
{
	public CollectionView_Vista()
	{
		InitializeComponent();
	}

    private void CollectionView_RemainingItemsThresholdReached(object sender, EventArgs e)
    {

    }

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        //string Anterior = (e.PreviousSelection.FirstOrDefault() as Robot)?.Nombre;
        //string Actual = (e.CurrentSelection.FirstOrDefault() as Robot)?.Nombre;

        //lbl1.Text = Anterior;
        //lbl2.Text = Actual;
    }

    private void Switch_Toggled(object sender, ToggledEventArgs e)
    {
        //bool isToggled = e.Value;
        //collectionView.EmptyView= isToggled ? Resources["VistaVaciaBasica"] : Resources["VistaVaciaAvanzada"];
    }
}