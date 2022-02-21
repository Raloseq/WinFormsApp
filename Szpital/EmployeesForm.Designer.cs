
namespace Szpital
{
    partial class EmployeesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.formPrimaryDataEmployee = new Szpital.Custom.Controls.FormPrimaryData();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peselDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wyplataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanowiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownicyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.szpitalDataSet = new Szpital.SzpitalDataSet();
            this.pracownicyTableAdapter = new Szpital.SzpitalDataSetTableAdapters.PracownicyTableAdapter();
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.paymentEmployeeFormTextBox = new System.Windows.Forms.TextBox();
            this.positionEmployeeFormTextBox = new System.Windows.Forms.TextBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteEmployeeButton = new System.Windows.Forms.Button();
            this.updateEmployeeButton = new System.Windows.Forms.Button();
            this.ftpInfo = new System.Windows.Forms.Label();
            this.resetFtpText = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szpitalDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // formPrimaryDataEmployee
            // 
            this.formPrimaryDataEmployee.Location = new System.Drawing.Point(14, 14);
            this.formPrimaryDataEmployee.Name = "formPrimaryDataEmployee";
            this.formPrimaryDataEmployee.NameUserControl = "";
            this.formPrimaryDataEmployee.PeselUserControl = "";
            this.formPrimaryDataEmployee.PhoneUserControl = "";
            this.formPrimaryDataEmployee.Size = new System.Drawing.Size(274, 175);
            this.formPrimaryDataEmployee.SurnameUserControl = "";
            this.formPrimaryDataEmployee.TabIndex = 0;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AutoGenerateColumns = false;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.peselDataGridViewTextBoxColumn,
            this.nrTelDataGridViewTextBoxColumn,
            this.wyplataDataGridViewTextBoxColumn,
            this.stanowiskoDataGridViewTextBoxColumn});
            this.dataGridViewEmployee.DataSource = this.pracownicyBindingSource;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(49, 295);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.Size = new System.Drawing.Size(743, 150);
            this.dataGridViewEmployee.TabIndex = 1;
            this.dataGridViewEmployee.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdPracownika";
            this.Column1.HeaderText = "IdPracownika";
            this.Column1.Name = "Column1";
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // peselDataGridViewTextBoxColumn
            // 
            this.peselDataGridViewTextBoxColumn.DataPropertyName = "Pesel";
            this.peselDataGridViewTextBoxColumn.HeaderText = "Pesel";
            this.peselDataGridViewTextBoxColumn.Name = "peselDataGridViewTextBoxColumn";
            // 
            // nrTelDataGridViewTextBoxColumn
            // 
            this.nrTelDataGridViewTextBoxColumn.DataPropertyName = "NrTel";
            this.nrTelDataGridViewTextBoxColumn.HeaderText = "NrTel";
            this.nrTelDataGridViewTextBoxColumn.Name = "nrTelDataGridViewTextBoxColumn";
            // 
            // wyplataDataGridViewTextBoxColumn
            // 
            this.wyplataDataGridViewTextBoxColumn.DataPropertyName = "Wyplata";
            this.wyplataDataGridViewTextBoxColumn.HeaderText = "Wyplata";
            this.wyplataDataGridViewTextBoxColumn.Name = "wyplataDataGridViewTextBoxColumn";
            // 
            // stanowiskoDataGridViewTextBoxColumn
            // 
            this.stanowiskoDataGridViewTextBoxColumn.DataPropertyName = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.HeaderText = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.Name = "stanowiskoDataGridViewTextBoxColumn";
            // 
            // pracownicyBindingSource
            // 
            this.pracownicyBindingSource.DataMember = "Pracownicy";
            this.pracownicyBindingSource.DataSource = this.szpitalDataSet;
            // 
            // szpitalDataSet
            // 
            this.szpitalDataSet.DataSetName = "SzpitalDataSet";
            this.szpitalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pracownicyTableAdapter
            // 
            this.pracownicyTableAdapter.ClearBeforeFill = true;
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(674, 48);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.addEmployeeButton.TabIndex = 2;
            this.addEmployeeButton.Text = "Add";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // paymentEmployeeFormTextBox
            // 
            this.paymentEmployeeFormTextBox.Location = new System.Drawing.Point(355, 53);
            this.paymentEmployeeFormTextBox.Name = "paymentEmployeeFormTextBox";
            this.paymentEmployeeFormTextBox.Size = new System.Drawing.Size(100, 21);
            this.paymentEmployeeFormTextBox.TabIndex = 3;
            // 
            // positionEmployeeFormTextBox
            // 
            this.positionEmployeeFormTextBox.Location = new System.Drawing.Point(355, 80);
            this.positionEmployeeFormTextBox.Name = "positionEmployeeFormTextBox";
            this.positionEmployeeFormTextBox.Size = new System.Drawing.Size(100, 21);
            this.positionEmployeeFormTextBox.TabIndex = 4;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(277, 57);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(57, 15);
            this.moneyLabel.TabIndex = 5;
            this.moneyLabel.Text = "Wyplata";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(275, 83);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(74, 15);
            this.positionLabel.TabIndex = 6;
            this.positionLabel.Text = "Stanowisko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dane Pracownika";
            // 
            // deleteEmployeeButton
            // 
            this.deleteEmployeeButton.Location = new System.Drawing.Point(674, 110);
            this.deleteEmployeeButton.Name = "deleteEmployeeButton";
            this.deleteEmployeeButton.Size = new System.Drawing.Size(75, 23);
            this.deleteEmployeeButton.TabIndex = 9;
            this.deleteEmployeeButton.Text = "Delete";
            this.deleteEmployeeButton.UseVisualStyleBackColor = true;
            this.deleteEmployeeButton.Click += new System.EventHandler(this.deleteEmployeeButton_Click);
            // 
            // updateEmployeeButton
            // 
            this.updateEmployeeButton.Location = new System.Drawing.Point(674, 77);
            this.updateEmployeeButton.Name = "updateEmployeeButton";
            this.updateEmployeeButton.Size = new System.Drawing.Size(75, 27);
            this.updateEmployeeButton.TabIndex = 10;
            this.updateEmployeeButton.Text = "Update";
            this.updateEmployeeButton.UseVisualStyleBackColor = true;
            this.updateEmployeeButton.Click += new System.EventHandler(this.updateEmployeeButton_Click);
            // 
            // ftpInfo
            // 
            this.ftpInfo.AutoSize = true;
            this.ftpInfo.Location = new System.Drawing.Point(46, 495);
            this.ftpInfo.Name = "ftpInfo";
            this.ftpInfo.Size = new System.Drawing.Size(0, 15);
            this.ftpInfo.TabIndex = 11;
            // 
            // resetFtpText
            // 
            this.resetFtpText.DoWork += new System.ComponentModel.DoWorkEventHandler(this.resetFtpText_DoWork);
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 519);
            this.Controls.Add(this.ftpInfo);
            this.Controls.Add(this.updateEmployeeButton);
            this.Controls.Add(this.deleteEmployeeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.positionEmployeeFormTextBox);
            this.Controls.Add(this.paymentEmployeeFormTextBox);
            this.Controls.Add(this.addEmployeeButton);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.formPrimaryDataEmployee);
            this.Name = "EmployeesForm";
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szpitalDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom.Controls.FormPrimaryData formPrimaryDataEmployee;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private SzpitalDataSet szpitalDataSet;
        private System.Windows.Forms.BindingSource pracownicyBindingSource;
        private SzpitalDataSetTableAdapters.PracownicyTableAdapter pracownicyTableAdapter;
        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peselDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wyplataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanowiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox paymentEmployeeFormTextBox;
        private System.Windows.Forms.TextBox positionEmployeeFormTextBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteEmployeeButton;
        private System.Windows.Forms.Button updateEmployeeButton;
        private System.Windows.Forms.Label ftpInfo;
        private System.ComponentModel.BackgroundWorker resetFtpText;
    }
}