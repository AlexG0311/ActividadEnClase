namespace ActividadC
{
    public partial class MainPage : ContentPage
    {
        int contador = 0;
       

        public MainPage()
        {
            InitializeComponent();

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
        private async void OnOpenWebsiteButtonClicked(object sender, EventArgs e)
        {
            var uri = new Uri("https://www.youtube.com/");
            await Launcher.Default.OpenAsync(uri);
        }

    }

}
}