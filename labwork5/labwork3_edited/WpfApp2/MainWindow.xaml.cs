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
using System.Windows.Ink;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            inkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
            brushSizeSlider.Value = 10;

            colorComboBox.SelectedIndex = 0;

            drawMode.IsChecked = true;
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (colorComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string selectedColor = selectedItem.Content.ToString();

                switch (selectedColor)
                {
                    case "Красный":
                        inkCanvas.DefaultDrawingAttributes.Color = Colors.Red;
                        break;
                    case "Зеленый":
                        inkCanvas.DefaultDrawingAttributes.Color = Colors.Green;
                        break;
                    case "Синий":
                        inkCanvas.DefaultDrawingAttributes.Color = Colors.Blue;
                        break;
                }
            }
        }

        private void BrushSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (inkCanvas != null)
            {
                inkCanvas.DefaultDrawingAttributes.Width = brushSizeSlider.Value;
                inkCanvas.DefaultDrawingAttributes.Height = brushSizeSlider.Value;
            }
        }

        private void Mode_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb != null)
            {
                switch (rb.Content.ToString())
                {
                    case "Рисование":
                        inkCanvas.EditingMode = InkCanvasEditingMode.Ink;
                        break;
                    case "Редактирование":
                        inkCanvas.EditingMode = InkCanvasEditingMode.Select;
                        break;
                    case "Удаление":
                        inkCanvas.EditingMode = InkCanvasEditingMode.EraseByStroke;
                        break;
                }
            }
        }
    }
}