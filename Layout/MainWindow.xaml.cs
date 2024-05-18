using System.Data;
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

namespace Layout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnInput_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                txtInput.Text += button.Content.ToString();
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            txtInput.Text = "";
        }

        private void BtnOperator_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                txtInput.Text += button.Content.ToString();
            }
            
        }

        private void BtnEquals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                var result = new DataTable().Compute(input, null);
                txtInput.Text = result.ToString();
            }
            catch (Exception ex)
            {
                txtInput.Text = "Error";
            }
        }

        private void LittleSize_Click(object sender, RoutedEventArgs e)
        {
            txtInput.FontSize = 15;
        }

        private void LargeSize_Click(object sender, RoutedEventArgs e)
        {
            txtInput.FontSize = 50;
        }
    }
}