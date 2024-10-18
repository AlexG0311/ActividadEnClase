namespace ActividadC
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnChangeColorButtonClicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Colors.LightBlue;
        }

    }

}
