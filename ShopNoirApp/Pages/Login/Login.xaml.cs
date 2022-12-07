using CommunityToolkit.Maui.Core;

namespace ShopNoirApp.Pages.Login;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        var toast = CommunityToolkit.Maui.Alerts.Toast.Make("Roupa Selecionada", ToastDuration.Short, 14);
        toast.Show();
    }
}