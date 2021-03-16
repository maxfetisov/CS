
namespace CommunicationSalon
{
    partial class MainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tableChoiceCB = new System.Windows.Forms.ToolStripComboBox();
            this.BasketB = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.infoDGV)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoDGV
            // 
            this.infoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infoDGV.Location = new System.Drawing.Point(0, 28);
            this.infoDGV.Name = "infoDGV";
            this.infoDGV.Size = new System.Drawing.Size(799, 422);
            this.infoDGV.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableChoiceCB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tableChoiceCB
            // 
            this.tableChoiceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableChoiceCB.Items.AddRange(new object[] {
            "Brand",
            "Consumer",
            "Gender",
            "Order",
            "OrderStatus",
            "PhoneNumber",
            "Product",
            "ProductInOrder",
            "RoleConsumer",
            "Tariff",
            "TypeProduct",
            "User"});
            this.tableChoiceCB.Name = "tableChoiceCB";
            this.tableChoiceCB.Size = new System.Drawing.Size(121, 25);
            this.tableChoiceCB.SelectedIndexChanged += new System.EventHandler(this.tableChoiceCB_SelectedIndexChanged);
            // 
            // BasketB
            // 
            this.BasketB.Location = new System.Drawing.Point(733, 2);
            this.BasketB.Name = "BasketB";
            this.BasketB.Size = new System.Drawing.Size(66, 23);
            this.BasketB.TabIndex = 2;
            this.BasketB.Text = "Корзина";
            this.BasketB.UseVisualStyleBackColor = true;
            // 
            // fill
            // 
            this.fill.Location = new System.Drawing.Point(299, 1);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(75, 23);
            this.fill.TabIndex = 3;
            this.fill.Text = "Заполнить";
            this.fill.UseVisualStyleBackColor = true;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fill);
            this.Controls.Add(this.BasketB);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.infoDGV);
            this.Name = "MainForm";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.infoDGV)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView infoDGV;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox tableChoiceCB;
        private System.Windows.Forms.Button BasketB;
        private System.Windows.Forms.Button fill;
    }
}