﻿namespace maui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new NavigationPage (new ContentPageDemo());

        //var navPage = new NavigationPage(new ContentPageDemo());
        //navPage.BarBackgroundColor = Colors.Chocolate;
        //navPage.BarTextColor = Colors.White;
        //MainPage = navPage;

        MainPage = new FlyoutPageDemo();

    }
}

