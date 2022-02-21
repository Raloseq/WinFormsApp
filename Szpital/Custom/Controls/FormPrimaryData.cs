using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szpital.Custom.Controls
{
    public partial class FormPrimaryData : UserControl
    {
        ErrorProvider nameErrorProvider = new ErrorProvider();
        ErrorProvider surnameErrorProvider = new ErrorProvider();
        ErrorProvider peselErrorProvider = new ErrorProvider();
        ErrorProvider phoneErrorProvider = new ErrorProvider();
        public FormPrimaryData()
        {
            InitializeComponent();
        }

        public string NameUserControl
        {
            get
            {
                return nameTextBox.Text;
            }
            set
            {
                nameTextBox.Text = value;
            }
        }
        public string SurnameUserControl
        {
            get
            {
                return surnameTextBox.Text;
            }
            set
            {
                surnameTextBox.Text = value;
            }
        }
        public string PeselUserControl
        { 
            get
            {
                return peselTextBox.Text;
            }
            set
            {
                peselTextBox.Text = value;
            }
        }
        public string PhoneUserControl
        {
            get
            {
                return phoneNumberTextBox.Text;
            }
            set
            {
                phoneNumberTextBox.Text = value;
            }
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                e.Cancel = true;
                nameErrorProvider.SetError(nameTextBox, "Wprowadz imie");
            }
            else
            {
                e.Cancel = false;
                nameErrorProvider.SetError(nameTextBox, null);
            }
        }

        private void surnameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(surnameTextBox.Text))
            {
                e.Cancel = true;
                surnameErrorProvider.SetError(surnameTextBox, "Wprowadz nazwisko");
            }
            else
            {
                e.Cancel = false;
                surnameErrorProvider.SetError(surnameTextBox, null);
            }
        }

        private void peselTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (peselTextBox.TextLength != 11)
            {
                e.Cancel = true;
                peselErrorProvider.SetError(peselTextBox, "Pesel musi zawierac 11 znakow");
            }
            else
            {
                e.Cancel = false;
                peselErrorProvider.SetError(peselTextBox, null);
            }
        }

        private void phoneNumberTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                e.Cancel = true;
                phoneErrorProvider.SetError(phoneNumberTextBox, "Wprowadz numer telefonu");
            }
            else
            {
                e.Cancel = false;
                phoneErrorProvider.SetError(phoneNumberTextBox, null);
            }
        }
    }
}
