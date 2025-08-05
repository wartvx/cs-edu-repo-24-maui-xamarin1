namespace FirstMauiApp.Pages;

public partial class RegisterPage : ContentPage
{
	// константа для текста кнопки
	public const string BUTTON_TEXT = "Регистрация";

	int count = 0;

	public RegisterPage()
	{
		InitializeComponent();
	}

	private void OnRegisterClicked(object? sender, EventArgs e)
	{
		count++;

		/*
		if (count == 1)
			RegisterBtn.Text = $"Clicked {count} time";
		else
			RegisterBtn.Text = $"Clicked {count} times";
		*/

		/*
		RegisterBtn.Text = "Выполняется регистрация...";
		*/

		// динамическая загрузка интерфейса из XML-кода
		// при использовании такого подхода производительность будет снижаться,
		//  поэтому делать это стоит лишь при необходимости
		string xaml = "<Button Text=\"⌛ Выполняется регистрация..\"  />";
		RegisterBtn.LoadFromXaml(xaml);

		SemanticScreenReader.Announce(RegisterBtn.Text);
	}
}
