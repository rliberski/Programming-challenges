using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _000
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
           
        }

        private void DataTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FromComboBox.ItemsSource = data.unitTypes[DataTypeComboBox.SelectedIndex].list;
            FromComboBox.SelectedIndex = 0;
            ToComboBox.ItemsSource = data.unitTypes[DataTypeComboBox.SelectedIndex].list;
            ToComboBox.SelectedIndex = 0;
        }

        private void ValueBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double inputValue = Convert.ToDouble(ValueBox.Text.ToString());
                double fromValue = data.unitTypes[DataTypeComboBox.SelectedIndex].list[FromComboBox.SelectedIndex].value;
                double toValue = data.unitTypes[DataTypeComboBox.SelectedIndex].list[ToComboBox.SelectedIndex].value;

                double result = inputValue / fromValue * toValue;
                ResultBox.Text = result.ToString();
            }
            catch(Exception exc)
            {
                ResultBox.Text = "";
            }
        }
    }
}
