namespace ActividadC
{
    public partial class MainPage : ContentPage
    {
        int contador = 0;


        public MainPage()
        {
            InitializeComponent();
        }
        // Funcionalidad del botón
        private void OnButtonClicked(object sender, EventArgs e)
        {
            contador++; // Incrementar el contador
            lblContador.Text = $"Has presionado el botón {contador} veces"; 

            }// Actualizar el texto del Label
        private void OnChangeColorButtonClicked(object sender, EventArgs e)
        
        {
            this.BackgroundColor = Colors.LightBlue;

        }
        private void OnNewButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("New Button", "This button was added by a collaborator!", "OK");
        }
        private async void OnOpenWebsiteButtonClicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://example.com/");
            await Launcher.Default.OpenAsync(uri);
        }

    }

}
