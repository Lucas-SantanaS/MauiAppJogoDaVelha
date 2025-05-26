namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Animação Fade Out
            await btn.FadeTo(0.5, 100); // Fica meio transparente

            // Animação Fade In
            await btn.FadeTo(1, 100); // Volta ao normal

            btn.IsEnabled = false;

            if(vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            } else
            {
                btn.Text = "O";
                vez = "X";
            }

            /* Verificando se o X ganhou na 1ª linha */
            if(btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") 
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }

           
        } // Fecha método

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
        }

    } // Fecha Classe
} // Fecha Namespace
