namespace HomeWorkSQL
{
    partial class MemberManagement
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
            this.RegisterADD = new System.Windows.Forms.Button();
            this.Searchword = new System.Windows.Forms.TextBox();
            this.SearchList = new System.Windows.Forms.Button();
            this.RegisterDelete = new System.Windows.Forms.Button();
            this.RegisterUpdate = new System.Windows.Forms.Button();
            this.RegisterInfoGrid = new System.Windows.Forms.DataGridView();
            this.Editer = new System.Windows.Forms.GroupBox();
            this.SearchNLoad = new System.Windows.Forms.GroupBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterInfoGrid)).BeginInit();
            this.Editer.SuspendLayout();
            this.SearchNLoad.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterADD
            // 
            this.RegisterADD.Location = new System.Drawing.Point(27, 18);
            this.RegisterADD.Name = "RegisterADD";
            this.RegisterADD.Size = new System.Drawing.Size(98, 28);
            this.RegisterADD.TabIndex = 0;
            this.RegisterADD.Text = "Add";
            this.RegisterADD.UseVisualStyleBackColor = true;
            this.RegisterADD.Click += new System.EventHandler(this.RegisterADD_Click);
            // 
            // Searchword
            // 
            this.Searchword.Location = new System.Drawing.Point(116, 38);
            this.Searchword.Name = "Searchword";
            this.Searchword.Size = new System.Drawing.Size(369, 21);
            this.Searchword.TabIndex = 3;
            // 
            // SearchList
            // 
            this.SearchList.Location = new System.Drawing.Point(491, 33);
            this.SearchList.Name = "SearchList";
            this.SearchList.Size = new System.Drawing.Size(98, 28);
            this.SearchList.TabIndex = 4;
            this.SearchList.Text = "Search";
            this.SearchList.UseVisualStyleBackColor = true;
            this.SearchList.Click += new System.EventHandler(this.SearchList_Click);
            // 
            // RegisterDelete
            // 
            this.RegisterDelete.Location = new System.Drawing.Point(131, 18);
            this.RegisterDelete.Name = "RegisterDelete";
            this.RegisterDelete.Size = new System.Drawing.Size(96, 28);
            this.RegisterDelete.TabIndex = 5;
            this.RegisterDelete.Text = "Delete";
            this.RegisterDelete.UseVisualStyleBackColor = true;
            this.RegisterDelete.Click += new System.EventHandler(this.RegisterDelete_Click);
            // 
            // RegisterUpdate
            // 
            this.RegisterUpdate.Location = new System.Drawing.Point(233, 18);
            this.RegisterUpdate.Name = "RegisterUpdate";
            this.RegisterUpdate.Size = new System.Drawing.Size(98, 28);
            this.RegisterUpdate.TabIndex = 7;
            this.RegisterUpdate.Text = "Edit";
            this.RegisterUpdate.UseVisualStyleBackColor = true;
            this.RegisterUpdate.Click += new System.EventHandler(this.RegisterUpdate_Click);
            // 
            // RegisterInfoGrid
            // 
            this.RegisterInfoGrid.AllowUserToAddRows = false;
            this.RegisterInfoGrid.AllowUserToDeleteRows = false;
            this.RegisterInfoGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RegisterInfoGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.RegisterInfoGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegisterInfoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegisterInfoGrid.Location = new System.Drawing.Point(3, 87);
            this.RegisterInfoGrid.Name = "RegisterInfoGrid";
            this.RegisterInfoGrid.RowHeadersVisible = false;
            this.RegisterInfoGrid.RowTemplate.Height = 23;
            this.RegisterInfoGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RegisterInfoGrid.Size = new System.Drawing.Size(598, 417);
            this.RegisterInfoGrid.TabIndex = 8;
            // 
            // Editer
            // 
            this.Editer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Editer.Controls.Add(this.RegisterADD);
            this.Editer.Controls.Add(this.RegisterDelete);
            this.Editer.Controls.Add(this.RegisterUpdate);
            this.Editer.Location = new System.Drawing.Point(263, 510);
            this.Editer.Name = "Editer";
            this.Editer.Size = new System.Drawing.Size(338, 52);
            this.Editer.TabIndex = 9;
            this.Editer.TabStop = false;
            this.Editer.Text = "Editor";
            // 
            // SearchNLoad
            // 
            this.SearchNLoad.Controls.Add(this.CategoryLabel);
            this.SearchNLoad.Controls.Add(this.Category);
            this.SearchNLoad.Controls.Add(this.Searchword);
            this.SearchNLoad.Controls.Add(this.SearchList);
            this.SearchNLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchNLoad.Location = new System.Drawing.Point(3, 3);
            this.SearchNLoad.Name = "SearchNLoad";
            this.SearchNLoad.Size = new System.Drawing.Size(598, 78);
            this.SearchNLoad.TabIndex = 10;
            this.SearchNLoad.TabStop = false;
            this.SearchNLoad.Text = "SearchOption";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(16, 23);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(56, 12);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category";
            // 
            // Category
            // 
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "AllData",
            "Birthday",
            "ID",
            "Job",
            "Name"});
            this.Category.Location = new System.Drawing.Point(18, 38);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(92, 20);
            this.Category.TabIndex = 5;
            this.Category.Text = "AllData";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.RegisterInfoGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Editer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.SearchNLoad, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 565);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // MemberManagement
            // 
            this.ClientSize = new System.Drawing.Size(604, 565);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MemberManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementForm";
            this.Load += new System.EventHandler(this.MemberManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RegisterInfoGrid)).EndInit();
            this.Editer.ResumeLayout(false);
            this.SearchNLoad.ResumeLayout(false);
            this.SearchNLoad.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RegisterADD;
        private System.Windows.Forms.TextBox Searchword;
        private System.Windows.Forms.Button SearchList;
        private System.Windows.Forms.Button RegisterDelete;
        private System.Windows.Forms.Button RegisterUpdate;
        private System.Windows.Forms.DataGridView RegisterInfoGrid;
        private System.Windows.Forms.GroupBox Editer;
        private System.Windows.Forms.GroupBox SearchNLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.Label CategoryLabel;
    }
}