namespace Poliklinika.Forms
{
    partial class Registration
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FIO = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(428, 378);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(94, 40);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // EnterBtn
            // 
            this.EnterBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.EnterBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterBtn.Location = new System.Drawing.Point(145, 287);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(260, 37);
            this.EnterBtn.TabIndex = 1;
            this.EnterBtn.Text = "Внести данные";
            this.EnterBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Location = new System.Drawing.Point(29, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 58);
            this.label4.TabIndex = 6;
            this.label4.Text = "Повторить пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(148, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 33);
            this.label5.TabIndex = 7;
            this.label5.Text = "Введите данные";
            // 
            // FIO
            // 
            this.FIO.Location = new System.Drawing.Point(154, 104);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(301, 34);
            this.FIO.TabIndex = 8;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(154, 145);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(301, 34);
            this.LoginBox.TabIndex = 9;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(154, 186);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(301, 34);
            this.PasswordBox.TabIndex = 10;
            // 
            // PasswordBox1
            // 
            this.PasswordBox1.Location = new System.Drawing.Point(154, 226);
            this.PasswordBox1.Name = "PasswordBox1";
            this.PasswordBox1.PasswordChar = '*';
            this.PasswordBox1.Size = new System.Drawing.Size(301, 34);
            this.PasswordBox1.TabIndex = 11;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(185)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(534, 430);
            this.ControlBox = false;
            this.Controls.Add(this.PasswordBox1);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.exitBtn);
            this.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Registration";
            this.Text = "Регистрация в ИС";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox FIO;
        public System.Windows.Forms.TextBox LoginBox;
        public System.Windows.Forms.TextBox PasswordBox;
        public System.Windows.Forms.TextBox PasswordBox1;
    }
}