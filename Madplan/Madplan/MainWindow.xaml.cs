using BilhusUI;
using BusinessLogicCore.BLL;
using DTOCore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace Madplan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CarBLL _bll = new CarBLL();

        private ObservableCollection<Car> _carList;
        public Car _car;


        public MainWindow()
        {
            InitializeComponent();
            UpdateLists();
            _car = (Car)carList.SelectedItem;
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            addWindow window = new addWindow();
            window.ShowDialog();
            
            UpdateLists();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            _bll.RemoveCar(((Car)carList.SelectedItem));
            UpdateLists();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow editWindow = new EditWindow((Car)carList.SelectedItem);
            editWindow.ShowDialog();
            UpdateLists();
        }



        private void UpdateLists()
        {
            _carList = _bll.GetCarList();
            carList.ItemsSource = null;
            carList.ItemsSource = _carList;
            mainGrid.DataContext = _carList;

        }
    }
}
