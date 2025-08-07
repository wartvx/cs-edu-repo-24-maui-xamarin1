namespace FirstMauiApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

    protected override Window CreateWindow(IActivationState? activationState)
    {
        // return new Window(new AppShell());

        var wins = new Window(new AppShell());

#if WINDOWS
        const int newHeight = 600;
        const int newWidth = 800;

        wins.Height = wins.MinimumHeight = wins.MaximumHeight = newHeight;
        wins.Width = wins.MinimumWidth = wins.MaximumWidth = newWidth;
#endif

        return wins;
    }
}