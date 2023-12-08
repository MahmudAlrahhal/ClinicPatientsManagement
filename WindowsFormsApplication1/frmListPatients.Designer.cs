namespace WindowsFormsApplication1
{
    partial class frmListPatients
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
            this.grdAppointments = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.DateforAppointments = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDrName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAppointments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdAppointments
            // 
            this.grdAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAppointments.Location = new System.Drawing.Point(12, 50);
            this.grdAppointments.Name = "grdAppointments";
            this.grdAppointments.RowHeadersWidth = 51;
            this.grdAppointments.RowTemplate.Height = 24;
            this.grdAppointments.Size = new System.Drawing.Size(1124, 649);
            this.grdAppointments.TabIndex = 15;
            this.grdAppointments.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdAppointments_RowHeaderMouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Show Appointment By Date";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(466, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 33);
            this.button3.TabIndex = 17;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DateforAppointments
            // 
            this.DateforAppointments.Location = new System.Drawing.Point(243, 6);
            this.DateforAppointments.Name = "DateforAppointments";
            this.DateforAppointments.Size = new System.Drawing.Size(208, 28);
            this.DateforAppointments.TabIndex = 18;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(311, 660);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(162, 34);
            this.btnRegister.TabIndex = 33;
            this.btnRegister.Text = "Register a New Patient";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 353);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Not:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Patient Phone Number(ID):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "AppointmentTime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Appointment Date:";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(291, 353);
            this.txtNote.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(235, 234);
            this.txtNote.TabIndex = 28;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(291, 102);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(235, 28);
            this.txtPhoneNumber.TabIndex = 27;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(291, 58);
            this.txtTime.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(235, 28);
            this.txtTime.TabIndex = 26;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(291, 14);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(235, 28);
            this.txtDate.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtDrName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPaidAmount);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTotalPrice);
            this.panel1.Controls.Add(this.txtNote);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.txtDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTime);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1180, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 744);
            this.panel1.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 249);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 41;
            this.label9.Text = "Dr Name:";
            // 
            // txtDrName
            // 
            this.txtDrName.Location = new System.Drawing.Point(291, 245);
            this.txtDrName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDrName.Name = "txtDrName";
            this.txtDrName.Size = new System.Drawing.Size(235, 28);
            this.txtDrName.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 199);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 37;
            this.label7.Text = "Paid Amount:";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Location = new System.Drawing.Point(291, 192);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(235, 28);
            this.txtPaidAmount.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "Total Price:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(291, 142);
            this.txtTotalPrice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(235, 28);
            this.txtTotalPrice.TabIndex = 34;
            // 
            // frmListPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DateforAppointments);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grdAppointments);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmListPatients";
            this.Text = "Appointment Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAppointments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grdAppointments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker DateforAppointments;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDrName;
    }
}

