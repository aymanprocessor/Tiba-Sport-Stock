namespace Tiba_Sport_Stock
{
    partial class Clients
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
            this.customer_dgView = new System.Windows.Forms.DataGridView();
            this.customer_btnEdit = new System.Windows.Forms.Button();
            this.customer_btnDelete = new System.Windows.Forms.Button();
            this.customer_btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.customer_tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customer_tbMobile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.customer_tbAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.customer_tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_cbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.customer_dgView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customer_dgView
            // 
            this.customer_dgView.AllowUserToAddRows = false;
            this.customer_dgView.AllowUserToDeleteRows = false;
            this.customer_dgView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_dgView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.customer_dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_dgView.Location = new System.Drawing.Point(14, 258);
            this.customer_dgView.Name = "customer_dgView";
            this.customer_dgView.ReadOnly = true;
            this.customer_dgView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customer_dgView.Size = new System.Drawing.Size(758, 292);
            this.customer_dgView.TabIndex = 6;
            this.customer_dgView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_dgView_CellClick);
            // 
            // customer_btnEdit
            // 
            this.customer_btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customer_btnEdit.Location = new System.Drawing.Point(274, 213);
            this.customer_btnEdit.Name = "customer_btnEdit";
            this.customer_btnEdit.Size = new System.Drawing.Size(75, 39);
            this.customer_btnEdit.TabIndex = 7;
            this.customer_btnEdit.Text = "تعديل";
            this.customer_btnEdit.UseVisualStyleBackColor = true;
            this.customer_btnEdit.Click += new System.EventHandler(this.customer_btnEdit_Click);
            // 
            // customer_btnDelete
            // 
            this.customer_btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customer_btnDelete.Location = new System.Drawing.Point(355, 213);
            this.customer_btnDelete.Name = "customer_btnDelete";
            this.customer_btnDelete.Size = new System.Drawing.Size(75, 39);
            this.customer_btnDelete.TabIndex = 4;
            this.customer_btnDelete.Text = "مسح";
            this.customer_btnDelete.UseVisualStyleBackColor = true;
            this.customer_btnDelete.Click += new System.EventHandler(this.customer_btnDelete_Click);
            // 
            // customer_btnAdd
            // 
            this.customer_btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.customer_btnAdd.Location = new System.Drawing.Point(436, 213);
            this.customer_btnAdd.Name = "customer_btnAdd";
            this.customer_btnAdd.Size = new System.Drawing.Size(75, 39);
            this.customer_btnAdd.TabIndex = 3;
            this.customer_btnAdd.Text = "اضافة";
            this.customer_btnAdd.UseVisualStyleBackColor = true;
            this.customer_btnAdd.Click += new System.EventHandler(this.customer_btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.customer_cbType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.customer_tbEmail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.customer_tbMobile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.customer_tbAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.customer_tbName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 193);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(664, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "النوع :";
            // 
            // customer_tbEmail
            // 
            this.customer_tbEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_tbEmail.Location = new System.Drawing.Point(260, 115);
            this.customer_tbEmail.Name = "customer_tbEmail";
            this.customer_tbEmail.Size = new System.Drawing.Size(396, 26);
            this.customer_tbEmail.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(664, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "الايميل :";
            // 
            // customer_tbMobile
            // 
            this.customer_tbMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_tbMobile.Location = new System.Drawing.Point(260, 83);
            this.customer_tbMobile.Name = "customer_tbMobile";
            this.customer_tbMobile.Size = new System.Drawing.Size(396, 26);
            this.customer_tbMobile.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "الموبايل :";
            // 
            // customer_tbAddress
            // 
            this.customer_tbAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_tbAddress.Location = new System.Drawing.Point(260, 51);
            this.customer_tbAddress.Name = "customer_tbAddress";
            this.customer_tbAddress.Size = new System.Drawing.Size(396, 26);
            this.customer_tbAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "العنوان :";
            // 
            // customer_tbName
            // 
            this.customer_tbName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_tbName.Location = new System.Drawing.Point(260, 19);
            this.customer_tbName.Name = "customer_tbName";
            this.customer_tbName.Size = new System.Drawing.Size(396, 26);
            this.customer_tbName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(664, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم :";
            // 
            // customer_cbType
            // 
            this.customer_cbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customer_cbType.FormattingEnabled = true;
            this.customer_cbType.Items.AddRange(new object[] {
            "المورد",
            "المشتري"});
            this.customer_cbType.Location = new System.Drawing.Point(260, 147);
            this.customer_cbType.Name = "customer_cbType";
            this.customer_cbType.Size = new System.Drawing.Size(396, 27);
            this.customer_cbType.TabIndex = 4;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.customer_dgView);
            this.Controls.Add(this.customer_btnEdit);
            this.Controls.Add(this.customer_btnDelete);
            this.Controls.Add(this.customer_btnAdd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Clients";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "العملاء";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customer_dgView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customer_dgView;
        private System.Windows.Forms.Button customer_btnEdit;
        private System.Windows.Forms.Button customer_btnDelete;
        private System.Windows.Forms.Button customer_btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customer_tbEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox customer_tbMobile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customer_tbAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox customer_tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customer_cbType;
    }
}