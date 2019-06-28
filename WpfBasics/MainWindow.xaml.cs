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

namespace WpfBasics
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

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"The description is {this.DescriptionTxt.Text}");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            this.checkbox1.IsChecked = false;
            this.checkbox2.IsChecked = false;
            this.checkbox3.IsChecked = false;
            this.checkbox4.IsChecked = false;
            this.checkbox5.IsChecked = false;
            this.checkbox6.IsChecked = false;

            this.checkbox11.IsChecked = false;
            this.checkbox12.IsChecked = false;
            this.checkbox13.IsChecked = false;
            this.checkbox14.IsChecked = false;
            this.checkbox15.IsChecked = false;
            this.checkbox16.IsChecked = false;

        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthTxt.Text += ((CheckBox)sender).Content + " ";
        }

        private void Finish_ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteTxt == null)
                return;

            var combo = (ComboBox)sender;
            var comboItem = (ComboBoxItem)combo.SelectedValue;

            this.NoteTxt.Text = (string)comboItem.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Finish_ComboBox_SelectionChanged(this.FinishDropdown, null);
        }
    }
}
