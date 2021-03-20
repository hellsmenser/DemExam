namespace Poliklinika.Forms
{
    partial class MenuForm
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
            this.NewPacient = new System.Windows.Forms.Button();
            this.NewAppointment = new System.Windows.Forms.Button();
            this.ViewAppointment = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(145, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Меню";
            // 
            // NewPacient
            // 
            this.NewPacient.Location = new System.Drawing.Point(64, 126);
            this.NewPacient.Name = "NewPacient";
            this.NewPacient.Size = new System.Drawing.Size(262, 68);
            this.NewPacient.TabIndex = 1;
            this.NewPacient.Text = "Регистрация нового пациента";
            this.NewPacient.UseVisualStyleBackColor = true;
            this.NewPacient.Click += new System.EventHandler(this.NewPacient_Click);
            // 
            // NewAppointment
            // 
            this.NewAppointment.Location = new System.Drawing.Point(64, 200);
            this.NewAppointment.Name = "NewAppointment";
            this.NewAppointment.Size = new System.Drawing.Size(262, 37);
            this.NewAppointment.TabIndex = 2;
            this.NewAppointment.Text = "Запись на прием";
            this.NewAppointment.UseVisualStyleBackColor = true;
            this.NewAppointment.Click += new System.EventHandler(this.NewAppointment_Click);
            // 
            // ViewAppointment
            // 
            this.ViewAppointment.Location = new System.Drawing.Point(64, 243);
            this.ViewAppointment.Name = "ViewAppointment";
            this.ViewAppointment.Size = new System.Drawing.Size(262, 32);
            this.ViewAppointment.TabIndex = 3;
            this.ViewAppointment.Text = "Просмотреть записи";
            this.ViewAppointment.UseVisualStyleBackColor = true;
            this.ViewAppointment.Click += new System.EventHandler(this.ViewAppointment_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(280, 309);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(97, 33);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Выйти";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(185)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(389, 354);
            this.ControlBox = false;
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ViewAppointment);
            this.Controls.Add(this.NewAppointment);
            this.Controls.Add(this.NewPacient);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuForm";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NewPacient;
        private System.Windows.Forms.Button NewAppointment;
        private System.Windows.Forms.Button ViewAppointment;
        private System.Windows.Forms.Button ExitBtn;
    }
}