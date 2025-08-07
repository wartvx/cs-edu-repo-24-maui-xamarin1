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
			registerBtn.Text = $"Clicked {count} time";
		else
			registerBtn.Text = $"Clicked {count} times";
		*/

		/*
		registerBtn.Text = "Выполняется регистрация...";
		*/

		// динамическая загрузка интерфейса из XML-кода
		// при использовании такого подхода производительность будет снижаться,
		//  поэтому делать это стоит лишь при необходимости
		string xaml = "<Button Text=\"⌛ Выполняется регистрация..\"  />";
		registerBtn.LoadFromXaml(xaml);

		SemanticScreenReader.Announce(registerBtn.Text);
	}
}
