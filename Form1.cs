using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace validationForm
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var regxName = @"^[a-zA-Z\s]+$";
            var regxEmail = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
            if (Regex.Match(textName.Text,regxName, RegexOptions.IgnoreCase).Success)
            {
                labelMsgName.ForeColor = Color.Green;
                labelMsgName.Text = "Success";
            }
            else
            {
                labelMsgName.ForeColor = Color.Red;
                labelMsgName.Text = "Invalid";
            }
            if (Regex.Match(textEmail.Text, regxEmail).Success)
            {
                labelMsgEmail.ForeColor = Color.Green;
                labelMsgEmail.Text = "Success";
            }
            else
            {
                labelMsgEmail.ForeColor = Color.Red;
                labelMsgEmail.Text = "Invalid";
            }
        }
        public static bool VerifyRegEx(string testPattern)
        {
            bool isValid = true;

            if ((testPattern != null) && (testPattern.Trim().Length > 0))
            {
                try
                {
                    Regex.Match("", testPattern);
                }
                catch (ArgumentException)
                {
                    isValid = false;
                }
            }
            else
            {
                isValid = false;
            }

            return (isValid);
        }
    }
}
