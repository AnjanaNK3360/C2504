using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterProject
{
    static class CounterConfig
    {
        public static CounterWindow Frmcounter {  get; set; }
        public static CounterViewModel VueModel { get; set; }
        static CounterConfig()
        {
            VueModel = new CounterViewModel();
            Frmcounter = new CounterWindow();
        }
    }
}
