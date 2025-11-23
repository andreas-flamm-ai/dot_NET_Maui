namespace WorkoutTimers.App.Views;

public partial class NewStaggeredInterval : ContentPage
{
	public NewStaggeredInterval(Lib.ViewModels.NewStaggeredIntervalModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}