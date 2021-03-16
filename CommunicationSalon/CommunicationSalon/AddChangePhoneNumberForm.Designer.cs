
namespace CommunicationSalon
{
    partial class AddChangePhoneNumberForm
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
            this.numberTB = new System.Windows.Forms.TextBox();
            this.numberL = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.deleteB = new System.Windows.Forms.Button();
            this.addB = new System.Windows.Forms.Button();
            this.userCB = new System.Windows.Forms.ComboBox();
            this.balanceNUD = new System.Windows.Forms.NumericUpDown();
            this.changeB = new System.Windows.Forms.Button();
            this.tariffL = new System.Windows.Forms.Label();
            this.userL = new System.Windows.Forms.Label();
            this.BalanceL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.balanceNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // numberTB
            // 
            this.numberTB.Location = new System.Drawing.Point(51, 43);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(165, 20);
            this.numberTB.TabIndex = 0;
            // 
            // numberL
            // 
            this.numberL.AutoSize = true;
            this.numberL.Location = new System.Drawing.Point(51, 27);
            this.numberL.Name = "numberL";
            this.numberL.Size = new System.Drawing.Size(44, 13);
            this.numberL.TabIndex = 1;
            this.numberL.Text = "Номер:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(165, 228);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(75, 23);
            this.deleteB.TabIndex = 3;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(26, 228);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 4;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            // 
            // userCB
            // 
            this.userCB.FormattingEnabled = true;
            this.userCB.Location = new System.Drawing.Point(51, 135);
            this.userCB.Name = "userCB";
            this.userCB.Size = new System.Drawing.Size(165, 21);
            this.userCB.TabIndex = 5;
            // 
            // balanceNUD
            // 
            this.balanceNUD.Location = new System.Drawing.Point(51, 182);
            this.balanceNUD.Name = "balanceNUD";
            this.balanceNUD.Size = new System.Drawing.Size(165, 20);
            this.balanceNUD.TabIndex = 6;
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(26, 228);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(75, 23);
            this.changeB.TabIndex = 7;
            this.changeB.Text = "Изменить";
            this.changeB.UseVisualStyleBackColor = true;
            // 
            // tariffL
            // 
            this.tariffL.AutoSize = true;
            this.tariffL.Location = new System.Drawing.Point(51, 70);
            this.tariffL.Name = "tariffL";
            this.tariffL.Size = new System.Drawing.Size(43, 13);
            this.tariffL.TabIndex = 8;
            this.tariffL.Text = "Тариф:";
            // 
            // userL
            // 
            this.userL.AutoSize = true;
            this.userL.Location = new System.Drawing.Point(51, 117);
            this.userL.Name = "userL";
            this.userL.Size = new System.Drawing.Size(83, 13);
            this.userL.TabIndex = 9;
            this.userL.Text = "Пользователь:";
            // 
            // BalanceL
            // 
            this.BalanceL.AutoSize = true;
            this.BalanceL.Location = new System.Drawing.Point(51, 163);
            this.BalanceL.Name = "BalanceL";
            this.BalanceL.Size = new System.Drawing.Size(47, 13);
            this.BalanceL.TabIndex = 10;
            this.BalanceL.Text = "Баланс:";
            // 
            // AddChangePhoneNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 272);
            this.Controls.Add(this.BalanceL);
            this.Controls.Add(this.userL);
            this.Controls.Add(this.tariffL);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.balanceNUD);
            this.Controls.Add(this.userCB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.numberL);
            this.Controls.Add(this.numberTB);
            this.Name = "AddChangePhoneNumberForm";
            this.Text = "Номер телефона";
            ((System.ComponentModel.ISupportInitialize)(this.balanceNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label numberL;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.ComboBox userCB;
        private System.Windows.Forms.NumericUpDown balanceNUD;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Label tariffL;
        private System.Windows.Forms.Label userL;
        private System.Windows.Forms.Label BalanceL;
    }
}