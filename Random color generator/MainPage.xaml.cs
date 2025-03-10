namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        int random = new Random();

        Color color = Color.FromRgb(

                random.Next(0, 255),
                random.Next(0, 255),
                random.Next(0, 255)

        );

       


        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }

        private void SetColor(Color color)
        {
            randomButton.BackgroundColor = color;
            Container.BackgroundColor = color;
            labelHex.Text = color.ToHex();

            
        }
        
        private void RandomButton_Clicked(object sender, EventArgs e)
        {

        }
    }

}
