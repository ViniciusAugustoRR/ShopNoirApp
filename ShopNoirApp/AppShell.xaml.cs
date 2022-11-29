namespace ShopNoirApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}
    private void Sair(object sender, EventArgs e)
    {
        Shell.Current.FlyoutIsPresented = false;
        Shell.Current.GoToAsync("//LoginPage");
    }
}
