using CommunityToolkit.Maui.Alerts;
using System.Reflection;

namespace MauiComm_IssueSnackbar;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void btnShow_Clicked(object sender, EventArgs e)
    {
        // Create Snackbar
        var snackbar = Snackbar.Make(
            "This is test message.",
            action: null,
            actionButtonText: string.Empty,
            duration: new TimeSpan(0, 0, 0, 0, 3500),
            visualOptions: new CommunityToolkit.Maui.Core.SnackbarOptions() {
                BackgroundColor = Colors.Red,
                TextColor = Colors.White },
            anchor: null
        );
        // Display Snackbar
        snackbar.Show();
    }
}

