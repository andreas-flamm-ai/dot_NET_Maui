namespace WorkoutTimers.App.Views;

//[QueryProperty(nameof(Message), nameof(Message))]
public partial class Settings : ContentPage
{
	public Settings(Lib.ViewModels.SettingsModel model)
	{
		InitializeComponent();
		BindingContext = model;

	}

	//public string Message
	//{
	//	get { return msgLabel?.Text; }
	//	set { msgLabel.Text = value; }
	//}

}