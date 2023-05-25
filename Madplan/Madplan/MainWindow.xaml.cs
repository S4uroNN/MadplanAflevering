using BilhusUI;
using BusinessLogicCore.BLL;
using DTOCore.Model;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
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
        private ObservableCollection<Person> _personList;
        private ObservableCollection<Car> _CarsInService;
        public Car _car;
        public Service _service;


        public MainWindow()
        {
            InitializeComponent();
            UpdateLists();
            _car = (Car)carList.SelectedItem;
            _service = _bll.GetService(1);
            
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
            _carList = _bll.GetCarListObserv(); 
            carList.ItemsSource = null;
            carList.ItemsSource = _carList;
            mainGrid.DataContext = _carList;


            _personList = _bll.GetPersonel();
            persList.ItemsSource = null;
            persList.ItemsSource = _personList;

            _CarsInService = _bll.GetCarsInService();
            serviceCar.ItemsSource = null;
            serviceCar.ItemsSource = _CarsInService;

            

        }

        private void personelAddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddPersonel window = new AddPersonel();
            window.ShowDialog();

            UpdateLists();
        }

        private void personelDeletebtn_Click(object sender, RoutedEventArgs e)
        {
            _bll.RemovePerson(((Person)persList.SelectedItem));
            UpdateLists();
        }

        private void carAddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddCarToService window = new AddCarToService();
            window.ShowDialog();
            UpdateLists();
        }
    }
}
