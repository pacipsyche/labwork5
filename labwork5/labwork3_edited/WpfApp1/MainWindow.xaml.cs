using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private int backgroundColorIndex = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeBackground(object sender, RoutedEventArgs e)
        {
            switch (backgroundColorIndex)
            {
                case 0:
                    this.Background = new SolidColorBrush(Colors.LightBlue);
                    statusText.Text = "Цвет фона: Светло-синий";
                    break;
                case 1:
                    this.Background = new SolidColorBrush(Colors.LightGreen);
                    statusText.Text = "Цвет фона: Светло-зеленый";
                    break;
                case 2:
                    this.Background = new SolidColorBrush(Colors.LightCoral);
                    statusText.Text = "Цвет фона: Светло-коричневый";
                    break;
                case 3:
                    this.Background = new SolidColorBrush(Colors.LightGoldenrodYellow);
                    statusText.Text = "Цвет фона: Светло-желтый";
                    break;
                default:
                    this.Background = new SolidColorBrush(Colors.White);
                    statusText.Text = "Цвет фона: Белый";
                    break;
            }

            backgroundColorIndex++;
            if (backgroundColorIndex > 3)
            {
                backgroundColorIndex = 0;
            }
        }

        private void ShowDeveloperInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Мирзоев Алишер, 2307б2", "О разработчике", MessageBoxButton.OK, MessageBoxImage.Information);
            statusText.Text = "Информация о разработчике";
        }

        private void CloseApp(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
