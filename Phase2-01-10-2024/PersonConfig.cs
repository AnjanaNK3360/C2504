using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    static class PersonConfig
    {
        public static EditPersonWindow FrmEditPerson {  get; set; }
        public static PersonViewModel VueModel { get; set; }
        static PersonConfig()
        {
            VueModel = new PersonViewModel();
            FrmEditPerson = new EditPersonWindow();
        }
    }
}
