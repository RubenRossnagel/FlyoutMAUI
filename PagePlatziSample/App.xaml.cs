using Microsoft.Maui.Controls;

namespace PagePlatziSample
{

    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Views.FlyoutPages();
        }
    }
}