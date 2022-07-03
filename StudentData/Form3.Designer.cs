
namespace StudentData
{
    partial class UpdateStudent
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
            this.panelStd = new System.Windows.Forms.Panel();
            this.lbStdReg = new System.Windows.Forms.Label();
            this.stdDetails = new System.Windows.Forms.GroupBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbProgram = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.panelStd.SuspendLayout();
            this.stdDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelStd
            // 
            this.panelStd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStd.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelStd.Controls.Add(this.lbStdReg);
            this.panelStd.Location = new System.Drawing.Point(-4, -1);
            this.panelStd.Name = "panelStd";
            this.panelStd.Size = new System.Drawing.Size(370, 71);
            this.panelStd.TabIndex = 0;
            // 
            // lbStdReg
            // 
            this.lbStdReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lbStdReg.AutoSize = true;
            this.lbStdReg.Font = new System.Drawing.Font("Poppins", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStdReg.ForeColor = System.Drawing.Color.White;
            this.lbStdReg.Location = new System.Drawing.Point(80, 17);
            this.lbStdReg.Name = "lbStdReg";
            this.lbStdReg.Size = new System.Drawing.Size(211, 42);
            this.lbStdReg.TabIndex = 0;
            this.lbStdReg.Text = "Update Student";
            // 
            // stdDetails
            // 
            this.stdDetails.BackColor = System.Drawing.SystemColors.Control;
            this.stdDetails.Controls.Add(this.cbGender);
            this.stdDetails.Controls.Add(this.btnUpdate);
            this.stdDetails.Controls.Add(this.txtProgram);
            this.stdDetails.Controls.Add(this.txtEmail);
            this.stdDetails.Controls.Add(this.txtName);
            this.stdDetails.Controls.Add(this.lbGender);
            this.stdDetails.Controls.Add(this.lbProgram);
            this.stdDetails.Controls.Add(this.lbEmail);
            this.stdDetails.Controls.Add(this.lbName);
            this.stdDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stdDetails.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdDetails.ForeColor = System.Drawing.Color.Black;
            this.stdDetails.Location = new System.Drawing.Point(30, 90);
            this.stdDetails.Name = "stdDetails";
            this.stdDetails.Size = new System.Drawing.Size(303, 417);
            this.stdDetails.TabIndex = 1;
            this.stdDetails.TabStop = false;
            this.stdDetails.Text = "Student Details";
            // 
            // cbGender
            // 
            this.cbGender.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(32, 288);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(239, 30);
            this.cbGender.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(32, 348);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(239, 36);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.clkUpdate);
            // 
            // txtProgram
            // 
            this.txtProgram.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProgram.Location = new System.Drawing.Point(34, 218);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(239, 25);
            this.txtProgram.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(34, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(239, 25);
            this.txtEmail.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(34, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(239, 25);
            this.txtName.TabIndex = 1;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(30, 264);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(56, 22);
            this.lbGender.TabIndex = 0;
            this.lbGender.Text = "Gender:";
            // 
            // lbProgram
            // 
            this.lbProgram.AutoSize = true;
            this.lbProgram.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProgram.Location = new System.Drawing.Point(30, 194);
            this.lbProgram.Name = "lbProgram";
            this.lbProgram.Size = new System.Drawing.Size(64, 22);
            this.lbProgram.TabIndex = 0;
            this.lbProgram.Text = "Program:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(30, 124);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(45, 22);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(30, 54);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(48, 22);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Name:";
            // 
            // UpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 529);
            this.Controls.Add(this.stdDetails);
            this.Controls.Add(this.panelStd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Student";
            this.Load += new System.EventHandler(this.LoadScreen);
            this.panelStd.ResumeLayout(false);
            this.panelStd.PerformLayout();
            this.stdDetails.ResumeLayout(false);
            this.stdDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelStd;
        private System.Windows.Forms.Label lbStdReg;
        private System.Windows.Forms.GroupBox stdDetails;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbProgram;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbGender;
    }
}