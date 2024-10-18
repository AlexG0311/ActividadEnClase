namespace ActividadC
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnNewButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("New Button", "This button was added by a collaborator!", "OK");
        }
    }

}
