namespace gradient
{
    public partial class MainPage : ContentPage
    {
        private bool isAnimating; // Flaga pozwoli nam sterować animacją, nalezy ustawić wartość początkową
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e) // Funkcja obslugująca wywołanie animacji dla gradientu 
        {
            if (isAnimating) return; // Sprawdzamy flage dzięki czemu możemy dodać zatrzymanie animacji

            isAnimating = true; // Ustawiamy flagę aby rozpoczać animacje

            Color[] colors =  // Tablica kolorów potrzebna do utworzenia gradientu i animacji
            {
                Colors.Red,
                Colors.Blue,
                Colors.White,
                Colors.Black,
                Colors.Purple,
                Colors.Pink,
                Colors.Yellow,
                Colors.Green,
            };

            while (isAnimating) // Główna pętla animacji
            {
                for (int i = 0; i < colors.Length - 1; i++) // pętla w zakresie ilosci kolorów w tablicy
                {

                    gradientB.GradientStops[0].Color = colors[i]; // Mechanizm ustawiający odpowiednie kolory w gradiencie,
                                                                  // ustawiamy ich tyle ile jest przejśc w gradiencie,
                                                                  // dla kolejnych przejsc i uzyskania efektu przewijania                                                                  // skorzystamy z operatora modulo w indeksie tablicy
                    await Task.Delay(500); // robimy pauze dla lepszego efektu
                }
            }
        }
    }

}
