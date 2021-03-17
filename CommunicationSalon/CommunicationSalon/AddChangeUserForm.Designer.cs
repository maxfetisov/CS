
namespace CommunicationSalon
{
    partial class AddChangeUserForm
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
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.genderCB = new System.Windows.Forms.ComboBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(108, 49);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(146, 20);
            this.lastNameTB.TabIndex = 0;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(108, 98);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(146, 20);
            this.firstNameTB.TabIndex = 1;
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(108, 150);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(146, 20);
            this.middleNameTB.TabIndex = 2;
            // 
            // genderCB
            // 
            this.genderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderCB.FormattingEnabled = true;
            this.genderCB.Location = new System.Drawing.Point(108, 199);
            this.genderCB.Name = "genderCB";
            this.genderCB.Size = new System.Drawing.Size(146, 21);
            this.genderCB.TabIndex = 4;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(108, 255);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(146, 20);
            this.emailTB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Фамилия:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пол:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Email:";
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(88, 304);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 12;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(88, 304);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(75, 23);
            this.changeB.TabIndex = 13;
            this.changeB.Text = "Изменить";
            this.changeB.UseVisualStyleBackColor = true;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(201, 304);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(75, 23);
            this.deleteB.TabIndex = 14;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // AddChangeUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 350);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.genderCB);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Name = "AddChangeUserForm";
            this.Text = "Покупатель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.ComboBox genderCB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Button deleteB;
    }
}