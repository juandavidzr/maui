﻿namespace maui;

public partial class AnotherPage : ContentPage
{
	public AnotherPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PopAsync();
    }


}
