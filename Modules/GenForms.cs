using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DODO_Pitsa.Modules
{
    class GenForms
    {
        public static void RegWindow()
        {
            Register Register = new Register();
            Register.Show();

        }
        public static void MainMenu()
        {
            MainMenu MainMenu = new MainMenu();
            MainMenu.Show();

        }
        public static void About()
        {
            About About = new About();
            About.Show();

        }
    }
}
