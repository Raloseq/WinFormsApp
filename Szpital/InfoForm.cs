using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szpital.Custom.Forms;

namespace Szpital
{
    public partial class InfoForm : BaseForm
    {
        EmployeesForm ef;
        public List<string> info = new List<string>();
        public InfoForm(List<string> info)
        {
            this.info = info;
            InitializeComponent();
            ef = new EmployeesForm();
            ef.SendInfo += DbOperationInfo;
            ShowText();
        }

        public void ShowText()
        {
            foreach (string item in info)
            {
                dbOperationInfoValue.Text += item + '\n';
            }
        }
        public void DbOperationInfo(string text)
        {
            info.Add(text);
            dbOperationInfoValue.Text += $"{text}\n";
        }
    }
}
