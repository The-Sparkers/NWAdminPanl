using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NawazEyeWebProject_AdminPanel.ProjectClasses
{
    class MessageBoxes
    {
        public static void Error(string messsage)
        {
            MessageBox.Show(messsage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        public static void Success(string messsage)
        {
            MessageBox.Show(messsage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}
