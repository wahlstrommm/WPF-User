using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.View
{
    public class PersonalModel
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }

        public static PersonalModel GetPersonal()
        {
            var personal = new PersonalModel();
            {

                personal.Fname = "Magnus";
                personal.Lname = "Andersson";
                personal.Email = "Magnus.Test@email.com";
            }
            return personal;
        }

        
    }
}
