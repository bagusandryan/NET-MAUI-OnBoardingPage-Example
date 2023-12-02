namespace GetEmDone;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override void OnStart()
    {
        base.OnStart();

        Application.Current.RequestedThemeChanged += (e, a) =>
        {
            AppTheme currentTheme = Application.Current.RequestedTheme;
        };
    }
}

