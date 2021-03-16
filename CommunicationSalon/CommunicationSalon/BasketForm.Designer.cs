
namespace CommunicationSalon
{
    partial class BasketForm
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
            this.infoDGV = new System.Windows.Forms.DataGridView();
            this.backToMainB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // infoDGV
            // 
            this.infoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDGV.Location = new System.Drawing.Point(2, 26);
            this.infoDGV.Name = "infoDGV";
            this.infoDGV.Size = new System.Drawing.Size(799, 425);
            this.infoDGV.TabIndex = 0;
            // 
            // backToMainB
            // 
            this.backToMainB.Location = new System.Drawing.Point(1, 1);
            this.backToMainB.Name = "backToMainB";
            this.backToMainB.Size = new System.Drawing.Size(75, 23);
            this.backToMainB.TabIndex = 1;
            this.backToMainB.Text = "На Главную";
            this.backToMainB.UseVisualStyleBackColor = true;
            // 
            // BasketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToMainB);
            this.Controls.Add(this.infoDGV);
            this.Name = "BasketForm";
            this.Text = "Корзина";
            ((System.ComponentModel.ISupportInitialize)(this.infoDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView infoDGV;
        private System.Windows.Forms.Button backToMainB;
    }
}