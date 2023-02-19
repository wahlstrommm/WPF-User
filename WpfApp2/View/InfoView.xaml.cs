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
    /// Interaction logic for InfoView.xaml
    /// </summary>
    public partial class InfoView : UserControl
    {
        
        public InfoView()
        {
            InitializeComponent();
            this.DataContext = this;
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            confirmText.Content = "Du har lagt till en ny användare!";
           int AgeFromUser= Int32.Parse(Age.Text);
          
            InfoModel.getInfo( Fname.Text, Lname.Text, AgeFromUser, Email.Text);
            FnameResult.Content = "Förnamn: " + Fname.Text;
            LnameResult.Content = "Efternamn: " + Lname.Text;
            AgeResult.Content = "Ålder: " + Age.Text;
            EmailResult.Content ="Email: " + Email.Text;
        }
    }
}
