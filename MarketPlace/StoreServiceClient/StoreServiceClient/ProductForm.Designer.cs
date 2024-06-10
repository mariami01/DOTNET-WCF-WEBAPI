
namespace MarketServiceClientApp {
    partial class ProductForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.productName = new System.Windows.Forms.Label();
            this.productDescription = new System.Windows.Forms.Label();
            this.productQuantity = new System.Windows.Forms.Label();
            this.TbProductname = new System.Windows.Forms.TextBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.NumQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            this.SuspendLayout();
            
            this.productName.AutoSize = true;
            this.productName.Location = new System.Drawing.Point(198, 36);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(75, 13);
            this.productName.TabIndex = 0;
            this.productName.Text = "Product Name";
             
            this.productDescription.AutoSize = true;
            this.productDescription.Location = new System.Drawing.Point(198, 80);
            this.productDescription.Name = "productDescription";
            this.productDescription.Size = new System.Drawing.Size(60, 13);
            this.productDescription.TabIndex = 0;
            this.productDescription.Text = "Description";
            
            this.productQuantity.AutoSize = true;
            this.productQuantity.Location = new System.Drawing.Point(198, 122);
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.Size = new System.Drawing.Size(46, 13);
            this.productQuantity.TabIndex = 0;
            this.productQuantity.Text = "Quantity";
            
            this.TbProductname.Location = new System.Drawing.Point(279, 33);
            this.TbProductname.Name = "TbProductname";
            this.TbProductname.Size = new System.Drawing.Size(241, 20);
            this.TbProductname.TabIndex = 2;
             
            this.TbDescription.Location = new System.Drawing.Point(279, 77);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(241, 20);
            this.TbDescription.TabIndex = 3;
            
            this.NumQuantity.Location = new System.Drawing.Point(279, 120);
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(241, 20);
            this.NumQuantity.TabIndex = 5;
            
            this.BtnSave.Location = new System.Drawing.Point(201, 225);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(319, 23);
            this.BtnSave.TabIndex = 7;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.NumQuantity);
            this.Controls.Add(this.TbDescription);
            this.Controls.Add(this.TbProductname);
            this.Controls.Add(this.productQuantity);
            this.Controls.Add(this.productDescription);
            this.Controls.Add(this.productName);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productDescription;
        private System.Windows.Forms.Label productQuantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbProductname;
        private System.Windows.Forms.TextBox TbDescription;
        private System.Windows.Forms.NumericUpDown NumQuantity;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.Button BtnSave;
    }
}