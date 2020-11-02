namespace Project_Final.ucControl
{
    partial class ucCustomerFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbCustomerDetails = new System.Windows.Forms.GroupBox();
            this.txtCusPhone = new System.Windows.Forms.TextBox();
            this.txtCusPoint = new System.Windows.Forms.TextBox();
            this.txtCusEmail = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.txtCusAddress = new System.Windows.Forms.TextBox();
            this.mskCusBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(555, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(559, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Customer Points";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Customer BirthDate:";
            // 
            // gbCustomerDetails
            // 
            this.gbCustomerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbCustomerDetails.BackColor = System.Drawing.Color.Bisque;
            this.gbCustomerDetails.Controls.Add(this.txtCusPhone);
            this.gbCustomerDetails.Controls.Add(this.txtCusPoint);
            this.gbCustomerDetails.Controls.Add(this.txtCusEmail);
            this.gbCustomerDetails.Controls.Add(this.txtCusName);
            this.gbCustomerDetails.Controls.Add(this.txtCusAddress);
            this.gbCustomerDetails.Controls.Add(this.mskCusBirthDate);
            this.gbCustomerDetails.Controls.Add(this.label1);
            this.gbCustomerDetails.Controls.Add(this.label6);
            this.gbCustomerDetails.Controls.Add(this.label2);
            this.gbCustomerDetails.Controls.Add(this.label5);
            this.gbCustomerDetails.Controls.Add(this.label3);
            this.gbCustomerDetails.Controls.Add(this.label4);
            this.gbCustomerDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbCustomerDetails.Location = new System.Drawing.Point(32, 26);
            this.gbCustomerDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCustomerDetails.Name = "gbCustomerDetails";
            this.gbCustomerDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbCustomerDetails.Size = new System.Drawing.Size(1051, 245);
            this.gbCustomerDetails.TabIndex = 6;
            this.gbCustomerDetails.TabStop = false;
            this.gbCustomerDetails.Text = "Customer Details";
            // 
            // txtCusPhone
            // 
            this.txtCusPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCusPhone.Location = new System.Drawing.Point(557, 59);
            this.txtCusPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusPhone.Name = "txtCusPhone";
            this.txtCusPhone.Size = new System.Drawing.Size(305, 22);
            this.txtCusPhone.TabIndex = 12;
            // 
            // txtCusPoint
            // 
            this.txtCusPoint.Location = new System.Drawing.Point(559, 212);
            this.txtCusPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusPoint.Name = "txtCusPoint";
            this.txtCusPoint.Size = new System.Drawing.Size(168, 22);
            this.txtCusPoint.TabIndex = 11;
            // 
            // txtCusEmail
            // 
            this.txtCusEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCusEmail.Location = new System.Drawing.Point(557, 121);
            this.txtCusEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusEmail.Name = "txtCusEmail";
            this.txtCusEmail.Size = new System.Drawing.Size(311, 22);
            this.txtCusEmail.TabIndex = 10;
            // 
            // txtCusName
            // 
            this.txtCusName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCusName.Location = new System.Drawing.Point(32, 62);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(333, 22);
            this.txtCusName.TabIndex = 8;
            // 
            // txtCusAddress
            // 
            this.txtCusAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCusAddress.Location = new System.Drawing.Point(32, 121);
            this.txtCusAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCusAddress.Name = "txtCusAddress";
            this.txtCusAddress.Size = new System.Drawing.Size(333, 22);
            this.txtCusAddress.TabIndex = 7;
            // 
            // mskCusBirthDate
            // 
            this.mskCusBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCusBirthDate.Location = new System.Drawing.Point(32, 212);
            this.mskCusBirthDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mskCusBirthDate.Mask = "00/00/0000";
            this.mskCusBirthDate.Name = "mskCusBirthDate";
            this.mskCusBirthDate.Size = new System.Drawing.Size(103, 27);
            this.mskCusBirthDate.TabIndex = 6;
            this.mskCusBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskCusBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(32, 369);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(1051, 310);
            this.dgvCustomer.TabIndex = 7;
            // 
            // btnAddCus
            // 
            this.btnAddCus.Location = new System.Drawing.Point(64, 311);
            this.btnAddCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(92, 36);
            this.btnAddCus.TabIndex = 8;
            this.btnAddCus.Text = "Add";
            this.btnAddCus.UseVisualStyleBackColor = true;
            // 
            // btnEditCus
            // 
            this.btnEditCus.Location = new System.Drawing.Point(180, 311);
            this.btnEditCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Size = new System.Drawing.Size(85, 36);
            this.btnEditCus.TabIndex = 9;
            this.btnEditCus.Text = "Edit";
            this.btnEditCus.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.Location = new System.Drawing.Point(293, 311);
            this.btnDeleteCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(84, 36);
            this.btnDeleteCus.TabIndex = 10;
            this.btnDeleteCus.Text = "Delete";
            this.btnDeleteCus.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(708, 322);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(375, 22);
            this.txtSearch.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(529, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Search by name:";
            // 
            // ucCustomerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDeleteCus);
            this.Controls.Add(this.btnEditCus);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.gbCustomerDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucCustomerFrm";
            this.Size = new System.Drawing.Size(1121, 710);
            this.gbCustomerDetails.ResumeLayout(false);
            this.gbCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbCustomerDetails;
        private System.Windows.Forms.MaskedTextBox mskCusBirthDate;
        private System.Windows.Forms.TextBox txtCusPoint;
        private System.Windows.Forms.TextBox txtCusEmail;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.TextBox txtCusAddress;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCusPhone;
    }
}
