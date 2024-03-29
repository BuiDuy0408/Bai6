﻿namespace UILayer
{
    partial class PosSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PosSystem));
            this.btnCancel = new System.Windows.Forms.Button();
            this.labelClock = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.textBoxProductCode = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxExchange = new System.Windows.Forms.TextBox();
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelReturn = new System.Windows.Forms.Label();
            this.labelCash = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_Now = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tBoxCode = new System.Windows.Forms.TextBox();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnStartOver = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.labelVat = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPrint = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(220, 162);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 41);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // labelClock
            // 
            this.labelClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClock.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.Location = new System.Drawing.Point(1431, 0);
            this.labelClock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(209, 50);
            this.labelClock.TabIndex = 5;
            this.labelClock.Text = "00:00:00 AM";
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(112, 306);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 41);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.AutoSize = true;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(4, 306);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 41);
            this.btnInsert.TabIndex = 1;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.textBoxDiscount, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.textBoxUnitPrice, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.textBoxQuantity, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelCode, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelDescription, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelQuantity, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.labelUnitPrice, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.labelDiscount, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.textBoxProductCode, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 11);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(581, 288);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDiscount.Location = new System.Drawing.Point(294, 232);
            this.textBoxDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(283, 34);
            this.textBoxDiscount.TabIndex = 9;
            this.textBoxDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUnitPrice.Location = new System.Drawing.Point(294, 175);
            this.textBoxUnitPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.ReadOnly = true;
            this.textBoxUnitPrice.Size = new System.Drawing.Size(283, 34);
            this.textBoxUnitPrice.TabIndex = 8;
            this.textBoxUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuantity.Location = new System.Drawing.Point(294, 118);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(283, 34);
            this.textBoxQuantity.TabIndex = 7;
            this.textBoxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(294, 61);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(283, 34);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.Location = new System.Drawing.Point(4, 0);
            this.labelCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(282, 57);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Product Code";
            this.labelCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(4, 57);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(282, 57);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "Description";
            this.labelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantity.Location = new System.Drawing.Point(4, 114);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(282, 57);
            this.labelQuantity.TabIndex = 2;
            this.labelQuantity.Text = "Quantity";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUnitPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnitPrice.Location = new System.Drawing.Point(4, 171);
            this.labelUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(282, 57);
            this.labelUnitPrice.TabIndex = 3;
            this.labelUnitPrice.Text = "Unit Price";
            this.labelUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDiscount.Location = new System.Drawing.Point(4, 228);
            this.labelDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(282, 60);
            this.labelDiscount.TabIndex = 4;
            this.labelDiscount.Text = "Discount";
            this.labelDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxProductCode
            // 
            this.textBoxProductCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProductCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductCode.Location = new System.Drawing.Point(294, 4);
            this.textBoxProductCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxProductCode.Name = "textBoxProductCode";
            this.textBoxProductCode.ReadOnly = true;
            this.textBoxProductCode.Size = new System.Drawing.Size(283, 34);
            this.textBoxProductCode.TabIndex = 5;
            this.textBoxProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.textBoxExchange, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.textBoxCash, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.labelTotal, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.labelReturn, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.labelCash, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.textBoxTotal, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(562, 151);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // textBoxExchange
            // 
            this.textBoxExchange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxExchange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExchange.Location = new System.Drawing.Point(285, 104);
            this.textBoxExchange.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxExchange.Name = "textBoxExchange";
            this.textBoxExchange.Size = new System.Drawing.Size(273, 34);
            this.textBoxExchange.TabIndex = 5;
            this.textBoxExchange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxCash
            // 
            this.textBoxCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCash.Location = new System.Drawing.Point(285, 54);
            this.textBoxCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(273, 34);
            this.textBoxCash.TabIndex = 4;
            this.textBoxCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(4, 0);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(273, 50);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total";
            // 
            // labelReturn
            // 
            this.labelReturn.AutoSize = true;
            this.labelReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReturn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReturn.Location = new System.Drawing.Point(4, 100);
            this.labelReturn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReturn.Name = "labelReturn";
            this.labelReturn.Size = new System.Drawing.Size(273, 51);
            this.labelReturn.TabIndex = 2;
            this.labelReturn.Text = "Exchange";
            // 
            // labelCash
            // 
            this.labelCash.AutoSize = true;
            this.labelCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCash.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCash.Location = new System.Drawing.Point(4, 50);
            this.labelCash.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCash.Name = "labelCash";
            this.labelCash.Size = new System.Drawing.Size(273, 50);
            this.labelCash.TabIndex = 1;
            this.labelCash.Text = "Cash";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(285, 4);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(273, 34);
            this.textBoxTotal.TabIndex = 3;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Code
            // 
            this.Code.Name = "Code";
            // 
            // Description
            // 
            this.Description.Name = "Description";
            // 
            // Quantity
            // 
            this.Quantity.Name = "Quantity";
            // 
            // Unit
            // 
            this.Unit.Name = "Unit";
            // 
            // Discount
            // 
            this.Discount.Name = "Discount";
            // 
            // Price
            // 
            this.Price.Name = "Price";
            // 
            // timer_Now
            // 
            this.timer_Now.Interval = 1000;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1489, 50);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem1});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 46);
            this.toolStripMenuItem1.Text = "File";
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(153, 32);
            this.logoutToolStripMenuItem1.Text = "Logout";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(79, 46);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.panelPrint);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.btnInsert);
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel5);
            this.splitContainer1.Size = new System.Drawing.Size(1489, 847);
            this.splitContainer1.SplitterDistance = 891;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(891, 847);
            this.splitContainer2.SplitterDistance = 582;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(876, 575);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.91057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.08943F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.70968F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(891, 257);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(4, 4);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer3.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer3.Size = new System.Drawing.Size(499, 249);
            this.splitContainer3.SplitterDistance = 122;
            this.splitContainer3.SplitterWidth = 5;
            this.splitContainer3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel4.Controls.Add(this.tBoxCode, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnRemoveFromCart, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnAddToCart, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(488, 65);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tBoxCode
            // 
            this.tBoxCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxCode.Location = new System.Drawing.Point(4, 4);
            this.tBoxCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tBoxCode.MaxLength = 15;
            this.tBoxCode.Name = "tBoxCode";
            this.tBoxCode.Size = new System.Drawing.Size(295, 34);
            this.tBoxCode.TabIndex = 0;
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveFromCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveFromCart.BackgroundImage")));
            this.btnRemoveFromCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveFromCart.FlatAppearance.BorderSize = 0;
            this.btnRemoveFromCart.Location = new System.Drawing.Point(399, 4);
            this.btnRemoveFromCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(85, 57);
            this.btnRemoveFromCart.TabIndex = 2;
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToCart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddToCart.BackgroundImage")));
            this.btnAddToCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(307, 4);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(84, 57);
            this.btnAddToCart.TabIndex = 1;
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnStartOver, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCheckOut, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(489, 112);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnStartOver
            // 
            this.btnStartOver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartOver.BackColor = System.Drawing.Color.White;
            this.btnStartOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartOver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStartOver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnStartOver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnStartOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartOver.Location = new System.Drawing.Point(4, 4);
            this.btnStartOver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStartOver.Name = "btnStartOver";
            this.btnStartOver.Size = new System.Drawing.Size(236, 104);
            this.btnStartOver.TabIndex = 0;
            this.btnStartOver.Text = "STARTOVER";
            this.btnStartOver.UseVisualStyleBackColor = false;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.BackColor = System.Drawing.Color.White;
            this.btnCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCheckOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(248, 4);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(237, 104);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "CHECKOUT";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.92754F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.07246F));
            this.tableLayoutPanel3.Controls.Add(this.labelVat, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.labelSubTotal, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(511, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(376, 70);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // labelVat
            // 
            this.labelVat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVat.AutoSize = true;
            this.labelVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVat.Location = new System.Drawing.Point(172, 35);
            this.labelVat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(200, 35);
            this.labelVat.TabIndex = 4;
            this.labelVat.Text = "15";
            this.labelVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(172, 0);
            this.labelSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(200, 35);
            this.labelSubTotal.TabIndex = 3;
            this.labelSubTotal.Text = "0.00";
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "SubTotal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelPrint
            // 
            this.panelPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrint.Controls.Add(this.btnCalculate);
            this.panelPrint.Controls.Add(this.btnOk);
            this.panelPrint.Controls.Add(this.btnCancel);
            this.panelPrint.Controls.Add(this.tableLayoutPanel6);
            this.panelPrint.Location = new System.Drawing.Point(9, 354);
            this.panelPrint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelPrint.Name = "panelPrint";
            this.panelPrint.Size = new System.Drawing.Size(572, 300);
            this.panelPrint.TabIndex = 3;
            this.panelPrint.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(4, 162);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(120, 41);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = true;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(112, 162);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 41);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // PosSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1489, 847);
            this.Controls.Add(this.labelClock);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PosSystem";
            this.Text = "PosSystem";
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panelPrint.ResumeLayout(false);
            this.panelPrint.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.TextBox textBoxProductCode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox textBoxExchange;
        private System.Windows.Forms.TextBox textBoxCash;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelReturn;
        private System.Windows.Forms.Label labelCash;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Timer timer_Now;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox tBoxCode;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnStartOver;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelPrint;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnOk;
    }
}