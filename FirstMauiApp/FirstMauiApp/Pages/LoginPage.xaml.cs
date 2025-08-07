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
			loginBtn.Text = $"Clicked {count} time";
		else
			loginBtn.Text = $"Clicked {count} times";
		*/

        /*
		loginBtn.Text = "Выполняется вход...";
		*/

        /*
		// динамическая загрузка интерфейса из XML-кода
		// при использовании такого подхода производительность будет снижаться,
		//  поэтому делать это стоит лишь при необходимости
		string xaml = "<Button Text=\"⌛ Выполняется вход..\"  />";
		loginBtn.LoadFromXaml(xaml);
		*/

        if (count == 0)
        {
            // Если первая попытка - просто меняем сообщения
            loginBtn.Text = $"Выполняется вход..";
        }
        else if (count > 5) // Слишком много попыток - показываем ошибку
        {
            // Деактивируем кнопку
            loginBtn.IsEnabled = false;

            /*
            // Показываем текстовое сообщение об ошибке
            infoMessageLabel.Text = "Слишком много попыток! Попробуйте позже.";
            */

            // Получаем последний дочерний элемент, используя свойство Children, затем выполняем распаковку
            var infoMessageLabel1 = (Label)verticalStackLayout.Children.Last();
            // Задаем текст элемента
            infoMessageLabel1.Text = "Слишком много попыток! Попробуйте позже.";


            // Добавляем элемент через свойство Children
            verticalStackLayout.Children.Add(new Label
            {
                Text = "Уж очень много попыток! Попробуйте позже.",
                TextColor = Colors.Red,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                Padding = new Thickness()
                {
                    Bottom = 30,
                    Left = 10,
                    Right = 10,
                    Top = 30
                }
            });

		}
        else
        {
            // Изменяем текст кнопки и показываем количество попыток входа
            loginBtn.Text = $"Выполняется вход...   Попыток входа: {count}";
        }

		SemanticScreenReader.Announce(loginBtn.Text);
	}
}
