namespace Tiba_Sport_Stock
{
    partial class Stock_balance
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDesc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAvgCost = new System.Windows.Forms.TextBox();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "السنة :";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(516, 27);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 27);
            this.cbYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(643, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "كود الصنف :";
            // 
            // cbCode
            // 
            this.cbCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCode.FormattingEnabled = true;
            this.cbCode.Location = new System.Drawing.Point(516, 60);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(121, 27);
            this.cbCode.TabIndex = 1;
            this.cbCode.SelectedIndexChanged += new System.EventHandler(this.cbCode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "وصف الصنف :";
            // 
            // cbDesc
            // 
            this.cbDesc.FormattingEnabled = true;
            this.cbDesc.Location = new System.Drawing.Point(351, 93);
            this.cbDesc.Name = "cbDesc";
            this.cbDesc.Size = new System.Drawing.Size(286, 27);
            this.cbDesc.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "المخزن :";
            // 
            // cbStore
            // 
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(43, 27);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(121, 27);
            this.cbStore.TabIndex = 1;
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(43, 60);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(121, 26);
            this.tbCount.TabIndex = 2;
            this.tbCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "العدد :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "متوسط السعر :";
            // 
            // tbAvgCost
            // 
            this.tbAvgCost.Location = new System.Drawing.Point(43, 92);
            this.tbAvgCost.Name = "tbAvgCost";
            this.tbAvgCost.Size = new System.Drawing.Size(121, 26);
            this.tbAvgCost.TabIndex = 2;
            this.tbAvgCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            this.dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(12, 207);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgView.Size = new System.Drawing.Size(777, 298);
            this.dgView.TabIndex = 3;
            this.dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgView_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Location = new System.Drawing.Point(450, 164);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDelete.Location = new System.Drawing.Point(356, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "مسح";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEdit.Location = new System.Drawing.Point(262, 164);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 34);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "تعديل";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.cbStore);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbAvgCost);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbDesc);
            this.panel1.Controls.Add(this.cbCode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 146);
            this.panel1.TabIndex = 5;
            // 
            // Stock_balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgView);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(817, 555);
            this.Name = "Stock_balance";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "الرصيد";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_balance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAvgCost;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel1;
    }
}