namespace Poliklinika.Forms
{
    partial class PacientForm
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
            this.FullName = new System.Windows.Forms.TextBox();
            this.Serial = new System.Windows.Forms.TextBox();
            this.Number = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.SurNameBox = new System.Windows.Forms.TextBox();
            this.BirthdayBox = new System.Windows.Forms.TextBox();
            this.SexBox = new System.Windows.Forms.TextBox();
            this.SeriesBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.AdressBox = new System.Windows.Forms.TextBox();
            this.ChoseBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Серия паспорта";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер паспорта";
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(193, 3);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(527, 34);
            this.FullName.TabIndex = 3;
            // 
            // Serial
            // 
            this.Serial.Location = new System.Drawing.Point(193, 43);
            this.Serial.Name = "Serial";
            this.Serial.Size = new System.Drawing.Size(527, 34);
            this.Serial.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(193, 83);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(527, 34);
            this.Number.TabIndex = 5;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(607, 123);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(113, 34);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Регистрация/редактирование";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фамилия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 518);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "Пол";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "Имя";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 439);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "Отчество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 479);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 27);
            this.label9.TabIndex = 13;
            this.label9.Text = "Дата рождения";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(369, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 27);
            this.label10.TabIndex = 14;
            this.label10.Text = "Серия паспорта";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(369, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 27);
            this.label11.TabIndex = 15;
            this.label11.Text = "Номер паспорта";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(369, 439);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 27);
            this.label12.TabIndex = 16;
            this.label12.Text = "Адрес";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(178, 356);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(185, 34);
            this.LastNameBox.TabIndex = 17;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(178, 396);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(185, 34);
            this.FirstNameBox.TabIndex = 18;
            // 
            // SurNameBox
            // 
            this.SurNameBox.Location = new System.Drawing.Point(178, 436);
            this.SurNameBox.Name = "SurNameBox";
            this.SurNameBox.Size = new System.Drawing.Size(185, 34);
            this.SurNameBox.TabIndex = 18;
            // 
            // BirthdayBox
            // 
            this.BirthdayBox.Location = new System.Drawing.Point(178, 476);
            this.BirthdayBox.Name = "BirthdayBox";
            this.BirthdayBox.Size = new System.Drawing.Size(185, 34);
            this.BirthdayBox.TabIndex = 19;
            // 
            // SexBox
            // 
            this.SexBox.Location = new System.Drawing.Point(178, 515);
            this.SexBox.Name = "SexBox";
            this.SexBox.Size = new System.Drawing.Size(185, 34);
            this.SexBox.TabIndex = 20;
            // 
            // SeriesBox
            // 
            this.SeriesBox.Location = new System.Drawing.Point(535, 356);
            this.SeriesBox.Name = "SeriesBox";
            this.SeriesBox.Size = new System.Drawing.Size(185, 34);
            this.SeriesBox.TabIndex = 21;
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(535, 396);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(185, 34);
            this.NumberBox.TabIndex = 22;
            // 
            // AdressBox
            // 
            this.AdressBox.Location = new System.Drawing.Point(535, 436);
            this.AdressBox.Name = "AdressBox";
            this.AdressBox.Size = new System.Drawing.Size(185, 34);
            this.AdressBox.TabIndex = 23;
            // 
            // ChoseBtn
            // 
            this.ChoseBtn.Location = new System.Drawing.Point(17, 579);
            this.ChoseBtn.Name = "ChoseBtn";
            this.ChoseBtn.Size = new System.Drawing.Size(113, 34);
            this.ChoseBtn.TabIndex = 24;
            this.ChoseBtn.Text = "Выбрать";
            this.ChoseBtn.UseVisualStyleBackColor = true;
            this.ChoseBtn.Click += new System.EventHandler(this.ChoseBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Enabled = false;
            this.EditBtn.Location = new System.Drawing.Point(136, 579);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(172, 34);
            this.EditBtn.TabIndex = 25;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Location = new System.Drawing.Point(314, 579);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(146, 34);
            this.RegistrationBtn.TabIndex = 26;
            this.RegistrationBtn.Text = "Регистрация";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(607, 579);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(113, 34);
            this.ExitBtn.TabIndex = 27;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            // 
            // Pacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(185)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(732, 625);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ChoseBtn);
            this.Controls.Add(this.AdressBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.SeriesBox);
            this.Controls.Add(this.SexBox);
            this.Controls.Add(this.BirthdayBox);
            this.Controls.Add(this.SurNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Serial);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Pacient";
            this.Text = "Пациенты";
            this.Load += new System.EventHandler(this.Pacient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox Serial;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox SurNameBox;
        private System.Windows.Forms.TextBox BirthdayBox;
        private System.Windows.Forms.TextBox SexBox;
        private System.Windows.Forms.TextBox SeriesBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox AdressBox;
        private System.Windows.Forms.Button ChoseBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button RegistrationBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}