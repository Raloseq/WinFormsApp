using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szpital.Custom.Forms;

namespace Szpital
{
    public partial class MainForm : BaseForm
    {
        List<Form> openedForm = new List<Form>();
        List<string> valueSend = new List<string>();
        string text = "Program na zaliczenie";
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitMainMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void employeesMainMenuButton_Click(object sender, EventArgs e)
        {
            EmployeesForm ef = new EmployeesForm();
            InfoForm infoForm = new InfoForm(valueSend);
            ef.SendInfo += infoForm.DbOperationInfo;
            valueSend = infoForm.info;
            openedForm.Add(ef);
            openChildForm(ef);
            infoForm.Show();
        }

        private void clientsMainMenuButton_Click(object sender, EventArgs e)
        {
            PaintForm clientsForm = new PaintForm();
            openedForm.Add(clientsForm);
            openChildForm(clientsForm);
        }

        private void openChildForm(Form form)
        {
            form.TopLevel = false;
            form.Parent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.BringToFront();
            form.Show();
        }

        private void homeMainMenuButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in openedForm)
            {
                form.Dispose();
            }
        }

        private void WriteText()
        {
            int index = 0;
            while (index < text.Length)
            { 
                Thread.Sleep(100);
                homeText?.Invoke(new Action(() => homeText.Text += text[index]));
                index++;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            homeText.Text = string.Empty;
            Thread t = new Thread(new ThreadStart(WriteText));
            t.Start();

        }

        private void infoMainMenuButton_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(valueSend);
            openedForm.Add(infoForm);
            openChildForm(infoForm);
        }
    }
}
