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
            Fields = new GroupBox();
            btnUpdate = new Button();
            btnAdd = new Button();
            lbField3 = new Label();
            lbField4 = new Label();
            lbField2 = new Label();
            lbField1 = new Label();
            tbField4 = new TextBox();
            tbField3 = new TextBox();
            tbField2 = new TextBox();
            tbField1 = new TextBox();
            radioGroup = new GroupBox();
            rbStock = new RadioButton();
            rbLocations = new RadioButton();
            rbProducts = new RadioButton();
            groupBox1 = new GroupBox();
            lbDelLoc = new Label();
            tbDelLoc = new TextBox();
            btnDelete = new Button();
            lbDelProd = new Label();
            tbDelProd = new TextBox();
            dgvResults = new DataGridView();
            Fields.SuspendLayout();
            radioGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).BeginInit();
            SuspendLayout();
            // 
            // Fields
            // 
            Fields.Controls.Add(btnUpdate);
            Fields.Controls.Add(btnAdd);
            Fields.Controls.Add(lbField3);
            Fields.Controls.Add(lbField4);
            Fields.Controls.Add(lbField2);
            Fields.Controls.Add(lbField1);
            Fields.Controls.Add(tbField4);
            Fields.Controls.Add(tbField3);
            Fields.Controls.Add(tbField2);
            Fields.Controls.Add(tbField1);
            Fields.Location = new Point(34, 100);
            Fields.Name = "Fields";
            Fields.Size = new Size(382, 215);
            Fields.TabIndex = 0;
            Fields.TabStop = false;
            Fields.Text = "Insert";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(250, 162);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(60, 162);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbField3
            // 
            lbField3.AutoSize = true;
            lbField3.Location = new Point(20, 83);
            lbField3.Name = "lbField3";
            lbField3.Size = new Size(38, 15);
            lbField3.TabIndex = 8;
            lbField3.Text = "label3";
            // 
            // lbField4
            // 
            lbField4.AutoSize = true;
            lbField4.Location = new Point(20, 112);
            lbField4.Name = "lbField4";
            lbField4.Size = new Size(38, 15);
            lbField4.TabIndex = 7;
            lbField4.Text = "label4";
            // 
            // lbField2
            // 
            lbField2.AutoSize = true;
            lbField2.Location = new Point(20, 54);
            lbField2.Name = "lbField2";
            lbField2.Size = new Size(38, 15);
            lbField2.TabIndex = 6;
            lbField2.Text = "label2";
            // 
            // lbField1
            // 
            lbField1.AutoSize = true;
            lbField1.Location = new Point(20, 25);
            lbField1.Name = "lbField1";
            lbField1.Size = new Size(38, 15);
            lbField1.TabIndex = 5;
            lbField1.Text = "label1";
            // 
            // tbField4
            // 
            tbField4.Location = new Point(157, 109);
            tbField4.Name = "tbField4";
            tbField4.Size = new Size(199, 23);
            tbField4.TabIndex = 3;
            // 
            // tbField3
            // 
            tbField3.Location = new Point(157, 80);
            tbField3.Name = "tbField3";
            tbField3.Size = new Size(199, 23);
            tbField3.TabIndex = 2;
            // 
            // tbField2
            // 
            tbField2.Location = new Point(157, 51);
            tbField2.Name = "tbField2";
            tbField2.Size = new Size(199, 23);
            tbField2.TabIndex = 1;
            // 
            // tbField1
            // 
            tbField1.Location = new Point(157, 22);
            tbField1.Name = "tbField1";
            tbField1.Size = new Size(199, 23);
            tbField1.TabIndex = 0;
            // 
            // radioGroup
            // 
            radioGroup.Controls.Add(rbStock);
            radioGroup.Controls.Add(rbLocations);
            radioGroup.Controls.Add(rbProducts);
            radioGroup.Location = new Point(34, 33);
            radioGroup.Name = "radioGroup";
            radioGroup.Size = new Size(382, 57);
            radioGroup.TabIndex = 1;
            radioGroup.TabStop = false;
            radioGroup.Text = "Table Options";
            // 
            // rbStock
            // 
            rbStock.AutoSize = true;
            rbStock.Location = new Point(271, 22);
            rbStock.Name = "rbStock";
            rbStock.Size = new Size(54, 19);
            rbStock.TabIndex = 2;
            rbStock.TabStop = true;
            rbStock.Text = "Stock";
            rbStock.UseVisualStyleBackColor = true;
            rbStock.CheckedChanged += rbProducts_CheckedChanged;
            // 
            // rbLocations
            // 
            rbLocations.AutoSize = true;
            rbLocations.Location = new Point(157, 22);
            rbLocations.Name = "rbLocations";
            rbLocations.Size = new Size(76, 19);
            rbLocations.TabIndex = 1;
            rbLocations.TabStop = true;
            rbLocations.Text = "Locations";
            rbLocations.UseVisualStyleBackColor = true;
            rbLocations.CheckedChanged += rbProducts_CheckedChanged;
            // 
            // rbProducts
            // 
            rbProducts.AutoSize = true;
            rbProducts.Location = new Point(37, 22);
            rbProducts.Name = "rbProducts";
            rbProducts.Size = new Size(72, 19);
            rbProducts.TabIndex = 0;
            rbProducts.TabStop = true;
            rbProducts.Text = "Products";
            rbProducts.UseVisualStyleBackColor = true;
            rbProducts.CheckedChanged += rbProducts_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbDelLoc);
            groupBox1.Controls.Add(tbDelLoc);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(lbDelProd);
            groupBox1.Controls.Add(tbDelProd);
            groupBox1.Location = new Point(34, 321);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(382, 117);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insert";
            // 
            // lbDelLoc
            // 
            lbDelLoc.AutoSize = true;
            lbDelLoc.Location = new Point(37, 60);
            lbDelLoc.Name = "lbDelLoc";
            lbDelLoc.Size = new Size(67, 15);
            lbDelLoc.TabIndex = 11;
            lbDelLoc.Text = "LocationID:";
            // 
            // tbDelLoc
            // 
            tbDelLoc.Location = new Point(186, 56);
            tbDelLoc.Name = "tbDelLoc";
            tbDelLoc.Size = new Size(170, 23);
            tbDelLoc.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(34, 88);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lbDelProd
            // 
            lbDelProd.AutoSize = true;
            lbDelProd.Location = new Point(37, 31);
            lbDelProd.Name = "lbDelProd";
            lbDelProd.Size = new Size(63, 15);
            lbDelProd.TabIndex = 5;
            lbDelProd.Text = "ProductID:";
            // 
            // tbDelProd
            // 
            tbDelProd.Location = new Point(186, 27);
            tbDelProd.Name = "tbDelProd";
            tbDelProd.Size = new Size(170, 23);
            tbDelProd.TabIndex = 0;
            // 
            // dgvResults
            // 
            dgvResults.BackgroundColor = SystemColors.ButtonHighlight;
            dgvResults.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResults.Enabled = false;
            dgvResults.Location = new Point(427, 39);
            dgvResults.Margin = new Padding(2, 1, 2, 1);
            dgvResults.Name = "dgvResults";
            dgvResults.RowHeadersWidth = 82;
            dgvResults.Size = new Size(367, 231);
            dgvResults.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(818, 531);
            Controls.Add(dgvResults);
            Controls.Add(groupBox1);
            Controls.Add(radioGroup);
            Controls.Add(Fields);
            Name = "Form1";
            Text = "Form1";
            Fields.ResumeLayout(false);
            Fields.PerformLayout();
            radioGroup.ResumeLayout(false);
            radioGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResults).EndInit();
            ResumeLayout(false);
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
    }
}
