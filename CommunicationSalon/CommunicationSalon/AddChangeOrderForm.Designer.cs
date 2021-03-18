
namespace CommunicationSalon
{
    partial class AddChangeOrderForm
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
            this.startDateDTP = new System.Windows.Forms.DateTimePicker();
            this.finishDateDTP = new System.Windows.Forms.DateTimePicker();
            this.priceNUP = new System.Windows.Forms.NumericUpDown();
            this.userCB = new System.Windows.Forms.ComboBox();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.addB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateDTP
            // 
            this.startDateDTP.Location = new System.Drawing.Point(59, 51);
            this.startDateDTP.Name = "startDateDTP";
            this.startDateDTP.Size = new System.Drawing.Size(143, 20);
            this.startDateDTP.TabIndex = 0;
            // 
            // finishDateDTP
            // 
            this.finishDateDTP.Location = new System.Drawing.Point(59, 102);
            this.finishDateDTP.Name = "finishDateDTP";
            this.finishDateDTP.Size = new System.Drawing.Size(143, 20);
            this.finishDateDTP.TabIndex = 1;
            // 
            // priceNUP
            // 
            this.priceNUP.Location = new System.Drawing.Point(59, 155);
            this.priceNUP.Name = "priceNUP";
            this.priceNUP.Size = new System.Drawing.Size(143, 20);
            this.priceNUP.TabIndex = 2;
            // 
            // userCB
            // 
            this.userCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userCB.FormattingEnabled = true;
            this.userCB.Location = new System.Drawing.Point(59, 210);
            this.userCB.Name = "userCB";
            this.userCB.Size = new System.Drawing.Size(143, 21);
            this.userCB.TabIndex = 3;
            // 
            // statusCB
            // 
            this.statusCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Location = new System.Drawing.Point(59, 265);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(143, 21);
            this.statusCB.TabIndex = 4;
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(22, 318);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 5;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(162, 318);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(75, 23);
            this.deleteB.TabIndex = 6;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(22, 318);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(75, 23);
            this.changeB.TabIndex = 7;
            this.changeB.Text = "Изменить";
            this.changeB.UseVisualStyleBackColor = true;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата начала:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата окончания:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Сумма:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Покупатель:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Статус:";
            // 
            // AddChangeOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 359);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.statusCB);
            this.Controls.Add(this.userCB);
            this.Controls.Add(this.priceNUP);
            this.Controls.Add(this.finishDateDTP);
            this.Controls.Add(this.startDateDTP);
            this.Name = "AddChangeOrderForm";
            this.Text = "Заказ";
            ((System.ComponentModel.ISupportInitialize)(this.priceNUP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDateDTP;
        private System.Windows.Forms.DateTimePicker finishDateDTP;
        private System.Windows.Forms.NumericUpDown priceNUP;
        private System.Windows.Forms.ComboBox userCB;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button deleteB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}