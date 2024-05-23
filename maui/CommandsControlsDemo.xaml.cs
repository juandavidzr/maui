namespace maui;

public partial class CommandsControlsDemo : ContentPage
{
	public CommandsControlsDemo()
	{
		InitializeComponent();
	}

    void btnTest_Clicked(System.Object sender, System.EventArgs e)
    {
		DisplayAlert("test", "demo", "ok");
    }

    void RadioButton_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
        DisplayAlert("test", "Cambio", "ok");
    }

    void SwipeItem_Invoked(System.Object sender, System.EventArgs e)
    {
        DisplayAlert("test", "item tapet", "ok");
    }
}
