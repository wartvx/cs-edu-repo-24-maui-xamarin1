namespace FirstMauiApp.Pages;

public partial class LoginPage : ContentPage
{
	// константа для текста кнопки
	public const string BUTTON_TEXT = "Войти";

	int count = 0;

	public LoginPage()
	{
		InitializeComponent();
	}

	private void OnLoginClicked(object? sender, EventArgs e)
	{
		count++;

		/*
		if (count == 1)
			LoginBtn.Text = $"Clicked {count} time";
		else
			LoginBtn.Text = $"Clicked {count} times";
		*/

		/*
		LoginBtn.Text = "Выполняется вход...";
		*/

		/*
		// динамическая загрузка интерфейса из XML-кода
		// при использовании такого подхода производительность будет снижаться,
		//  поэтому делать это стоит лишь при необходимости
		string xaml = "<Button Text=\"⌛ Выполняется вход..\"  />";
		LoginBtn.LoadFromXaml(xaml);
		*/

		if (count == 0)
		{
			// Если первая попытка - просто меняем сообщения
			LoginBtn.Text = $"Выполняется вход..";
		}
		else if (count > 5) // Слишком много попыток - показываем ошибку
		{
			// Деактивируем кнопку
			LoginBtn.IsEnabled = false;
			// Показываем текстовое сообщение об ошибке
			ErrorMessageLabel.Text = "Слишком много попыток! Попробуйте позже.";
		}
		else
		{
			// Изменяем текст кнопки и показываем количество попыток входа
			LoginBtn.Text = $"Выполняется вход...   Попыток входа: {count}";
		}

		SemanticScreenReader.Announce(LoginBtn.Text);
	}
}
