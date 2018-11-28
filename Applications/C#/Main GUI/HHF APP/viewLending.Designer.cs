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
            this.lbArticle = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChangeLoanStatus = new System.Windows.Forms.Button();
            this.btnReturnItem = new System.Windows.Forms.Button();
            this.lbLoandedItems = new System.Windows.Forms.ListBox();
            this.btnLendItem = new System.Windows.Forms.Button();
            this.btnAddArticle = new System.Windows.Forms.Button();
            this.btnRemoveArticle = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbArticle
            // 
            this.lbArticle.FormattingEnabled = true;
            this.lbArticle.Location = new System.Drawing.Point(28, 27);
            this.lbArticle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbArticle.Name = "lbArticle";
            this.lbArticle.Size = new System.Drawing.Size(343, 524);
            this.lbArticle.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChangeLoanStatus);
            this.groupBox2.Controls.Add(this.btnReturnItem);
            this.groupBox2.Controls.Add(this.lbLoandedItems);
            this.groupBox2.Location = new System.Drawing.Point(387, 27);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(423, 161);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Loaned Items";
            // 
            // btnChangeLoanStatus
            // 
            this.btnChangeLoanStatus.BackColor = System.Drawing.Color.Gold;
            this.btnChangeLoanStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLoanStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeLoanStatus.ForeColor = System.Drawing.Color.White;
            this.btnChangeLoanStatus.Location = new System.Drawing.Point(316, 20);
            this.btnChangeLoanStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChangeLoanStatus.Name = "btnChangeLoanStatus";
            this.btnChangeLoanStatus.Size = new System.Drawing.Size(102, 67);
            this.btnChangeLoanStatus.TabIndex = 18;
            this.btnChangeLoanStatus.Text = "Change Status";
            this.btnChangeLoanStatus.UseVisualStyleBackColor = false;
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
            // lbLoandedItems
            // 
            this.lbLoandedItems.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoandedItems.FormattingEnabled = true;
            this.lbLoandedItems.ItemHeight = 19;
            this.lbLoandedItems.Location = new System.Drawing.Point(7, 20);
            this.lbLoandedItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbLoandedItems.Name = "lbLoandedItems";
            this.lbLoandedItems.Size = new System.Drawing.Size(305, 118);
            this.lbLoandedItems.TabIndex = 15;
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
            // btnAddArticle
            // 
            this.btnAddArticle.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddArticle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArticle.ForeColor = System.Drawing.Color.White;
            this.btnAddArticle.Location = new System.Drawing.Point(704, 402);
            this.btnAddArticle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddArticle.Name = "btnAddArticle";
            this.btnAddArticle.Size = new System.Drawing.Size(102, 67);
            this.btnAddArticle.TabIndex = 19;
            this.btnAddArticle.Text = "Add Article";
            this.btnAddArticle.UseVisualStyleBackColor = false;
            // 
            // btnRemoveArticle
            // 
            this.btnRemoveArticle.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRemoveArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveArticle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveArticle.ForeColor = System.Drawing.Color.White;
            this.btnRemoveArticle.Location = new System.Drawing.Point(704, 483);
            this.btnRemoveArticle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveArticle.Name = "btnRemoveArticle";
            this.btnRemoveArticle.Size = new System.Drawing.Size(102, 67);
            this.btnRemoveArticle.TabIndex = 20;
            this.btnRemoveArticle.Text = "Remove Article";
            this.btnRemoveArticle.UseVisualStyleBackColor = false;
            // 
            // viewLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.btnRemoveArticle);
            this.Controls.Add(this.btnAddArticle);
            this.Controls.Add(this.btnLendItem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbArticle);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewLending";
            this.Size = new System.Drawing.Size(827, 570);
            this.Load += new System.EventHandler(this.viewLending_Load);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbArticle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChangeLoanStatus;
        private System.Windows.Forms.Button btnReturnItem;
        private System.Windows.Forms.ListBox lbLoandedItems;
        private System.Windows.Forms.Button btnLendItem;
        private System.Windows.Forms.Button btnAddArticle;
        private System.Windows.Forms.Button btnRemoveArticle;
    }
}
