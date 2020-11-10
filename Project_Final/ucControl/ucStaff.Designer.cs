namespace Project_Final.ucControl
{
    partial class ucStaff
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
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbActionStatus = new System.Windows.Forms.Label();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.chkSex = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtCiti_Iden = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pBImage = new System.Windows.Forms.PictureBox();
            this.mskBirthday = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(24, 398);
            this.dgvStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.RowHeadersWidth = 51;
            this.dgvStaff.RowTemplate.Height = 24;
            this.dgvStaff.Size = new System.Drawing.Size(896, 336);
            this.dgvStaff.TabIndex = 0;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mskBirthday);
            this.groupBox1.Controls.Add(this.txtStaffID);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbActionStatus);
            this.groupBox1.Controls.Add(this.cboRole);
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.chkSex);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnChooseImage);
            this.groupBox1.Controls.Add(this.txtImage);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtCiti_Iden);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.txtStaffName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1232, 362);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Staff Details";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Location = new System.Drawing.Point(243, 36);
            this.txtStaffID.Margin = new System.Windows.Forms.Padding(4);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(220, 22);
            this.txtStaffID.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(157, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Staff ID";
            // 
            // lbActionStatus
            // 
            this.lbActionStatus.AutoSize = true;
            this.lbActionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActionStatus.Location = new System.Drawing.Point(860, 319);
            this.lbActionStatus.Name = "lbActionStatus";
            this.lbActionStatus.Size = new System.Drawing.Size(104, 17);
            this.lbActionStatus.TabIndex = 27;
            this.lbActionStatus.Text = "Action Status";
            // 
            // cboRole
            // 
            this.cboRole.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Location = new System.Drawing.Point(745, 71);
            this.cboRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(189, 24);
            this.cboRole.TabIndex = 26;
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(745, 123);
            this.chkStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(18, 17);
            this.chkStatus.TabIndex = 25;
            this.chkStatus.UseVisualStyleBackColor = true;
            // 
            // chkSex
            // 
            this.chkSex.AutoSize = true;
            this.chkSex.Location = new System.Drawing.Point(247, 249);
            this.chkSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkSex.Name = "chkSex";
            this.chkSex.Size = new System.Drawing.Size(18, 17);
            this.chkSex.TabIndex = 24;
            this.chkSex.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1053, 239);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 39);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Yellow;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(929, 240);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(99, 37);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(797, 240);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Blue;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(665, 240);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 39);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChooseImage.Enabled = false;
            this.btnChooseImage.Location = new System.Drawing.Point(947, 165);
            this.btnChooseImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(134, 24);
            this.btnChooseImage.TabIndex = 19;
            this.btnChooseImage.Text = "Choose Image";
            this.btnChooseImage.UseVisualStyleBackColor = true;
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // txtImage
            // 
            this.txtImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImage.Enabled = false;
            this.txtImage.Location = new System.Drawing.Point(745, 167);
            this.txtImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(189, 22);
            this.txtImage.TabIndex = 18;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(247, 319);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 22);
            this.txtAddress.TabIndex = 16;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(247, 277);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(217, 22);
            this.txtPhoneNumber.TabIndex = 15;
            // 
            // txtCiti_Iden
            // 
            this.txtCiti_Iden.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCiti_Iden.Location = new System.Drawing.Point(247, 198);
            this.txtCiti_Iden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCiti_Iden.Name = "txtCiti_Iden";
            this.txtCiti_Iden.Size = new System.Drawing.Size(216, 22);
            this.txtCiti_Iden.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.Location = new System.Drawing.Point(245, 161);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 22);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Location = new System.Drawing.Point(245, 116);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(217, 22);
            this.txtUsername.TabIndex = 12;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStaffName.Location = new System.Drawing.Point(245, 75);
            this.txtStaffName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(217, 22);
            this.txtStaffName.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(665, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Image";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(661, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(677, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(645, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Birthday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(89, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(189, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Sex";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Citizen identification";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pBImage);
            this.groupBox2.Location = new System.Drawing.Point(953, 389);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(303, 345);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Image";
            // 
            // pBImage
            // 
            this.pBImage.Location = new System.Drawing.Point(5, 19);
            this.pBImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pBImage.Name = "pBImage";
            this.pBImage.Size = new System.Drawing.Size(292, 322);
            this.pBImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBImage.TabIndex = 0;
            this.pBImage.TabStop = false;
            // 
            // mskBirthday
            // 
            this.mskBirthday.Location = new System.Drawing.Point(745, 23);
            this.mskBirthday.Mask = "00/00/0000";
            this.mskBirthday.Name = "mskBirthday";
            this.mskBirthday.Size = new System.Drawing.Size(189, 22);
            this.mskBirthday.TabIndex = 30;
            this.mskBirthday.ValidatingType = typeof(System.DateTime);
            // 
            // ucStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvStaff);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ucStaff";
            this.Size = new System.Drawing.Size(1275, 756);
            this.Load += new System.EventHandler(this.ucStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkSex;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtCiti_Iden;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbActionStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pBImage;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskBirthday;
    }
}
