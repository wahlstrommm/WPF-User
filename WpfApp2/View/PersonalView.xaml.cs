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

namespace WpfApp2.View
{
    /// <summary>
    /// Interaction logic for PersonalView.xaml
    /// </summary>
    public partial class PersonalView : UserControl
    {
        public PersonalView()
        {
            InitializeComponent();
            DataContext = PersonalModel.GetPersonal();
            var test = PersonalModel.GetPersonal();
            var column = new DataGridTextColumn();
            MyGrid.Columns.Add(column);
            PersonalModel item = new PersonalModel();
            item.Email = "true";
            item.Fname = "test";
            item.Lname = "test";
            MyGrid.Items.Add(item);
            // MyGrid.Items.Add(new PersonalModel { Fname = "b.1", Lname = "b.2", Email = "b.3" });

           // MyGrid.ItemsSource=(test.Fname);
        }
    }
}
