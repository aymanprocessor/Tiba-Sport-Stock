namespace Tiba_Sport_Stock
{
    partial class Add_Permission
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbName = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbDesc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCosrPerItem = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.cbName);
            this.panel1.Controls.Add(this.cbType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblOrderNo);
            this.panel1.Controls.Add(this.lblTransNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(39, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 103);
            this.panel1.TabIndex = 0;
            // 
            // cbName
            // 
            this.cbName.FormattingEnabled = true;
            this.cbName.Location = new System.Drawing.Point(99, 54);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(248, 27);
            this.cbName.TabIndex = 3;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(451, 54);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(130, 27);
            this.cbType.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "الاســـم :";
            // 
            // date
            // 
            this.date.CustomFormat = "dd/MM/yyyy";
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(451, 22);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(130, 26);
            this.date.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "نوع الحركة :";
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.Location = new System.Drawing.Point(95, 28);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblOrderNo.Size = new System.Drawing.Size(80, 19);
            this.lblOrderNo.TabIndex = 1;
            this.lblOrderNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTransNo
            // 
            this.lblTransNo.Location = new System.Drawing.Point(267, 28);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTransNo.Size = new System.Drawing.Size(80, 19);
            this.lblTransNo.TabIndex = 1;
            this.lblTransNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "رقم الطلب :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "التاريخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الحركة :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "الاجمالي الكلي";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.DarkTurquoise;
            this.lblTotalCost.Location = new System.Drawing.Point(13, 48);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTotalCost.Size = new System.Drawing.Size(150, 52);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "0 جنيه";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgView
            // 
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(12, 285);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(815, 318);
            this.dgView.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(677, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 19);
            this.label10.TabIndex = 2;
            this.label10.Text = "كود الصنف :";
            // 
            // cbCode
            // 
            this.cbCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCode.FormattingEnabled = true;
            this.cbCode.Location = new System.Drawing.Point(550, 28);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(121, 27);
            this.cbCode.TabIndex = 3;
            this.cbCode.SelectionChangeCommitted += new System.EventHandler(this.cbCode_SelectionChangeCommitted);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(467, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "اسم الصنف :";
            // 
            // cbDesc
            // 
            this.cbDesc.FormattingEnabled = true;
            this.cbDesc.Location = new System.Drawing.Point(181, 28);
            this.cbDesc.Name = "cbDesc";
            this.cbDesc.Size = new System.Drawing.Size(280, 27);
            this.cbDesc.TabIndex = 3;
            this.cbDesc.SelectionChangeCommitted += new System.EventHandler(this.cbDesc_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(677, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 19);
            this.label12.TabIndex = 2;
            this.label12.Text = "السعر :";
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(550, 61);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(121, 26);
            this.tbCost.TabIndex = 4;
            this.tbCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(467, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "الكمية :";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(340, 61);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(121, 26);
            this.tbQuantity.TabIndex = 4;
            this.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(248, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "الاجمالي :";
            // 
            // lblCosrPerItem
            // 
            this.lblCosrPerItem.Location = new System.Drawing.Point(179, 64);
            this.lblCosrPerItem.Name = "lblCosrPerItem";
            this.lblCosrPerItem.Size = new System.Drawing.Size(63, 19);
            this.lblCosrPerItem.TabIndex = 2;
            this.lblCosrPerItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbQuantity);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbCost);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cbDesc);
            this.panel2.Controls.Add(this.cbCode);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblCosrPerItem);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.lblTotalCost);
            this.panel2.Location = new System.Drawing.Point(39, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 113);
            this.panel2.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(463, 240);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(382, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 39);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "مسح";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Location = new System.Drawing.Point(301, 240);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 39);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Add_Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 615);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Add_Permission";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اذن الاضافة";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Add_Permission_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTransNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbDesc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCosrPerItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
    }
}