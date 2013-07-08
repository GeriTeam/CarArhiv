using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace CarWorkCards
{

    static class CarWorkCards
    {
       // public const string DB = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\radoslav\Documents\GitHub\CarArhiv\CarWorkCards\CarArhiv.mdb";
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fmMain());
        }


    }
}
