﻿using BusinessLogicCore.BLL;
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
        }

        private void addCar_Click(object sender, RoutedEventArgs e)
        {
            string make = txtMake.Text;
            string model = txtModel.Text;
            string milage = txtMilage.Text;
            string owners = txtOwners.Text;

            new 
        }
    }
}