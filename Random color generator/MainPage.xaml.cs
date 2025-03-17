using System;
using System.ComponentModel;

namespace MauiApp2

{

    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void randomButtonClicked(object sender, EventArgs e)
        {
            Random random = new Random();

            int red = random.Next(0, 255);
            int green = random.Next(0, 255);
            int blue = random.Next(0, 255);

            r_slide.Value = red;
            g_slide.Value = green;
            b_slide.Value = blue;
        }

        private void changeBG(object sender, ValueChangedEventArgs e)
        {
            int red = (int)r_slide.Value;
            int green = (int)g_slide.Value;
            int blue = (int)b_slide.Value;

            Color color = Color.FromRgb(red, green, blue);

            hex.Text = Color.FromRgb(red, green, blue).ToHex();

            Container.BackgroundColor = color;

            hex.Text = color.ToHex();
        }

        private void SetColor(Color color)
        {
            randomButton.BackgroundColor = color;

            Container.BackgroundColor = color;

            hex.Text = color.ToHex();

        }
    }
}