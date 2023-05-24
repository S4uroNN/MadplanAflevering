using BusinessLogicCore.BLL;
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
    /// Interaction logic for AddCarToService.xaml
    /// </summary>
    public partial class AddCarToService : Window
    {
        private CarBLL _carBll;
        private Service _service;
        public AddCarToService()
        {
            InitializeComponent();
            _carBll = new CarBLL();
            _service = _carBll.GetService(1);

            carList.ItemsSource = _carBll.GetCarList();

        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            _carBll.AddCarToService(_service, ((Car)carList.SelectedItem));
            DialogResult = true;
        }

        private void cancelbtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
