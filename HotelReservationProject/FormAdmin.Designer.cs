namespace HotelReservationProject
{
    partial class FormAdmin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.issueBillBtn = new System.Windows.Forms.Button();
            this.reserveBtn = new System.Windows.Forms.Button();
            this.otherBillBtn = new System.Windows.Forms.Button();
            this.displyRomBtn = new System.Windows.Forms.Button();
            this.updProfileBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "Press button: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 31);
            this.label2.TabIndex = 11;
            this.label2.Text = "Which action you want to perform?      ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(-20, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1134, 33);
            this.label1.TabIndex = 18;
            this.label1.Text = "                                                 RECEPTIONIST VIEW               " +
    "                                                    ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // issueBillBtn
            // 
            this.issueBillBtn.AutoSize = true;
            this.issueBillBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.issueBillBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issueBillBtn.Location = new System.Drawing.Point(364, 330);
            this.issueBillBtn.Name = "issueBillBtn";
            this.issueBillBtn.Size = new System.Drawing.Size(220, 41);
            this.issueBillBtn.TabIndex = 23;
            this.issueBillBtn.Text = "ISSUE BILLS";
            this.issueBillBtn.UseVisualStyleBackColor = true;
            this.issueBillBtn.Click += new System.EventHandler(this.issueBillBtn_Click);
            // 
            // reserveBtn
            // 
            this.reserveBtn.AutoSize = true;
            this.reserveBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.reserveBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveBtn.Location = new System.Drawing.Point(364, 136);
            this.reserveBtn.Name = "reserveBtn";
            this.reserveBtn.Size = new System.Drawing.Size(220, 41);
            this.reserveBtn.TabIndex = 22;
            this.reserveBtn.Text = "RESERVE ROOMS";
            this.reserveBtn.UseVisualStyleBackColor = true;
            this.reserveBtn.Click += new System.EventHandler(this.reserveBtn_Click);
            // 
            // otherBillBtn
            // 
            this.otherBillBtn.AutoSize = true;
            this.otherBillBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.otherBillBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherBillBtn.Location = new System.Drawing.Point(364, 264);
            this.otherBillBtn.Name = "otherBillBtn";
            this.otherBillBtn.Size = new System.Drawing.Size(220, 41);
            this.otherBillBtn.TabIndex = 20;
            this.otherBillBtn.Text = "ADD OTHER BILLS";
            this.otherBillBtn.UseVisualStyleBackColor = true;
            this.otherBillBtn.Click += new System.EventHandler(this.otherBillBtn_Click);
            // 
            // displyRomBtn
            // 
            this.displyRomBtn.AutoSize = true;
            this.displyRomBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.displyRomBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displyRomBtn.Location = new System.Drawing.Point(364, 201);
            this.displyRomBtn.Name = "displyRomBtn";
            this.displyRomBtn.Size = new System.Drawing.Size(220, 41);
            this.displyRomBtn.TabIndex = 19;
            this.displyRomBtn.Text = "DISPLAY ROOMS";
            this.displyRomBtn.UseVisualStyleBackColor = true;
            this.displyRomBtn.Click += new System.EventHandler(this.displyRomBtn_Click);
            // 
            // updProfileBtn
            // 
            this.updProfileBtn.AutoSize = true;
            this.updProfileBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.updProfileBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updProfileBtn.Location = new System.Drawing.Point(364, 392);
            this.updProfileBtn.Name = "updProfileBtn";
            this.updProfileBtn.Size = new System.Drawing.Size(220, 59);
            this.updProfileBtn.TabIndex = 24;
            this.updProfileBtn.Text = "CHANGE PASSWORD";
            this.updProfileBtn.UseVisualStyleBackColor = true;
            this.updProfileBtn.Click += new System.EventHandler(this.updProfileBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.logoutBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(784, 444);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(121, 41);
            this.logoutBtn.TabIndex = 57;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationProject.Properties.Resources.blogSpan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(987, 514);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.updProfileBtn);
            this.Controls.Add(this.issueBillBtn);
            this.Controls.Add(this.reserveBtn);
            this.Controls.Add(this.otherBillBtn);
            this.Controls.Add(this.displyRomBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button issueBillBtn;
        private System.Windows.Forms.Button reserveBtn;
        private System.Windows.Forms.Button otherBillBtn;
        private System.Windows.Forms.Button displyRomBtn;
        private System.Windows.Forms.Button updProfileBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}