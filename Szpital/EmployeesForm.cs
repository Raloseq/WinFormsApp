using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szpital.Custom.Forms;

namespace Szpital
{
    public delegate void DbOperationHandler(string text);
    public partial class EmployeesForm : BaseForm
    {
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        public event DbOperationHandler SendInfo;
        Pracownicy model = new Pracownicy();
        public EmployeesForm()
        {
            InitializeComponent();
        }
        private string dboperation;
        public string Dboperation
        {
            get
            {
                return dboperation;
            }
            set
            {
                dboperation = value;
                SendInfo?.Invoke(value);
            }
        }
        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'szpitalDataSet.Pracownicy' table. You can move, or remove it, as needed.
            LoadData();  

        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            model.Imie = formPrimaryDataEmployee.NameUserControl;
            model.Nazwisko = formPrimaryDataEmployee.SurnameUserControl;
            model.Pesel = formPrimaryDataEmployee.PeselUserControl;
            model.NrTel = formPrimaryDataEmployee.PhoneUserControl;
            model.Wyplata = decimal.Parse(paymentEmployeeFormTextBox.Text);
            model.Stanowisko = positionEmployeeFormTextBox.Text;
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (SzpitalEntities db = new SzpitalEntities())
                {
                    db.Pracownicies.Add(model);
                    MessageBox.Show("Dodano do bazy");
                    Dboperation = $"Dodano pracownika: {model.Imie} {model.Nazwisko}";
                    client.SaveEmployeeToFile($"{model.Imie} {model.Nazwisko}");
                    ftpInfo.Text = client.Backup();
                    db.SaveChanges();

                }
                LoadData();
                Clear();
            }
            
        }

        private void LoadData()
        {
            this.pracownicyTableAdapter.Fill(this.szpitalDataSet.Pracownicy);
        }

        private void dataGridViewEmployee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewEmployee.CurrentRow.Index != -1)
            {
                model.IdPracownika = Convert.ToInt32(dataGridViewEmployee.CurrentRow.Cells[0].Value);
                using (SzpitalEntities db = new SzpitalEntities())
                {
                    model = db.Pracownicies.Where(x => x.IdPracownika == model.IdPracownika).FirstOrDefault();
                    formPrimaryDataEmployee.NameUserControl = model.Imie;
                    formPrimaryDataEmployee.SurnameUserControl = model.Nazwisko;
                    formPrimaryDataEmployee.PeselUserControl = model.Pesel;
                    formPrimaryDataEmployee.PhoneUserControl = model.NrTel;
                    paymentEmployeeFormTextBox.Text = model.Wyplata.ToString();
                    positionEmployeeFormTextBox.Text = model.Stanowisko;
                }
            }
            
        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz usunac tego pracownika?","Message",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SzpitalEntities db = new SzpitalEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Pracownicies.Attach(model);
                    }
                    try
                    {
                        db.Pracownicies.Remove(model);
                        db.SaveChanges();
                        MessageBox.Show("Pracownik usuniety");
                        Dboperation = $"Usunieto pracownika: {model.Imie} {model.Nazwisko}";
                        client.DeleteEmployeeFromFile($"{model.Imie} {model.Nazwisko}");
                        ftpInfo.Text = client.Backup();
                    } catch (Exception exception)
                    {
                        MessageBox.Show($"Nie moge usunac tego pracownika z powodu : {exception.Message}");
                    }
                    
                    
                }                            
            }
            LoadData();
            Clear();
            
        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                using (SzpitalEntities db = new SzpitalEntities())
                {                
                    db.Entry(model).State = EntityState.Modified;
                    string test = $"{model.Imie} {model.Nazwisko}";
                    model.Imie = formPrimaryDataEmployee.NameUserControl;
                    model.Nazwisko = formPrimaryDataEmployee.SurnameUserControl;
                    model.Pesel = formPrimaryDataEmployee.PeselUserControl;
                    model.NrTel = formPrimaryDataEmployee.PhoneUserControl;
                    model.Wyplata = decimal.Parse(paymentEmployeeFormTextBox.Text);
                    model.Stanowisko = positionEmployeeFormTextBox.Text;
                    MessageBox.Show("Zaaktualizowano pracownika");
                    Dboperation = $"Zaktualizowano pracownika: {model.Imie} {model.Nazwisko}";
                    client.UpdateEmployeeInFile(test, $"{model.Imie} {model.Nazwisko}");
                    ftpInfo.Text = client.Backup();
                    db.SaveChanges();
                }
                LoadData();
                Clear();
            }
        }

        private void Clear()
        {
            formPrimaryDataEmployee.NameUserControl = "";
            formPrimaryDataEmployee.SurnameUserControl = "";
            formPrimaryDataEmployee.PeselUserControl = "";
            formPrimaryDataEmployee.PhoneUserControl = "";
            paymentEmployeeFormTextBox.Text = "";
            positionEmployeeFormTextBox.Text = "";
        }

        private void resetFtpText_DoWork(object sender, DoWorkEventArgs e)
        {
            Timer reset = new Timer();
            if (ftpInfo.Text != "")
            {
                reset.Interval = 5000;
                reset.Tick += (o, args) => ftpInfo.Text = "";
                reset.Start();
            }
        }
    }
}
