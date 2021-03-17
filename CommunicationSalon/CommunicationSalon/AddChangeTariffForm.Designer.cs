
namespace CommunicationSalon
{
    partial class AddChangeTariffForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.descriptionRTB = new System.Windows.Forms.RichTextBox();
            this.priceNUD = new System.Windows.Forms.NumericUpDown();
            this.minutesNUD = new System.Windows.Forms.NumericUpDown();
            this.internetNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.changeB = new System.Windows.Forms.Button();
            this.deleteB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(63, 57);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(145, 20);
            this.nameTB.TabIndex = 0;
            // 
            // descriptionRTB
            // 
            this.descriptionRTB.Location = new System.Drawing.Point(63, 119);
            this.descriptionRTB.Name = "descriptionRTB";
            this.descriptionRTB.Size = new System.Drawing.Size(145, 81);
            this.descriptionRTB.TabIndex = 1;
            this.descriptionRTB.Text = "";
            // 
            // priceNUD
            // 
            this.priceNUD.Location = new System.Drawing.Point(241, 56);
            this.priceNUD.Name = "priceNUD";
            this.priceNUD.Size = new System.Drawing.Size(139, 20);
            this.priceNUD.TabIndex = 2;
            // 
            // minutesNUD
            // 
            this.minutesNUD.Location = new System.Drawing.Point(241, 119);
            this.minutesNUD.Name = "minutesNUD";
            this.minutesNUD.Size = new System.Drawing.Size(139, 20);
            this.minutesNUD.TabIndex = 3;
            // 
            // internetNUD
            // 
            this.internetNUD.Location = new System.Drawing.Point(241, 180);
            this.internetNUD.Name = "internetNUD";
            this.internetNUD.Size = new System.Drawing.Size(139, 20);
            this.internetNUD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Описание:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Цена:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(241, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Минуты:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(241, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Интернет:";
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(133, 231);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 10;
            this.addB.Text = "Добавить";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // changeB
            // 
            this.changeB.Location = new System.Drawing.Point(133, 231);
            this.changeB.Name = "changeB";
            this.changeB.Size = new System.Drawing.Size(75, 23);
            this.changeB.TabIndex = 11;
            this.changeB.Text = "Изменить";
            this.changeB.UseVisualStyleBackColor = true;
            this.changeB.Click += new System.EventHandler(this.changeB_Click);
            // 
            // deleteB
            // 
            this.deleteB.Location = new System.Drawing.Point(244, 231);
            this.deleteB.Name = "deleteB";
            this.deleteB.Size = new System.Drawing.Size(75, 23);
            this.deleteB.TabIndex = 12;
            this.deleteB.Text = "Удалить";
            this.deleteB.UseVisualStyleBackColor = true;
            this.deleteB.Click += new System.EventHandler(this.deleteB_Click);
            // 
            // AddChangeTariffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 293);
            this.Controls.Add(this.deleteB);
            this.Controls.Add(this.changeB);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.internetNUD);
            this.Controls.Add(this.minutesNUD);
            this.Controls.Add(this.priceNUD);
            this.Controls.Add(this.descriptionRTB);
            this.Controls.Add(this.nameTB);
            this.Name = "AddChangeTariffForm";
            this.Text = "Тариф";
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internetNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.RichTextBox descriptionRTB;
        private System.Windows.Forms.NumericUpDown priceNUD;
        private System.Windows.Forms.NumericUpDown minutesNUD;
        private System.Windows.Forms.NumericUpDown internetNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.Button changeB;
        private System.Windows.Forms.Button deleteB;
    }
}