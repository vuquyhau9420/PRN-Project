namespace Project_Final.ucControl {
    partial class ucProductMainFrm {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Category");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucProductMainFrm));
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Supplier");
            this.treeViewCategory = new System.Windows.Forms.TreeView();
            this.imageListCategory = new System.Windows.Forms.ImageList(this.components);
            this.dgvProductGroup = new System.Windows.Forms.DataGridView();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnAddProductGroup = new System.Windows.Forms.Button();
            this.btnDeleteProductGroup = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnDeleteSupplier = new System.Windows.Forms.Button();
            this.treeViewSupplier = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewCategory
            // 
            this.treeViewCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeViewCategory.ImageIndex = 0;
            this.treeViewCategory.ImageList = this.imageListCategory;
            this.treeViewCategory.Location = new System.Drawing.Point(0, 0);
            this.treeViewCategory.Name = "treeViewCategory";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Category";
            this.treeViewCategory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeViewCategory.SelectedImageIndex = 0;
            this.treeViewCategory.Size = new System.Drawing.Size(184, 678);
            this.treeViewCategory.TabIndex = 0;
            this.treeViewCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategory_AfterSelect);
            // 
            // imageListCategory
            // 
            this.imageListCategory.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCategory.ImageStream")));
            this.imageListCategory.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCategory.Images.SetKeyName(0, "category.png");
            this.imageListCategory.Images.SetKeyName(1, "on_star.png");
            this.imageListCategory.Images.SetKeyName(2, "off_star.png");
            // 
            // dgvProductGroup
            // 
            this.dgvProductGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductGroup.Location = new System.Drawing.Point(3, 16);
            this.dgvProductGroup.Name = "dgvProductGroup";
            this.dgvProductGroup.Size = new System.Drawing.Size(827, 463);
            this.dgvProductGroup.TabIndex = 1;
            this.dgvProductGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductGroup_CellClick);
            this.dgvProductGroup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductGroup_CellDoubleClick);
            // 
            // dgvProduct
            // 
            this.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(3, 16);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(827, 102);
            this.dgvProduct.TabIndex = 4;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dgvProductGroup);
            this.groupBox1.Location = new System.Drawing.Point(190, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 482);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Group";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.dgvProduct);
            this.groupBox2.Location = new System.Drawing.Point(190, 544);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(833, 121);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Image = global::Project_Final.Properties.Resources.delete_16px;
            this.btnDeleteCategory.Location = new System.Drawing.Point(107, 16);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(90, 28);
            this.btnDeleteCategory.TabIndex = 12;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddCategory);
            this.groupBox3.Controls.Add(this.btnDeleteCategory);
            this.groupBox3.Location = new System.Drawing.Point(193, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 50);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Category Control";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Image = global::Project_Final.Properties.Resources.add_16px;
            this.btnAddCategory.Location = new System.Drawing.Point(6, 16);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(97, 28);
            this.btnAddCategory.TabIndex = 11;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnAddProductGroup);
            this.groupBox4.Controls.Add(this.btnDeleteProductGroup);
            this.groupBox4.Location = new System.Drawing.Point(402, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(203, 50);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Product Group Control";
            // 
            // btnAddProductGroup
            // 
            this.btnAddProductGroup.Image = global::Project_Final.Properties.Resources.add_16px;
            this.btnAddProductGroup.Location = new System.Drawing.Point(6, 16);
            this.btnAddProductGroup.Name = "btnAddProductGroup";
            this.btnAddProductGroup.Size = new System.Drawing.Size(97, 28);
            this.btnAddProductGroup.TabIndex = 11;
            this.btnAddProductGroup.Text = "Add";
            this.btnAddProductGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProductGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProductGroup.UseVisualStyleBackColor = true;
            this.btnAddProductGroup.Click += new System.EventHandler(this.btnAddProductGroup_Click);
            // 
            // btnDeleteProductGroup
            // 
            this.btnDeleteProductGroup.Image = global::Project_Final.Properties.Resources.delete_16px;
            this.btnDeleteProductGroup.Location = new System.Drawing.Point(107, 16);
            this.btnDeleteProductGroup.Name = "btnDeleteProductGroup";
            this.btnDeleteProductGroup.Size = new System.Drawing.Size(90, 28);
            this.btnDeleteProductGroup.TabIndex = 12;
            this.btnDeleteProductGroup.Text = "Delete";
            this.btnDeleteProductGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProductGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProductGroup.UseVisualStyleBackColor = true;
            this.btnDeleteProductGroup.Click += new System.EventHandler(this.btnDeleteProductGroup_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnAddProduct);
            this.groupBox5.Controls.Add(this.btnDeleteProduct);
            this.groupBox5.Location = new System.Drawing.Point(611, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(203, 50);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Product Control";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Image = global::Project_Final.Properties.Resources.add_16px;
            this.btnAddProduct.Location = new System.Drawing.Point(6, 16);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(97, 28);
            this.btnAddProduct.TabIndex = 11;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Image = global::Project_Final.Properties.Resources.delete_16px;
            this.btnDeleteProduct.Location = new System.Drawing.Point(107, 16);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(90, 28);
            this.btnDeleteProduct.TabIndex = 12;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAddSupplier);
            this.groupBox6.Controls.Add(this.btnDeleteSupplier);
            this.groupBox6.Location = new System.Drawing.Point(820, 0);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(203, 50);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Supplier Control";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Image = global::Project_Final.Properties.Resources.add_16px;
            this.btnAddSupplier.Location = new System.Drawing.Point(6, 16);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(97, 28);
            this.btnAddSupplier.TabIndex = 11;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSupplier
            // 
            this.btnDeleteSupplier.Image = global::Project_Final.Properties.Resources.delete_16px;
            this.btnDeleteSupplier.Location = new System.Drawing.Point(107, 16);
            this.btnDeleteSupplier.Name = "btnDeleteSupplier";
            this.btnDeleteSupplier.Size = new System.Drawing.Size(90, 28);
            this.btnDeleteSupplier.TabIndex = 12;
            this.btnDeleteSupplier.Text = "Delete";
            this.btnDeleteSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnDeleteSupplier.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // treeViewSupplier
            // 
            this.treeViewSupplier.Dock = System.Windows.Forms.DockStyle.Right;
            this.treeViewSupplier.ImageIndex = 0;
            this.treeViewSupplier.ImageList = this.imageListCategory;
            this.treeViewSupplier.Location = new System.Drawing.Point(1032, 0);
            this.treeViewSupplier.Name = "treeViewSupplier";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Supplier";
            this.treeViewSupplier.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeViewSupplier.SelectedImageIndex = 0;
            this.treeViewSupplier.Size = new System.Drawing.Size(184, 678);
            this.treeViewSupplier.TabIndex = 0;
            this.treeViewSupplier.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSupplier_AfterSelect);
            // 
            // ucProductMainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeViewSupplier);
            this.Controls.Add(this.treeViewCategory);
            this.Name = "ucProductMainFrm";
            this.Size = new System.Drawing.Size(1216, 678);
            this.Load += new System.EventHandler(this.ucProductMainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCategory;
        private System.Windows.Forms.DataGridView dgvProductGroup;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAddProductGroup;
        private System.Windows.Forms.Button btnDeleteProductGroup;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.ImageList imageListCategory;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnDeleteSupplier;
        private System.Windows.Forms.TreeView treeViewSupplier;
    }
}
