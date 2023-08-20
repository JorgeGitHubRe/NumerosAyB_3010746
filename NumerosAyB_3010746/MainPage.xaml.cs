namespace NumerosAyB_3010746
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double NumA = Convert.ToDouble(NB.Text);
            double NumB = Convert.ToDouble(NB.Text);

            double resultado = Math.Pow((NumA + NumB), 2) / 2;

            Re.Text = "El resultado es: " + resultado;


        }
    }
}