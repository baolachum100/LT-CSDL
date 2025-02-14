﻿
namespace Lab6_Basic_Command
{
    partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.btnLoad = new System.Windows.Forms.Button();
			this.lvCategory = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmViewFood = new System.Windows.Forms.ToolStripMenuItem();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.btnBill = new System.Windows.Forms.Button();
			this.btnAccount = new System.Windows.Forms.Button();
			this.btnTable = new System.Windows.Forms.Button();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(12, 101);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(114, 40);
			this.btnLoad.TabIndex = 4;
			this.btnLoad.Text = "Lấy danh sách";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// lvCategory
			// 
			this.lvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.lvCategory.ContextMenuStrip = this.contextMenuStrip1;
			this.lvCategory.FullRowSelect = true;
			this.lvCategory.HideSelection = false;
			this.lvCategory.Location = new System.Drawing.Point(12, 147);
			this.lvCategory.MultiSelect = false;
			this.lvCategory.Name = "lvCategory";
			this.lvCategory.Size = new System.Drawing.Size(776, 367);
			this.lvCategory.TabIndex = 8;
			this.lvCategory.UseCompatibleStateImageBehavior = false;
			this.lvCategory.View = System.Windows.Forms.View.Details;
			this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Mã loại";
			this.columnHeader1.Width = 285;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Tên loại món ăn";
			this.columnHeader2.Width = 230;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Loại";
			this.columnHeader3.Width = 234;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(233, 52);
			// 
			// tsmDelete
			// 
			this.tsmDelete.Name = "tsmDelete";
			this.tsmDelete.Size = new System.Drawing.Size(232, 24);
			this.tsmDelete.Text = "Xoá";
			this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
			// 
			// tsmViewFood
			// 
			this.tsmViewFood.Name = "tsmViewFood";
			this.tsmViewFood.Size = new System.Drawing.Size(232, 24);
			this.tsmViewFood.Text = "Xem danh sách món ăn";
			this.tsmViewFood.Click += new System.EventHandler(this.tsmViewFood_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(674, 101);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(114, 40);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "Xoá";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(554, 101);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(114, 40);
			this.btnUpdate.TabIndex = 6;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(434, 101);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(114, 40);
			this.btnAdd.TabIndex = 5;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã nhóm:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 18);
			this.label2.TabIndex = 0;
			this.label2.Text = "Loại:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 37);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(149, 18);
			this.label3.TabIndex = 0;
			this.label3.Text = "Tên nhóm món ăn:";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(201, 9);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(301, 22);
			this.txtID.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(201, 37);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(301, 22);
			this.txtName.TabIndex = 2;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(201, 65);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(301, 22);
			this.txtType.TabIndex = 3;
			// 
			// btnBill
			// 
			this.btnBill.Location = new System.Drawing.Point(314, 101);
			this.btnBill.Name = "btnBill";
			this.btnBill.Size = new System.Drawing.Size(114, 40);
			this.btnBill.TabIndex = 5;
			this.btnBill.Text = "Xem Bill";
			this.btnBill.UseVisualStyleBackColor = true;
			this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
			// 
			// btnAccount
			// 
			this.btnAccount.Location = new System.Drawing.Point(674, 56);
			this.btnAccount.Name = "btnAccount";
			this.btnAccount.Size = new System.Drawing.Size(114, 40);
			this.btnAccount.TabIndex = 7;
			this.btnAccount.Text = "Account";
			this.btnAccount.UseVisualStyleBackColor = true;
			this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
			// 
			// btnTable
			// 
			this.btnTable.Location = new System.Drawing.Point(674, 10);
			this.btnTable.Name = "btnTable";
			this.btnTable.Size = new System.Drawing.Size(114, 40);
			this.btnTable.TabIndex = 7;
			this.btnTable.Text = "Xem bàn";
			this.btnTable.UseVisualStyleBackColor = true;
			this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 526);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lvCategory);
			this.Controls.Add(this.btnBill);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnTable);
			this.Controls.Add(this.btnAccount);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnLoad);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmDelete;
		private System.Windows.Forms.ToolStripMenuItem tsmViewFood;
		private System.Windows.Forms.Button btnBill;
		private System.Windows.Forms.Button btnAccount;
		private System.Windows.Forms.Button btnTable;
	}
}

