namespace maui;

public partial class InputControlls : ContentPage
{
	public InputControlls()
	{
		InitializeComponent();
	}

    void slider_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
		labelSlider.Text = slider.Value.ToString();
    }

    void stepper_ValueChanged(System.Object sender, Microsoft.Maui.Controls.ValueChangedEventArgs e)
    {
        labelSlider.Text = stepper.Value.ToString();
    }
}
