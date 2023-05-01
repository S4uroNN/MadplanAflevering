using DTOCore.Model;
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
using System.Windows.Shapes;

namespace BilhusUI
{
    /// <summary>
    /// Interaction logic for EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        Car car = null;

        public EditWindow()
        {
            InitializeComponent();
        }
        public EditWindow(Car car)
        {
            this.car = car;
            InitializeComponent();
            editGrid.DataContext = car;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
