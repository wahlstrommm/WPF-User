using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.View
{
    
    public class InfoModel
    {
        
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public static InfoModel getInfo(string Fname, string Lname, int Age, string Email)
        {
            var info = new InfoModel();
            info.Fname = Fname;
            info.Lname = Lname;
            info.Age = Age;
            info.Email = Email;
            return info;
        }
    }
}
