namespace DomekWGorach
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void buttonLike_Clicked(object sender, EventArgs e)
        {
            count++;
            labelCounter.Text = $"{count} polubień";
        }

        private void buttonDislike_Clicked(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            labelCounter.Text = $"{count} polubień";
        }
    }

}
