namespace HotelReservationProject
{
    partial class FormViewReservations
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yearlyBtn = new System.Windows.Forms.Button();
            this.monthlyBtn = new System.Windows.Forms.Button();
            this.weeklyBtn = new System.Windows.Forms.Button();
            this.dailyBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Wheat;
            this.label1.Location = new System.Drawing.Point(-70, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1162, 33);
            this.label1.TabIndex = 46;
            this.label1.Text = "                                                   VIEW RESERVATIONS             " +
    "                                                      ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Wheat;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(448, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 282);
            this.dataGridView1.TabIndex = 47;
            // 
            // yearlyBtn
            // 
            this.yearlyBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.yearlyBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyBtn.Location = new System.Drawing.Point(106, 320);
            this.yearlyBtn.Name = "yearlyBtn";
            this.yearlyBtn.Size = new System.Drawing.Size(100, 39);
            this.yearlyBtn.TabIndex = 45;
            this.yearlyBtn.Text = "YEARLY";
            this.yearlyBtn.UseVisualStyleBackColor = true;
            this.yearlyBtn.Click += new System.EventHandler(this.yearlyBtn_Click);
            // 
            // monthlyBtn
            // 
            this.monthlyBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.monthlyBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyBtn.Location = new System.Drawing.Point(106, 275);
            this.monthlyBtn.Name = "monthlyBtn";
            this.monthlyBtn.Size = new System.Drawing.Size(114, 39);
            this.monthlyBtn.TabIndex = 44;
            this.monthlyBtn.Text = "MONTHLY";
            this.monthlyBtn.UseVisualStyleBackColor = true;
            this.monthlyBtn.Click += new System.EventHandler(this.monthlyBtn_Click);
            // 
            // weeklyBtn
            // 
            this.weeklyBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.weeklyBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyBtn.Location = new System.Drawing.Point(106, 215);
            this.weeklyBtn.Name = "weeklyBtn";
            this.weeklyBtn.Size = new System.Drawing.Size(100, 39);
            this.weeklyBtn.TabIndex = 43;
            this.weeklyBtn.Text = "WEEKLY";
            this.weeklyBtn.UseVisualStyleBackColor = true;
            this.weeklyBtn.Click += new System.EventHandler(this.weeklyBtn_Click);
            // 
            // dailyBtn
            // 
            this.dailyBtn.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.dailyBtn.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyBtn.Location = new System.Drawing.Point(106, 160);
            this.dailyBtn.Name = "dailyBtn";
            this.dailyBtn.Size = new System.Drawing.Size(100, 39);
            this.dailyBtn.TabIndex = 42;
            this.dailyBtn.Text = "DAILY";
            this.dailyBtn.UseVisualStyleBackColor = true;
            this.dailyBtn.Click += new System.EventHandler(this.dailyBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.button1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(752, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 41;
            this.button1.Text = "DONE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::HotelReservationProject.Properties.Resources.Screenshot_6;
            this.button2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 39);
            this.button2.TabIndex = 40;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Wheat;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 31);
            this.label2.TabIndex = 54;
            this.label2.Text = "Press the button to view reservations";
            // 
            // FormViewReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelReservationProject.Properties.Resources.blogSpan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 509);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearlyBtn);
            this.Controls.Add(this.monthlyBtn);
            this.Controls.Add(this.weeklyBtn);
            this.Controls.Add(this.dailyBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Name = "FormViewReservations";
            this.Text = "FormViewReservations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dailyBtn;
        private System.Windows.Forms.Button weeklyBtn;
        private System.Windows.Forms.Button monthlyBtn;
        private System.Windows.Forms.Button yearlyBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
    }
}