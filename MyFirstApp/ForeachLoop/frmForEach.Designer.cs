
namespace MyFirstApp.ForeachLoop
{
    partial class frmForEach
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.AccessibleName = "";
            this.btnSave.Location = new System.Drawing.Point(272, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 75);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(197, 37);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(224, 20);
            this.txtStudentId.TabIndex = 2;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(197, 147);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(224, 20);
            this.txtAge.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(197, 112);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(224, 20);
            this.txtSurname.TabIndex = 4;
            // 
            // frmForEach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 281);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtStudentId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnSave);
            this.Name = "frmForEach";
            this.Text = "frmForEach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSurname;
    }
}