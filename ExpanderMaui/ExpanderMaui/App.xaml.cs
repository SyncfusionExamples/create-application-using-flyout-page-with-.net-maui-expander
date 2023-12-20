using ExpanderMaui.Views;

namespace ExpanderMaui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ExpanderFlyoutPage();
        }
    }
}
