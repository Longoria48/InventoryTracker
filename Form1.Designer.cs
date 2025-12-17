using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FINALPROJECT_inventory_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Fields = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbField3 = new System.Windows.Forms.Label();
            this.lbField4 = new System.Windows.Forms.Label();
            this.lbField2 = new System.Windows.Forms.Label();
            this.lbField1 = new System.Windows.Forms.Label();
            this.tbField4 = new System.Windows.Forms.TextBox();
            this.tbField3 = new System.Windows.Forms.TextBox();
            this.tbField2 = new System.Windows.Forms.TextBox();
            this.tbField1 = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.rbStock = new System.Windows.Forms.RadioButton();
            this.rbLocations = new System.Windows.Forms.RadioButton();
            this.rbProducts = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbDelLoc = new System.Windows.Forms.Label();
            this.tbDelLoc = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbDelProd = new System.Windows.Forms.Label();
            this.tbDelProd = new System.Windows.Forms.TextBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.InsertTab = new System.Windows.Forms.TabPage();
            this.UpdateTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.locUpdLbl = new System.Windows.Forms.Label();
            this.prodUpdLbl = new System.Windows.Forms.Label();
            this.locUpdTb = new System.Windows.Forms.TextBox();
            this.prodUpdTb = new System.Windows.Forms.TextBox();
            this.upLbl3 = new System.Windows.Forms.Label();
            this.upLbl4 = new System.Windows.Forms.Label();
            this.upLbl2 = new System.Windows.Forms.Label();
            this.upLbl1 = new System.Windows.Forms.Label();
            this.upTB4 = new System.Windows.Forms.TextBox();
            this.upTB3 = new System.Windows.Forms.TextBox();
            this.upTB2 = new System.Windows.Forms.TextBox();
            this.upTB1 = new System.Windows.Forms.TextBox();
            this.DeleteTab = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Fields.SuspendLayout();
            this.radioGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tabControl.SuspendLayout();
            this.InsertTab.SuspendLayout();
            this.UpdateTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.DeleteTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fields
            // 
            this.Fields.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Fields.Controls.Add(this.btnAdd);
            this.Fields.Controls.Add(this.lbField3);
            this.Fields.Controls.Add(this.lbField4);
            this.Fields.Controls.Add(this.lbField2);
            this.Fields.Controls.Add(this.lbField1);
            this.Fields.Controls.Add(this.tbField4);
            this.Fields.Controls.Add(this.tbField3);
            this.Fields.Controls.Add(this.tbField2);
            this.Fields.Controls.Add(this.tbField1);
            this.Fields.Location = new System.Drawing.Point(0, 4);
            this.Fields.Margin = new System.Windows.Forms.Padding(4);
            this.Fields.Name = "Fields";
            this.Fields.Padding = new System.Windows.Forms.Padding(4);
            this.Fields.Size = new System.Drawing.Size(494, 262);
            this.Fields.TabIndex = 0;
            this.Fields.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(327, 197);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbField3
            // 
            this.lbField3.AutoSize = true;
            this.lbField3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbField3.Location = new System.Drawing.Point(96, 118);
            this.lbField3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbField3.Name = "lbField3";
            this.lbField3.Size = new System.Drawing.Size(45, 19);
            this.lbField3.TabIndex = 8;
            this.lbField3.Text = "label3";
            // 
            // lbField4
            // 
            this.lbField4.AutoSize = true;
            this.lbField4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbField4.Location = new System.Drawing.Point(96, 160);
            this.lbField4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbField4.Name = "lbField4";
            this.lbField4.Size = new System.Drawing.Size(45, 19);
            this.lbField4.TabIndex = 7;
            this.lbField4.Text = "label4";
            // 
            // lbField2
            // 
            this.lbField2.AutoSize = true;
            this.lbField2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbField2.Location = new System.Drawing.Point(96, 75);
            this.lbField2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbField2.Name = "lbField2";
            this.lbField2.Size = new System.Drawing.Size(45, 19);
            this.lbField2.TabIndex = 6;
            this.lbField2.Text = "label2";
            // 
            // lbField1
            // 
            this.lbField1.AutoSize = true;
            this.lbField1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbField1.Location = new System.Drawing.Point(96, 35);
            this.lbField1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbField1.Name = "lbField1";
            this.lbField1.Size = new System.Drawing.Size(45, 19);
            this.lbField1.TabIndex = 5;
            this.lbField1.Text = "label1";
            // 
            // tbField4
            // 
            this.tbField4.Location = new System.Drawing.Point(199, 158);
            this.tbField4.Margin = new System.Windows.Forms.Padding(4);
            this.tbField4.Name = "tbField4";
            this.tbField4.Size = new System.Drawing.Size(199, 22);
            this.tbField4.TabIndex = 3;
            // 
            // tbField3
            // 
            this.tbField3.Location = new System.Drawing.Point(199, 115);
            this.tbField3.Margin = new System.Windows.Forms.Padding(4);
            this.tbField3.Name = "tbField3";
            this.tbField3.Size = new System.Drawing.Size(199, 22);
            this.tbField3.TabIndex = 2;
            // 
            // tbField2
            // 
            this.tbField2.Location = new System.Drawing.Point(199, 72);
            this.tbField2.Margin = new System.Windows.Forms.Padding(4);
            this.tbField2.Name = "tbField2";
            this.tbField2.Size = new System.Drawing.Size(199, 22);
            this.tbField2.TabIndex = 1;
            // 
            // tbField1
            // 
            this.tbField1.Location = new System.Drawing.Point(199, 32);
            this.tbField1.Margin = new System.Windows.Forms.Padding(4);
            this.tbField1.Name = "tbField1";
            this.tbField1.Size = new System.Drawing.Size(199, 22);
            this.tbField1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(377, 197);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 34);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.rbStock);
            this.radioGroup.Controls.Add(this.rbLocations);
            this.radioGroup.Controls.Add(this.rbProducts);
            this.radioGroup.Location = new System.Drawing.Point(142, 105);
            this.radioGroup.Margin = new System.Windows.Forms.Padding(4);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Padding = new System.Windows.Forms.Padding(4);
            this.radioGroup.Size = new System.Drawing.Size(382, 60);
            this.radioGroup.TabIndex = 1;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Table Options";
            // 
            // rbStock
            // 
            this.rbStock.AutoSize = true;
            this.rbStock.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbStock.Location = new System.Drawing.Point(271, 23);
            this.rbStock.Margin = new System.Windows.Forms.Padding(4);
            this.rbStock.Name = "rbStock";
            this.rbStock.Size = new System.Drawing.Size(62, 23);
            this.rbStock.TabIndex = 2;
            this.rbStock.TabStop = true;
            this.rbStock.Text = "Stock";
            this.rbStock.UseVisualStyleBackColor = true;
            this.rbStock.Click += new System.EventHandler(this.rbProducts_CheckedChanged);
            // 
            // rbLocations
            // 
            this.rbLocations.AutoSize = true;
            this.rbLocations.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLocations.Location = new System.Drawing.Point(158, 23);
            this.rbLocations.Margin = new System.Windows.Forms.Padding(4);
            this.rbLocations.Name = "rbLocations";
            this.rbLocations.Size = new System.Drawing.Size(86, 23);
            this.rbLocations.TabIndex = 1;
            this.rbLocations.TabStop = true;
            this.rbLocations.Text = "Locations";
            this.rbLocations.UseVisualStyleBackColor = true;
            this.rbLocations.Click += new System.EventHandler(this.rbProducts_CheckedChanged);
            // 
            // rbProducts
            // 
            this.rbProducts.AutoSize = true;
            this.rbProducts.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProducts.Location = new System.Drawing.Point(37, 23);
            this.rbProducts.Margin = new System.Windows.Forms.Padding(4);
            this.rbProducts.Name = "rbProducts";
            this.rbProducts.Size = new System.Drawing.Size(82, 23);
            this.rbProducts.TabIndex = 0;
            this.rbProducts.TabStop = true;
            this.rbProducts.Text = "Products";
            this.rbProducts.UseVisualStyleBackColor = true;
            this.rbProducts.Click += new System.EventHandler(this.rbProducts_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox1.Controls.Add(this.lbDelLoc);
            this.groupBox1.Controls.Add(this.tbDelLoc);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lbDelProd);
            this.groupBox1.Controls.Add(this.tbDelProd);
            this.groupBox1.Location = new System.Drawing.Point(0, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(494, 238);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // lbDelLoc
            // 
            this.lbDelLoc.AutoSize = true;
            this.lbDelLoc.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelLoc.Location = new System.Drawing.Point(89, 105);
            this.lbDelLoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDelLoc.Name = "lbDelLoc";
            this.lbDelLoc.Size = new System.Drawing.Size(79, 19);
            this.lbDelLoc.TabIndex = 11;
            this.lbDelLoc.Text = "LocationID:";
            // 
            // tbDelLoc
            // 
            this.tbDelLoc.Location = new System.Drawing.Point(238, 101);
            this.tbDelLoc.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelLoc.Name = "tbDelLoc";
            this.tbDelLoc.Size = new System.Drawing.Size(170, 22);
            this.tbDelLoc.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(333, 147);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbDelProd
            // 
            this.lbDelProd.AutoSize = true;
            this.lbDelProd.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDelProd.Location = new System.Drawing.Point(89, 74);
            this.lbDelProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDelProd.Name = "lbDelProd";
            this.lbDelProd.Size = new System.Drawing.Size(75, 19);
            this.lbDelProd.TabIndex = 5;
            this.lbDelProd.Text = "ProductID:";
            // 
            // tbDelProd
            // 
            this.tbDelProd.Location = new System.Drawing.Point(238, 69);
            this.tbDelProd.Margin = new System.Windows.Forms.Padding(4);
            this.tbDelProd.Name = "tbDelProd";
            this.tbDelProd.Size = new System.Drawing.Size(170, 22);
            this.tbDelProd.TabIndex = 0;
            // 
            // dgvResults
            // 
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvResults.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvResults.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(82, 472);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.dgvResults.MultiSelect = false;
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersWidth = 82;
            this.dgvResults.RowTemplate.ReadOnly = true;
            this.dgvResults.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.Size = new System.Drawing.Size(502, 167);
            this.dgvResults.TabIndex = 13;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.InsertTab);
            this.tabControl.Controls.Add(this.UpdateTab);
            this.tabControl.Controls.Add(this.DeleteTab);
            this.tabControl.Location = new System.Drawing.Point(82, 186);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(502, 271);
            this.tabControl.TabIndex = 14;
            // 
            // InsertTab
            // 
            this.InsertTab.Controls.Add(this.Fields);
            this.InsertTab.Location = new System.Drawing.Point(4, 25);
            this.InsertTab.Name = "InsertTab";
            this.InsertTab.Padding = new System.Windows.Forms.Padding(3);
            this.InsertTab.Size = new System.Drawing.Size(494, 242);
            this.InsertTab.TabIndex = 0;
            this.InsertTab.Text = "Insert";
            this.InsertTab.UseVisualStyleBackColor = true;
            // 
            // UpdateTab
            // 
            this.UpdateTab.Controls.Add(this.groupBox2);
            this.UpdateTab.Location = new System.Drawing.Point(4, 25);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.Padding = new System.Windows.Forms.Padding(3);
            this.UpdateTab.Size = new System.Drawing.Size(494, 242);
            this.UpdateTab.TabIndex = 1;
            this.UpdateTab.Text = "Update";
            this.UpdateTab.UseVisualStyleBackColor = true;
            this.UpdateTab.Leave += new System.EventHandler(this.UpdateTab_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Controls.Add(this.searchBtn);
            this.groupBox2.Controls.Add(this.locUpdLbl);
            this.groupBox2.Controls.Add(this.prodUpdLbl);
            this.groupBox2.Controls.Add(this.locUpdTb);
            this.groupBox2.Controls.Add(this.prodUpdTb);
            this.groupBox2.Controls.Add(this.upLbl3);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.upLbl4);
            this.groupBox2.Controls.Add(this.upLbl2);
            this.groupBox2.Controls.Add(this.upLbl1);
            this.groupBox2.Controls.Add(this.upTB4);
            this.groupBox2.Controls.Add(this.upTB3);
            this.groupBox2.Controls.Add(this.upTB2);
            this.groupBox2.Controls.Add(this.upTB1);
            this.groupBox2.Location = new System.Drawing.Point(0, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(494, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(230, 35);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(58, 23);
            this.searchBtn.TabIndex = 16;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // locUpdLbl
            // 
            this.locUpdLbl.AutoSize = true;
            this.locUpdLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locUpdLbl.Location = new System.Drawing.Point(20, 51);
            this.locUpdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locUpdLbl.Name = "locUpdLbl";
            this.locUpdLbl.Size = new System.Drawing.Size(83, 19);
            this.locUpdLbl.TabIndex = 15;
            this.locUpdLbl.Text = "LocationID: ";
            // 
            // prodUpdLbl
            // 
            this.prodUpdLbl.AutoSize = true;
            this.prodUpdLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodUpdLbl.Location = new System.Drawing.Point(20, 26);
            this.prodUpdLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.prodUpdLbl.Name = "prodUpdLbl";
            this.prodUpdLbl.Size = new System.Drawing.Size(75, 19);
            this.prodUpdLbl.TabIndex = 14;
            this.prodUpdLbl.Text = "ProductID:";
            // 
            // locUpdTb
            // 
            this.locUpdTb.Location = new System.Drawing.Point(123, 51);
            this.locUpdTb.Margin = new System.Windows.Forms.Padding(4);
            this.locUpdTb.Name = "locUpdTb";
            this.locUpdTb.Size = new System.Drawing.Size(99, 22);
            this.locUpdTb.TabIndex = 13;
            // 
            // prodUpdTb
            // 
            this.prodUpdTb.Location = new System.Drawing.Point(123, 23);
            this.prodUpdTb.Margin = new System.Windows.Forms.Padding(4);
            this.prodUpdTb.Name = "prodUpdTb";
            this.prodUpdTb.Size = new System.Drawing.Size(99, 22);
            this.prodUpdTb.TabIndex = 12;
            // 
            // upLbl3
            // 
            this.upLbl3.AutoSize = true;
            this.upLbl3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLbl3.Location = new System.Drawing.Point(256, 113);
            this.upLbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upLbl3.Name = "upLbl3";
            this.upLbl3.Size = new System.Drawing.Size(45, 19);
            this.upLbl3.TabIndex = 8;
            this.upLbl3.Text = "label3";
            // 
            // upLbl4
            // 
            this.upLbl4.AutoSize = true;
            this.upLbl4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLbl4.Location = new System.Drawing.Point(256, 155);
            this.upLbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upLbl4.Name = "upLbl4";
            this.upLbl4.Size = new System.Drawing.Size(45, 19);
            this.upLbl4.TabIndex = 7;
            this.upLbl4.Text = "label4";
            // 
            // upLbl2
            // 
            this.upLbl2.AutoSize = true;
            this.upLbl2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLbl2.Location = new System.Drawing.Point(20, 155);
            this.upLbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upLbl2.Name = "upLbl2";
            this.upLbl2.Size = new System.Drawing.Size(45, 19);
            this.upLbl2.TabIndex = 6;
            this.upLbl2.Text = "label2";
            // 
            // upLbl1
            // 
            this.upLbl1.AutoSize = true;
            this.upLbl1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upLbl1.Location = new System.Drawing.Point(20, 116);
            this.upLbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.upLbl1.Name = "upLbl1";
            this.upLbl1.Size = new System.Drawing.Size(45, 19);
            this.upLbl1.TabIndex = 5;
            this.upLbl1.Text = "label1";
            // 
            // upTB4
            // 
            this.upTB4.Location = new System.Drawing.Point(347, 155);
            this.upTB4.Margin = new System.Windows.Forms.Padding(4);
            this.upTB4.Name = "upTB4";
            this.upTB4.Size = new System.Drawing.Size(129, 22);
            this.upTB4.TabIndex = 3;
            // 
            // upTB3
            // 
            this.upTB3.Location = new System.Drawing.Point(347, 113);
            this.upTB3.Margin = new System.Windows.Forms.Padding(4);
            this.upTB3.Name = "upTB3";
            this.upTB3.Size = new System.Drawing.Size(129, 22);
            this.upTB3.TabIndex = 2;
            // 
            // upTB2
            // 
            this.upTB2.Location = new System.Drawing.Point(108, 155);
            this.upTB2.Margin = new System.Windows.Forms.Padding(4);
            this.upTB2.Name = "upTB2";
            this.upTB2.Size = new System.Drawing.Size(129, 22);
            this.upTB2.TabIndex = 1;
            // 
            // upTB1
            // 
            this.upTB1.Location = new System.Drawing.Point(108, 116);
            this.upTB1.Margin = new System.Windows.Forms.Padding(4);
            this.upTB1.Name = "upTB1";
            this.upTB1.Size = new System.Drawing.Size(129, 22);
            this.upTB1.TabIndex = 0;
            // 
            // DeleteTab
            // 
            this.DeleteTab.Controls.Add(this.groupBox1);
            this.DeleteTab.Location = new System.Drawing.Point(4, 25);
            this.DeleteTab.Name = "DeleteTab";
            this.DeleteTab.Padding = new System.Windows.Forms.Padding(3);
            this.DeleteTab.Size = new System.Drawing.Size(494, 242);
            this.DeleteTab.TabIndex = 2;
            this.DeleteTab.Text = "Delete";
            this.DeleteTab.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "CRUD System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(667, 678);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.radioGroup);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Fields.ResumeLayout(false);
            this.Fields.PerformLayout();
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.InsertTab.ResumeLayout(false);
            this.UpdateTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.DeleteTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox Fields;
        private GroupBox radioGroup;
        private RadioButton rbStock;
        private RadioButton rbLocations;
        private RadioButton rbProducts;
        private Label lbField3;
        private Label lbField4;
        private Label lbField2;
        private Label lbField1;
        private TextBox tbField4;
        private TextBox tbField3;
        private TextBox tbField2;
        private TextBox tbField1;
        private Button btnAdd;
        private Button btnUpdate;
        private GroupBox groupBox1;
        private Label lbDelLoc;
        private TextBox tbDelLoc;
        private Button btnDelete;
        private Label lbDelProd;
        private TextBox tbDelProd;
        private DataGridView dgvResults;
        private TabControl tabControl;
        private TabPage InsertTab;
        private TabPage UpdateTab;
        private TabPage DeleteTab;
        private Label label1;
        private GroupBox groupBox2;
        private Label upLbl3;
        private Label upLbl4;
        private Label upLbl2;
        private Label upLbl1;
        private TextBox upTB4;
        private TextBox upTB3;
        private TextBox upTB2;
        private TextBox upTB1;
        private Label locUpdLbl;
        private Label prodUpdLbl;
        private TextBox locUpdTb;
        private TextBox prodUpdTb;
        private Button searchBtn;
    }
}
