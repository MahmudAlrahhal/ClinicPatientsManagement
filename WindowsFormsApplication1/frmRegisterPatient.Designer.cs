namespace WindowsFormsApplication1
{
    partial class frmRegisterPatient
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnShowPatientByDate = new System.Windows.Forms.Button();
            this.grdPatientByPhone = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCutomerDetails = new System.Windows.Forms.Button();
            this.txtSearchByPhoneNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientByPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "Not:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Phone Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Surname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Patient Name:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(194, 188);
            this.txtNote.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(235, 234);
            this.txtNote.TabIndex = 18;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(194, 104);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(235, 22);
            this.txtPhoneNumber.TabIndex = 17;
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.Location = new System.Drawing.Point(194, 60);
            this.txtPatientSurname.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(235, 22);
            this.txtPatientSurname.TabIndex = 16;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(194, 16);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(235, 22);
            this.txtPatientName.TabIndex = 15;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(194, 489);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(162, 34);
            this.btnRegister.TabIndex = 24;
            this.btnRegister.Text = "Register a New Patient";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnShowPatientByDate
            // 
            this.btnShowPatientByDate.Location = new System.Drawing.Point(1420, 688);
            this.btnShowPatientByDate.Name = "btnShowPatientByDate";
            this.btnShowPatientByDate.Size = new System.Drawing.Size(269, 33);
            this.btnShowPatientByDate.TabIndex = 25;
            this.btnShowPatientByDate.Text = "Show Patients By Appointment Date";
            this.btnShowPatientByDate.UseVisualStyleBackColor = true;
            this.btnShowPatientByDate.Click += new System.EventHandler(this.btnShowPatientByDate_Click);
            // 
            // grdPatientByPhone
            // 
            this.grdPatientByPhone.Location = new System.Drawing.Point(458, 24);
            this.grdPatientByPhone.MainView = this.gridView1;
            this.grdPatientByPhone.Name = "grdPatientByPhone";
            this.grdPatientByPhone.Size = new System.Drawing.Size(1263, 472);
            this.grdPatientByPhone.TabIndex = 26;
            this.grdPatientByPhone.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.grdPatientByPhone;
            this.gridView1.Name = "gridView1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1141, 685);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 38);
            this.button1.TabIndex = 27;
            this.button1.Text = "Add a New Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCutomerDetails
            // 
            this.btnCutomerDetails.BackColor = System.Drawing.SystemColors.Control;
            this.btnCutomerDetails.Location = new System.Drawing.Point(1256, 548);
            this.btnCutomerDetails.Name = "btnCutomerDetails";
            this.btnCutomerDetails.Size = new System.Drawing.Size(259, 39);
            this.btnCutomerDetails.TabIndex = 28;
            this.btnCutomerDetails.Text = "Show Patient Details by Phone Number";
            this.btnCutomerDetails.UseVisualStyleBackColor = false;
            this.btnCutomerDetails.Click += new System.EventHandler(this.btnCutomerDetails_Click);
            // 
            // txtSearchByPhoneNumber
            // 
            this.txtSearchByPhoneNumber.Location = new System.Drawing.Point(1256, 507);
            this.txtSearchByPhoneNumber.Name = "txtSearchByPhoneNumber";
            this.txtSearchByPhoneNumber.Size = new System.Drawing.Size(259, 22);
            this.txtSearchByPhoneNumber.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1031, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Enter Phone Number";
            // 
            // frmRegisterPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1733, 745);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchByPhoneNumber);
            this.Controls.Add(this.btnCutomerDetails);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdPatientByPhone);
            this.Controls.Add(this.btnShowPatientByDate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtPatientSurname);
            this.Controls.Add(this.txtPatientName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRegisterPatient";
            this.Text = "Register Patient";
            this.Load += new System.EventHandler(this.frmRegisterPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPatientByPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnShowPatientByDate;
        private DevExpress.XtraGrid.GridControl grdPatientByPhone;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCutomerDetails;
        private System.Windows.Forms.TextBox txtSearchByPhoneNumber;
        private System.Windows.Forms.Label label4;
    }
}