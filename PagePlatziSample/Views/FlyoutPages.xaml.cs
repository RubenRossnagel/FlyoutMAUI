using Microsoft.Maui.Controls;

namespace PagePlatziSample.Views
{
    public partial class FlyoutPages : FlyoutPage
    {
        public FlyoutPages()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            IsPresented = false;
        }

        private void OnShowMenuClicked(object sender, EventArgs e)
        {
            myFlyoutPage.IsPresented = true;
        }

        private void OnPage3Tapped(object sender, EventArgs e)
        {
            myFlyoutPage.Detail.Navigation.PushAsync(new ContentPage
            {
                Title = "Detalles Page 03",
                Content = new StackLayout
                {
                    Children = { new Label { }, new Label { Text = "Detalle 03", FontSize=45, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center},}
                }
            });
            myFlyoutPage.IsPresented = false;
        }

        private void OnPage2Tapped(object sender, EventArgs e)
        {
            myFlyoutPage.Detail.Navigation.PushAsync(new ContentPage
            {
                Title = "Detalles Page 02",
                Content = new StackLayout
                {
                    Children = { new Label { }, new Label { Text = "Detalle 02", FontSize = 45, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, }
                }
            });
            myFlyoutPage.IsPresented = false;
        }

        private void OnPage1Tapped(object sender, EventArgs e)
        {
            myFlyoutPage.Detail.Navigation.PushAsync(new ContentPage
            {
                Title = "Detalles Page 01",
                Content = new StackLayout
                {
                    Children = { new Label { }, new Label { Text = "Detalle 01", FontSize = 45, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center }, }
                }
            });
            myFlyoutPage.IsPresented = false;
        }

        private void OnPage4Tapped(object sender, EventArgs e)
        {
            myFlyoutPage.IsPresented = false;
            Navigation.PushModalAsync(new Page4());
        }


    }
}
