namespace Egz_zaw
{
    public partial class MainPage : ContentPage
    {
        public List<string> Animals { get; set; } = new List<string> { "Pies", "Kot", "Świnka morska" };
        private string animalTapped = "";

        public string User { get; set; } = "Kacper Kudła";

        public MainPage()
        {
            BindingContext = this;
            -InitializeComponent();
        }

        private void okButton_Clicked(object sender, EventArgs e)
        {
            
        }

       
    }

}