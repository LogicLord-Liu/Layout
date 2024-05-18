using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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

namespace DataBandingTest
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        //ArrayList list = new ArrayList();

        ObservableCollection<String> list = new ObservableCollection<String>();
        //ObservableCollection<Student> list = new ObservableCollection<Student>();

        public MainWindow()
        {
            InitializeComponent();
            this.BindingUiData();
            this.InitializedList();
            ListBoxTarget.ItemsSource = list;
            this.DataContext = this;
            ListBoxTemplateTarget.ItemsSource = list; 
        }
        private void BindingUiData()
        {
            Binding binding = new Binding();
            binding.Source = TexBoxSource1;
            binding.Path = new PropertyPath("Text");
            TexBoxTarget.SetBinding(TextBox.TextProperty, binding);
        }
        private void InitializedList()
        {
            list.Add("001");
            list.Add("002");

        }

        private void AddValue_Click(object sender, RoutedEventArgs e)
        {
            var va1 = InputValue.Text;
            list.Add(va1);
           
        }
    }
    class StringToBooleanC : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var val = value.ToString();
            if (val == "Apple")
            {
                return true;
            }
            else if (val == "App") return true;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    class Student
    {
        private string Name { get; set; }
        public string ID { get; set; }
    }
}
