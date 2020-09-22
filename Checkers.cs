using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace VSLauncher
{
    class Checkers
    {
        public bool isUserDataChanged()
        {
                if (String.Equals(GlobalVars.originalLang, GlobalVars.newLang) &&
                    String.Equals(GlobalVars.originalUsername, GlobalVars.newUsername) &&
                    String.Equals(GlobalVars.originalUID, GlobalVars.newUID) &&
                    GlobalVars.newUsername.Length >= 3 && GlobalVars.newUID.Length >= 6)
                {
                    return false;
                }
                else
                    return true;
        }

        public bool isUserNameOK()
        {
            string userNameRegexCheckPattern = "^(\\w|-){1,16}$";
            //string userUIDRegexCheckPattern = "^(\\w|-){1,32}$";
            if (Regex.IsMatch(GlobalVars.newUsername, userNameRegexCheckPattern, RegexOptions.IgnoreCase)
                && GlobalVars.newUsername.Length >= 3)
            {
                return true;
            }
            else
                return false;
        }

        public bool isUserUIDOK()
        {
            //string userNameRegexCheckPattern = "^(\\w|-){1,16}$";
            string userUIDRegexCheckPattern = "^(\\w|-){1,32}$";
            if (Regex.IsMatch(GlobalVars.newUID, userUIDRegexCheckPattern, RegexOptions.IgnoreCase)
                && GlobalVars.newUID.Length >= 6)
            {
                return true;
            }
            else
                return false;
        }





        //public void UDRegexCheck()
        //{
        //    if (this.isUserNameOK())
        //    {
        //        if (this.isUserUIDOK())
        //        {
        //            return;
        //        } else
        //        {
        //            MainWindow MainWindow = new MainWindow();
        //            MainWindow.StatusText.Text = "• UID должен состоять из букв и цифр, " +
        //            "не содержать пробелов " +
        //            "и специальных символов и быть длиной от 6 до 32 символов.";
        //        }
        //    } else
        //    {
        //        MainWindow MainWindow = new MainWindow();
        //        MainWindow.StatusText.Text = "• Никнейм должен состоять из букв и цифр, " +
        //        "не содержать пробелов " +
        //        "и специальных символов и быть длиной от 3 до 16 символов.";
        //    }
        //}
    }
}
