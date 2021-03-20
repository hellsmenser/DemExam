namespace Poliklinika
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LogText = new System.Windows.Forms.TextBox();
            this.PasText = new System.Windows.Forms.TextBox();
            this.RegistrationBtn = new System.Windows.Forms.Button();
            this.EntrBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Войти в систему";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль";
            // 
            // LogText
            // 
            this.LogText.Location = new System.Drawing.Point(123, 132);
            this.LogText.Name = "LogText";
            this.LogText.Size = new System.Drawing.Size(220, 34);
            this.LogText.TabIndex = 6;
            // 
            // PasText
            // 
            this.PasText.Location = new System.Drawing.Point(123, 172);
            this.PasText.Name = "PasText";
            this.PasText.PasswordChar = '*';
            this.PasText.Size = new System.Drawing.Size(220, 34);
            this.PasText.TabIndex = 7;
            // 
            // RegistrationBtn
            // 
            this.RegistrationBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegistrationBtn.Location = new System.Drawing.Point(110, 289);
            this.RegistrationBtn.Name = "RegistrationBtn";
            this.RegistrationBtn.Size = new System.Drawing.Size(200, 38);
            this.RegistrationBtn.TabIndex = 8;
            this.RegistrationBtn.Text = "Регистрация";
            this.RegistrationBtn.UseVisualStyleBackColor = true;
            this.RegistrationBtn.Click += new System.EventHandler(this.RegistrationBtn_Click);
            // 
            // EntrBtn
            // 
            this.EntrBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EntrBtn.Location = new System.Drawing.Point(110, 245);
            this.EntrBtn.Name = "EntrBtn";
            this.EntrBtn.Size = new System.Drawing.Size(200, 38);
            this.EntrBtn.TabIndex = 9;
            this.EntrBtn.Text = "Вход";
            this.EntrBtn.UseVisualStyleBackColor = true;
            this.EntrBtn.Click += new System.EventHandler(this.EntrBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitBtn.Location = new System.Drawing.Point(285, 373);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(107, 36);
            this.ExitBtn.TabIndex = 10;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(185)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(404, 421);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.EntrBtn);
            this.Controls.Add(this.RegistrationBtn);
            this.Controls.Add(this.PasText);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Авторизация пользователя ИС";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LogText;
        private System.Windows.Forms.TextBox PasText;
        private System.Windows.Forms.Button RegistrationBtn;
        private System.Windows.Forms.Button EntrBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

