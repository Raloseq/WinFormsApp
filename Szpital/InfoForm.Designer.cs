
namespace Szpital
{
    partial class InfoForm
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
            this.dbOperationInfoValue = new System.Windows.Forms.Label();
            this.dbOperationInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dbOperationInfoValue
            // 
            this.dbOperationInfoValue.AutoSize = true;
            this.dbOperationInfoValue.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbOperationInfoValue.Location = new System.Drawing.Point(314, 65);
            this.dbOperationInfoValue.Name = "dbOperationInfoValue";
            this.dbOperationInfoValue.Size = new System.Drawing.Size(0, 19);
            this.dbOperationInfoValue.TabIndex = 1;
            // 
            // dbOperationInfoLabel
            // 
            this.dbOperationInfoLabel.AutoSize = true;
            this.dbOperationInfoLabel.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dbOperationInfoLabel.Location = new System.Drawing.Point(313, 21);
            this.dbOperationInfoLabel.Name = "dbOperationInfoLabel";
            this.dbOperationInfoLabel.Size = new System.Drawing.Size(207, 28);
            this.dbOperationInfoLabel.TabIndex = 0;
            this.dbOperationInfoLabel.Text = "Ostatnio zrobiono:";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dbOperationInfoValue);
            this.Controls.Add(this.dbOperationInfoLabel);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dbOperationInfoValue;
        private System.Windows.Forms.Label dbOperationInfoLabel;
    }
}