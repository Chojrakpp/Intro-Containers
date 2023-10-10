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

namespace WPF_Controller
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

        private void rect_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender == rectLT)
            {
                rectLT.Fill = Brushes.Red;
            }

            if (sender == rectRT)
            {
                rectRT.Fill = Brushes.Red;
            }

            if (sender == rectRB)
            {
                rectRB.Fill = Brushes.Red;
            }

            if (sender == rectLB)
            {
                rectLB.Fill = Brushes.Red;
            }
        }

        private void rect_MouseLeave(object sender, MouseEventArgs e)
        {
            if (sender == rectLT)
            {
                rectLT.Fill = Brushes.Black;
            }

            if (sender == rectRT)
            {
                rectRT.Fill = Brushes.White;
            }

            if (sender == rectRB)
            {
                rectRB.Fill = Brushes.Black;
            }

            if (sender == rectLB)
            {
                rectLB.Fill = Brushes.White;
            }
        }
    }
}
