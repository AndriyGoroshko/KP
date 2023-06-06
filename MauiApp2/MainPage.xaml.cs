using Microsoft.Maui.Controls;

namespace MauiApp2
{
    public partial class MainPage : ContentPage
    {
        private Color currentColor = Color.FromRgb(255,255,255); // Початковий колір фону

        public MainPage()
        {
            InitializeComponent();
            square.IsVisible = false;
        }

        private void ChangeColorClicked(object sender, EventArgs e)
        {
            // Генеруємо випадковий колір
            Random random = new Random();
            Color newColor = Color.FromRgb(random.Next(256), random.Next(256), random.Next(256));

            // Змінюємо фон на новий колір
            BackgroundColor = newColor;
            currentColor = newColor;

        }
        private void LoadImageClicked(object sender, EventArgs e)
        {
            myImage.Source = ImageSource.FromFile("Images/creativity.png"); 
        }
        private void DrawSquareClicked(object sender, EventArgs e)
        {
            square.IsVisible = true; 
        }
    }
}