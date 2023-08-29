using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using Shiny.Push;

namespace ShinyPushTest;

public partial class MainPage : ContentPage
{
	private readonly IPushManager _pushManager;

	public MainPage(IPushManager pushManager)
	{
		_pushManager = pushManager;

		InitializeComponent();
	}

	private async void OnRegisterClicked(object sender, EventArgs e)
	{
		var pushAccessState = await _pushManager.RequestAccess();

        var text = $"Push notification access state is {pushAccessState.Status}";
        var toast = Toast.Make(text, ToastDuration.Long);

        await toast.Show();
    }
}

