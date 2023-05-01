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
    /// Interaction logic for addWindow.xaml
    /// </summary>
    public partial class addWindow : Window
    {
        CarBLL _bll = new CarBLL();
        public addWindow()
        {
            InitializeComponent();
            //int id = _bll.GetCarList().Last().ID + 1;
            //txbID.Text = id.ToString();

        }

        private void addCar_Click(object sender, RoutedEventArgs e)
        {
            
            int id = Int32.Parse(txbID.Text);
            string make = txtMake.Text;
            string model = txtModel.Text;
            int? milage = null;
            int? owners = null;
            int year = 0;
            DateTime synet = dpMOT.SelectedDate.Value;
            if (txtMilage.Text.Length > 0 )
            {
                milage = Int32.Parse(txtMilage.Text);
            }
            if(txtOwners.Text.Length > 0 )
            {
                owners = Int32.Parse(txtOwners.Text);
            }
            if(txtYear.Text.Length > 0)
            {
                year = Int32.Parse(txtYear.Text);
            }

            Car car = new Car (make, model, milage,year ,synet);

            _bll.AddCar(car);
            DialogResult = true;
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
