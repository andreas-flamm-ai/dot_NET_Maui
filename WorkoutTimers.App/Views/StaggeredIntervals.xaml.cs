namespace WorkoutTimers.App.Views;

public partial class StaggeredIntervals : ContentPage
{
	public StaggeredIntervals(Lib.ViewModels.StaggeredIntervalsModel model)
	{
		InitializeComponent();
		BindingContext = model;
		model.RefreshIntervalsCommand.Execute(null);

	}
}