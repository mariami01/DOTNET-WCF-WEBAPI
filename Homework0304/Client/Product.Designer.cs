namespace Client
{
    partial class Product
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
            this.prodDetailLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.proddataGridView = new System.Windows.Forms.DataGridView();
            this.loadbtn = new System.Windows.Forms.Button();
            this.orderbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prodDetailLabel
            // 
            this.prodDetailLabel.AutoSize = true;
            this.prodDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.prodDetailLabel.Location = new System.Drawing.Point(500, 41);
            this.prodDetailLabel.Name = "prodDetailLabel";
            this.prodDetailLabel.Size = new System.Drawing.Size(151, 39);
            this.prodDetailLabel.TabIndex = 0;
            this.prodDetailLabel.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // proddataGridView
            // 
            this.proddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proddataGridView.Location = new System.Drawing.Point(124, 136);
            this.proddataGridView.Name = "proddataGridView";
            this.proddataGridView.RowHeadersWidth = 51;
            this.proddataGridView.RowTemplate.Height = 24;
            this.proddataGridView.Size = new System.Drawing.Size(923, 373);
            this.proddataGridView.TabIndex = 2;
            this.proddataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.proddataGridView_CellContentClick);
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(124, 107);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(109, 23);
            this.loadbtn.TabIndex = 4;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // orderbtn
            // 
            this.orderbtn.Location = new System.Drawing.Point(938, 107);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(109, 23);
            this.orderbtn.TabIndex = 5;
            this.orderbtn.Text = "Make an order";
            this.orderbtn.UseVisualStyleBackColor = true;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 672);
            this.Controls.Add(this.orderbtn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.proddataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodDetailLabel);
            this.Name = "Product";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.proddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prodDetailLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView proddataGridView;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button orderbtn;
    }
}