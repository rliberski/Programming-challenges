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

namespace _001
{



    public partial class MainWindow : Window
    {
        ComboBoxData data;

        public MainWindow()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            data = new ComboBoxData();

            DataTypeComboBox.ItemsSource = data.unitTypes;
            DataTypeComboBox.SelectedIndex = 0;

            //FromComboBox.ItemsSource =
            //FromComboBox.SelectedIndex = 0;
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
