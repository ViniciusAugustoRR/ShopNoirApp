using ShopNoirApp.Models;

namespace ShopNoirApp;

public partial class MainPage : ContentPage
{
    public List<DefaultItemCV> Items = new List<DefaultItemCV>()
    {
        new DefaultItemCV()
        {
            Title = "Cropped Diana",
            ImageURL = "Resources/Images/cropped_esha.jpg"
        },
        new DefaultItemCV()
        {
            Title = "Vestido Marie",
            ImageURL = "Resources/Images/vestido_day_preto.jpg"
        },
        new DefaultItemCV()
        {
            Title = "Saia Zoe",
            ImageURL = "Resources/Images/conjunto_aretha.jpg"
        }
    };
    public MainPage()
	{
		InitializeComponent();
        CVRoupas.ItemsSource = Items;

    }


}

