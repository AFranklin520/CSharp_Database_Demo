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

namespace WpfDemo
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

        private void btnButton_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = txbUserInput.Text;

            if(cbCheck1.IsChecked==true)
            {
                lblResult.Content += "Checked1!";
            }
            if (cbCheck2.IsChecked == true)
            {
                lblResult.Content += "Checked2!";
            }
            if (cbCheck3.IsChecked == true)
            {
                lblResult.Content += "Checked3!";
            }


            //Radio buttons group 1
            if (rbOption1.IsChecked == true)
            {
                lblResult.Content += "Option1!";
            }
            else if (rbOption2.IsChecked == true)
            {
                lblResult.Content += "Option2!";
            }
            else if (rbOption3.IsChecked == true)
            {
                lblResult.Content += "Option3!";
            }

            //Radio buttons group 2
            if (rbOption4.IsChecked == true)
            {
                lblResult.Content += "Option4!";
            }
            else if (rbOption5.IsChecked == true)
            {
                lblResult.Content += "Option5!";
            }
            else if (rbOption6.IsChecked == true)
            {
                lblResult.Content += "Option6!";
            }
        }
    }
}
