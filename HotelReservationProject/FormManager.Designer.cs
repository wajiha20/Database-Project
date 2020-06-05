namespace HotelReservationProject
{
    partial class FormManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displyRomBtn = new System.Windows.Forms.Button();
            this.updRateBtn = new System.Windows.Forms.Button();
            this.resrvationRoomBtn = new System.Windows.Forms.Button();
            this.viewReportBtn = new System.Windows.Forms.Button();
            this.updProfileBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(-21, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1115, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "                                                        MANAGER PAGE             " +
    "                                                      ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Which action you want to perform?      ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Wheat;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Press button: ";
            // 
            // displyRomBtn
            // 
            this.displyRomBtn.AutoSize = true;
            this.displyRomBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.displyRomBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displyRomBtn.Location = new System.Drawing.Point(345, 127);
            this.displyRomBtn.Name = "displyRomBtn";
            this.displyRomBtn.Size = new System.Drawing.Size(220, 39);
            this.displyRomBtn.TabIndex = 6;
            this.displyRomBtn.Text = "DISPLAY ROOMS";
            this.displyRomBtn.UseVisualStyleBackColor = true;
            this.displyRomBtn.Click += new System.EventHandler(this.displyRomBtn_Click);
            // 
            // updRateBtn
            // 
            this.updRateBtn.AutoSize = true;
            this.updRateBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.updRateBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updRateBtn.Location = new System.Drawing.Point(345, 297);
            this.updRateBtn.Name = "updRateBtn";
            this.updRateBtn.Size = new System.Drawing.Size(220, 48);
            this.updRateBtn.TabIndex = 7;
            this.updRateBtn.Text = "UPDATE ROOM \r\nRATES";
            this.updRateBtn.UseVisualStyleBackColor = true;
            this.updRateBtn.Click += new System.EventHandler(this.updRateBtn_Click);
            // 
            // resrvationRoomBtn
            // 
            this.resrvationRoomBtn.AutoSize = true;
            this.resrvationRoomBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.resrvationRoomBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resrvationRoomBtn.Location = new System.Drawing.Point(345, 187);
            this.resrvationRoomBtn.Name = "resrvationRoomBtn";
            this.resrvationRoomBtn.Size = new System.Drawing.Size(220, 39);
            this.resrvationRoomBtn.TabIndex = 8;
            this.resrvationRoomBtn.Text = "VIEW RESERVATIONS";
            this.resrvationRoomBtn.UseVisualStyleBackColor = true;
            this.resrvationRoomBtn.Click += new System.EventHandler(this.resrvationRoomBtn_Click);
            // 
            // viewReportBtn
            // 
            this.viewReportBtn.AutoSize = true;
            this.viewReportBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.viewReportBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReportBtn.Location = new System.Drawing.Point(345, 240);
            this.viewReportBtn.Name = "viewReportBtn";
            this.viewReportBtn.Size = new System.Drawing.Size(220, 39);
            this.viewReportBtn.TabIndex = 9;
            this.viewReportBtn.Text = "VIEW REPORTS";
            this.viewReportBtn.UseVisualStyleBackColor = true;
            this.viewReportBtn.Click += new System.EventHandler(this.viewReportBtn_Click);
            // 
            // updProfileBtn
            // 
            this.updProfileBtn.AutoSize = true;
            this.updProfileBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.updProfileBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updProfileBtn.Location = new System.Drawing.Point(345, 357);
            this.updProfileBtn.Name = "updProfileBtn";
            this.updProfileBtn.Size = new System.Drawing.Size(220, 59);
            this.updProfileBtn.TabIndex = 10;
            this.updProfileBtn.Text = "CHANGE PASSWORD";
            this.updProfileBtn.UseVisualStyleBackColor = true;
            this.updProfileBtn.Click += new System.EventHandler(this.updProfileBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.AutoSize = true;
            this.logoutBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.logoutBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(792, 417);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(121, 41);
            this.logoutBtn.TabIndex = 58;
            this.logoutBtn.Text = "LOGOUT";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationProject.Properties.Resources.blogSpan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 470);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.updProfileBtn);
            this.Controls.Add(this.viewReportBtn);
            this.Controls.Add(this.resrvationRoomBtn);
            this.Controls.Add(this.updRateBtn);
            this.Controls.Add(this.displyRomBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormManager";
            this.Text = "FormManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button displyRomBtn;
        private System.Windows.Forms.Button updRateBtn;
        private System.Windows.Forms.Button resrvationRoomBtn;
        private System.Windows.Forms.Button viewReportBtn;
        private System.Windows.Forms.Button updProfileBtn;
        private System.Windows.Forms.Button logoutBtn;
    }
}