namespace maui;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new AnotherPage());
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        
    }
}
