namespace Client
{
    partial class Order
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
            this.orderdatagridiew = new System.Windows.Forms.DataGridView();
            this.orderlabel = new System.Windows.Forms.Label();
            this.loadbtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.productname = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.Label();
            this.quantitynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.addbtn = new System.Windows.Forms.Button();
            this.totalcalcbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderdatagridiew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // orderdatagridiew
            // 
            this.orderdatagridiew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderdatagridiew.Location = new System.Drawing.Point(345, 136);
            this.orderdatagridiew.Name = "orderdatagridiew";
            this.orderdatagridiew.RowHeadersWidth = 51;
            this.orderdatagridiew.RowTemplate.Height = 24;
            this.orderdatagridiew.Size = new System.Drawing.Size(655, 308);
            this.orderdatagridiew.TabIndex = 0;
            this.orderdatagridiew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.orderdatagridiew_CellContentClick);
            // 
            // orderlabel
            // 
            this.orderlabel.AutoSize = true;
            this.orderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.orderlabel.Location = new System.Drawing.Point(342, 32);
            this.orderlabel.Name = "orderlabel";
            this.orderlabel.Size = new System.Drawing.Size(120, 39);
            this.orderlabel.TabIndex = 1;
            this.orderlabel.Text = "Orders";
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(814, 97);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(75, 23);
            this.loadbtn.TabIndex = 2;
            this.loadbtn.Text = "load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Location = new System.Drawing.Point(694, 97);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(75, 23);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "delete";
            this.deletebtn.UseVisualStyleBackColor = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.Location = new System.Drawing.Point(575, 97);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(75, 23);
            this.editbtn.TabIndex = 4;
            this.editbtn.Text = "edit";
            this.editbtn.UseVisualStyleBackColor = true;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(30, 151);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(44, 16);
            this.namelabel.TabIndex = 6;
            this.namelabel.Text = "Name";
            // 
            // productname
            // 
            this.productname.Location = new System.Drawing.Point(127, 151);
            this.productname.Name = "productname";
            this.productname.Size = new System.Drawing.Size(120, 22);
            this.productname.TabIndex = 7;
            this.productname.TextChanged += new System.EventHandler(this.productname_TextChanged);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(30, 208);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(55, 16);
            this.quantity.TabIndex = 8;
            this.quantity.Text = "Quantity";
            // 
            // quantitynumericUpDown
            // 
            this.quantitynumericUpDown.Location = new System.Drawing.Point(127, 208);
            this.quantitynumericUpDown.Name = "quantitynumericUpDown";
            this.quantitynumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.quantitynumericUpDown.TabIndex = 9;
            this.quantitynumericUpDown.ValueChanged += new System.EventHandler(this.quantitynumericUpDown_ValueChanged);
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(74, 286);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 10;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // totalcalcbtn
            // 
            this.totalcalcbtn.Location = new System.Drawing.Point(345, 461);
            this.totalcalcbtn.Name = "totalcalcbtn";
            this.totalcalcbtn.Size = new System.Drawing.Size(109, 23);
            this.totalcalcbtn.TabIndex = 11;
            this.totalcalcbtn.Text = "Total";
            this.totalcalcbtn.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 532);
            this.Controls.Add(this.totalcalcbtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.quantitynumericUpDown);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.productname);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.editbtn);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.orderlabel);
            this.Controls.Add(this.orderdatagridiew);
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.orderdatagridiew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantitynumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView orderdatagridiew;
        private System.Windows.Forms.Label orderlabel;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.TextBox productname;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.NumericUpDown quantitynumericUpDown;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button totalcalcbtn;
    }
}