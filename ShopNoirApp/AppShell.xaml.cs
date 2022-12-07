using ShopNoirApp.Pages.Login;

namespace ShopNoirApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("//LoginPage/RegisterPage", typeof(Register));

    }
    private void Sair(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = false;
        Shell.Current.GoToAsync("//LoginPage");
    }
}
