
namespace CommunicationSalon
{
    partial class Authorization
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
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.loginL = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.EnterB = new System.Windows.Forms.Button();
            this.windowsAuthB = new System.Windows.Forms.Button();
            this.startDataB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.modeCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(33, 47);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(159, 20);
            this.loginTB.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(33, 89);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(159, 20);
            this.passwordTB.TabIndex = 1;
            // 
            // loginL
            // 
            this.loginL.AutoSize = true;
            this.loginL.Location = new System.Drawing.Point(30, 31);
            this.loginL.Name = "loginL";
            this.loginL.Size = new System.Drawing.Size(41, 13);
            this.loginL.TabIndex = 2;
            this.loginL.Text = "Логин:";
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(30, 73);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(48, 13);
            this.passwordL.TabIndex = 3;
            this.passwordL.Text = "Пароль:";
            // 
            // EnterB
            // 
            this.EnterB.Location = new System.Drawing.Point(219, 124);
            this.EnterB.Name = "EnterB";
            this.EnterB.Size = new System.Drawing.Size(105, 34);
            this.EnterB.TabIndex = 4;
            this.EnterB.Text = "Войти";
            this.EnterB.UseVisualStyleBackColor = true;
            this.EnterB.Click += new System.EventHandler(this.EnterB_Click);
            // 
            // windowsAuthB
            // 
            this.windowsAuthB.Location = new System.Drawing.Point(219, 31);
            this.windowsAuthB.Name = "windowsAuthB";
            this.windowsAuthB.Size = new System.Drawing.Size(105, 36);
            this.windowsAuthB.TabIndex = 5;
            this.windowsAuthB.Text = "Windows авторизация";
            this.windowsAuthB.UseVisualStyleBackColor = true;
            this.windowsAuthB.Click += new System.EventHandler(this.windowsAuthB_Click);
            // 
            // startDataB
            // 
            this.startDataB.Location = new System.Drawing.Point(219, 73);
            this.startDataB.Name = "startDataB";
            this.startDataB.Size = new System.Drawing.Size(105, 47);
            this.startDataB.TabIndex = 6;
            this.startDataB.Text = "Добавление начальных данных";
            this.startDataB.UseVisualStyleBackColor = true;
            this.startDataB.Click += new System.EventHandler(this.startDataB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Режим:";
            // 
            // modeCB
            // 
            this.modeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeCB.FormattingEnabled = true;
            this.modeCB.Items.AddRange(new object[] {
            "Клиент",
            "Редактирование"});
            this.modeCB.Location = new System.Drawing.Point(33, 133);
            this.modeCB.Name = "modeCB";
            this.modeCB.Size = new System.Drawing.Size(159, 21);
            this.modeCB.TabIndex = 8;
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 172);
            this.Controls.Add(this.modeCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startDataB);
            this.Controls.Add(this.windowsAuthB);
            this.Controls.Add(this.EnterB);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.loginL);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label loginL;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Button EnterB;
        private System.Windows.Forms.Button windowsAuthB;
        private System.Windows.Forms.Button startDataB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox modeCB;
    }
}

