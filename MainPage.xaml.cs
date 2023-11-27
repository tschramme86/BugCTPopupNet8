using CommunityToolkit.Maui.Views;

namespace BugCTPopupNet8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OpenPopupBtn_Clicked(object sender, EventArgs e)
        {
            this.ShowPopup(new MyPopup());
        }
    }
}
