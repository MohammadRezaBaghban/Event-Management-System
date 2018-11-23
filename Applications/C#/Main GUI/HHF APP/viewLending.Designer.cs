namespace HHF_APP
{
    partial class viewLending
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbLoanItems = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangeItemStatus = new System.Windows.Forms.Button();
            this.btnReturnItem = new System.Windows.Forms.Button();
            this.lbLoanedItems = new System.Windows.Forms.ListBox();
            this.btnLendItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLoanItems
            // 
            this.lbLoanItems.FormattingEnabled = true;
            this.lbLoanItems.Location = new System.Drawing.Point(28, 27);
            this.lbLoanItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbLoanItems.Name = "lbLoanItems";
            this.lbLoanItems.Size = new System.Drawing.Size(343, 524);
            this.lbLoanItems.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChangeItemStatus);
            this.groupBox2.Controls.Add(this.btnReturnItem);
            this.groupBox2.Controls.Add(this.lbLoanedItems);
            this.groupBox2.Location = new System.Drawing.Point(387, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(423, 161);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loaned Items";
            // 
            // btnChangeItemStatus
            // 
            this.btnChangeItemStatus.BackColor = System.Drawing.Color.Gold;
            this.btnChangeItemStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeItemStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeItemStatus.ForeColor = System.Drawing.Color.White;
            this.btnChangeItemStatus.Location = new System.Drawing.Point(316, 20);
            this.btnChangeItemStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeItemStatus.Name = "btnChangeItemStatus";
            this.btnChangeItemStatus.Size = new System.Drawing.Size(102, 67);
            this.btnChangeItemStatus.TabIndex = 18;
            this.btnChangeItemStatus.Text = "Change Status";
            this.btnChangeItemStatus.UseVisualStyleBackColor = false;
            // 
            // btnReturnItem
            // 
            this.btnReturnItem.BackColor = System.Drawing.Color.Red;
            this.btnReturnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnItem.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnReturnItem.Location = new System.Drawing.Point(316, 89);
            this.btnReturnItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnItem.Name = "btnReturnItem";
            this.btnReturnItem.Size = new System.Drawing.Size(102, 67);
            this.btnReturnItem.TabIndex = 13;
            this.btnReturnItem.Text = "Return";
            this.btnReturnItem.UseVisualStyleBackColor = false;
            // 
            // lbLoanedItems
            // 
            this.lbLoanedItems.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoanedItems.FormattingEnabled = true;
            this.lbLoanedItems.ItemHeight = 19;
            this.lbLoanedItems.Location = new System.Drawing.Point(7, 20);
            this.lbLoanedItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbLoanedItems.Name = "lbLoanedItems";
            this.lbLoanedItems.Size = new System.Drawing.Size(305, 118);
            this.lbLoanedItems.TabIndex = 15;
            // 
            // btnLendItem
            // 
            this.btnLendItem.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLendItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLendItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLendItem.ForeColor = System.Drawing.Color.White;
            this.btnLendItem.Location = new System.Drawing.Point(387, 206);
            this.btnLendItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLendItem.Name = "btnLendItem";
            this.btnLendItem.Size = new System.Drawing.Size(423, 92);
            this.btnLendItem.TabIndex = 17;
            this.btnLendItem.Text = "Lend";
            this.btnLendItem.UseVisualStyleBackColor = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(704, 402);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(102, 67);
            this.btnAddItem.TabIndex = 19;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(704, 483);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(102, 67);
            this.btnRemoveItem.TabIndex = 20;
            this.btnRemoveItem.Text = "Remove Item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // viewLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnLendItem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbLoanItems);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewLending";
            this.Size = new System.Drawing.Size(827, 570);
            this.Load += new System.EventHandler(this.viewLending_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbLoanItems;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChangeItemStatus;
        private System.Windows.Forms.Button btnReturnItem;
        private System.Windows.Forms.ListBox lbLoanedItems;
        private System.Windows.Forms.Button btnLendItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
    }
}
