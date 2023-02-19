using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.View
{
    public class overviewModel
    {
        public string heading { get; set; }
        public string date { get; set; }
        public string summary { get; set; }

      public static overviewModel GetOverView() { 
            
            var overview = new overviewModel();
            {

            overview.heading = "Detta är en översikt";
            overview.date = DateTime.Now.ToString();
            overview.summary = "Detta är en summering";
            }
            return overview;

        
        }

    }
}
