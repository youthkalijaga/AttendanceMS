namespace AttendanceV1
{
    partial class Form1
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
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelCurrentTimeTitle = new System.Windows.Forms.Label();
            this.labelCurrentDateTitle = new System.Windows.Forms.Label();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.timerAtNow = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.showButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.Location = new System.Drawing.Point(118, 61);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(482, 43);
            this.labelCurrentTime.TabIndex = 0;
            this.labelCurrentTime.Text = "00:00:00";
            // 
            // labelCurrentTimeTitle
            // 
            this.labelCurrentTimeTitle.AutoSize = true;
            this.labelCurrentTimeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTimeTitle.Location = new System.Drawing.Point(20, 61);
            this.labelCurrentTimeTitle.Name = "labelCurrentTimeTitle";
            this.labelCurrentTimeTitle.Size = new System.Drawing.Size(69, 29);
            this.labelCurrentTimeTitle.TabIndex = 1;
            this.labelCurrentTimeTitle.Text = "Time";
            // 
            // labelCurrentDateTitle
            // 
            this.labelCurrentDateTitle.AutoSize = true;
            this.labelCurrentDateTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDateTitle.Location = new System.Drawing.Point(20, 20);
            this.labelCurrentDateTitle.Name = "labelCurrentDateTitle";
            this.labelCurrentDateTitle.Size = new System.Drawing.Size(63, 29);
            this.labelCurrentDateTitle.TabIndex = 2;
            this.labelCurrentDateTitle.Text = "Date";
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentDate.Location = new System.Drawing.Point(118, 20);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(482, 43);
            this.labelCurrentDate.TabIndex = 3;
            this.labelCurrentDate.Text = "Monday, January 1 2024";
            // 
            // timerAtNow
            // 
            this.timerAtNow.Enabled = true;
            this.timerAtNow.Tick += new System.EventHandler(this.timerAtNow_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mata Kuliah saat ini";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(491, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Basis Data Terdistribusi";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(867, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Hadir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jadwal Pembelajaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "12:30";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(622, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "14:15";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(867, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Izin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // showButton
            // 
            this.showButton.AutoSize = true;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showButton.Location = new System.Drawing.Point(1045, 218);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(177, 43);
            this.showButton.TabIndex = 11;
            this.showButton.Text = "Pilih file";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 377);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.46789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.53211F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1348, 436);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(582, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 839);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.labelCurrentDateTitle);
            this.Controls.Add(this.labelCurrentTimeTitle);
            this.Controls.Add(this.labelCurrentTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelCurrentTimeTitle;
        private System.Windows.Forms.Label labelCurrentDateTitle;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Timer timerAtNow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
    }
}

