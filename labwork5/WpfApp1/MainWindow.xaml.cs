using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private TextBox activeLeftTextBox = null;
        private TextBox activeRightTextBox = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_GotFocus_Left(object sender, RoutedEventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (activeLeftTextBox != null && activeLeftTextBox != currentTextBox)
            {
                activeLeftTextBox.Style = (Style)Resources["SmallTextBoxStyle"];
            }

            currentTextBox.Style = (Style)Resources["BigTextBoxStyle"];
            activeLeftTextBox = currentTextBox;
        }

        private void TextBox_GotFocus_Right(object sender, RoutedEventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;

            if (activeRightTextBox != null && activeRightTextBox != currentTextBox)
            {
                activeRightTextBox.Style = (Style)Resources["SmallTextBoxStyle"];
            }

            currentTextBox.Style = (Style)Resources["BigTextBoxStyle"];
            activeRightTextBox = currentTextBox;
        }
    }
}
