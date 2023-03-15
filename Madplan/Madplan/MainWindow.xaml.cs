using BusinessLogicCore.BLL;
using DTOCore.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private Car _ret;

        private ObservableCollection<Car> _retList;

        public MainWindow()
        {
            InitializeComponent();
            _retList = _bll.GetRetList();

            updateList();
           
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            //AddWindow addWindow = new AddWindow();
            //addWindow.Show();
        }

        private void updateList()
        {
            RetterListBox.DataContext = _retList;
            RetterListBox.ItemsSource = _retList;
        }
    }
}
