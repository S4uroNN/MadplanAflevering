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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class AddPersonel : Window
    {

        private CarBLL _carBLL;
        private int _id;

        public AddPersonel()
        {
            InitializeComponent();
            _carBLL = new CarBLL();
            _id = _carBLL.GetPersonel().Last().Id;

        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string age = txtAge.Text;

            Person person = new Person(name, age);

            _carBLL.AddPerson(person);
            DialogResult = true;


        }
    }
}
