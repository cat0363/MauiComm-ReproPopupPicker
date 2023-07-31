namespace MauiComm_ReproPopupPicker;

public partial class Popup : ContentView
{
	public Popup()
	{
		InitializeComponent();

		this.BindingContext = new ViewModelTest();
	}
}