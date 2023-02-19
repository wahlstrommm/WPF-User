﻿using System;
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

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for overViewControler.xaml
    /// </summary>
    public partial class overViewControler : UserControl
    {
        public overViewControler()
        {
            InitializeComponent();
            DataContext = overviewModel.GetOverView();
        }
    }
}
