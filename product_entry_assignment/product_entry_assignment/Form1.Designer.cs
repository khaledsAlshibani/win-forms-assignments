namespace product_entry_assignment
{
    partial class Form1
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
            this.Product_Name = new System.Windows.Forms.TextBox();
            this.Product_Categories = new System.Windows.Forms.ComboBox();
            this.Products_Listing = new System.Windows.Forms.ListBox();
            this.Add_Product = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Product_Name
            // 
            this.Product_Name.Location = new System.Drawing.Point(98, 69);
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(121, 20);
            this.Product_Name.TabIndex = 0;
            // 
            // Product_Categories
            // 
            this.Product_Categories.FormattingEnabled = true;
            this.Product_Categories.Location = new System.Drawing.Point(98, 128);
            this.Product_Categories.Name = "Product_Categories";
            this.Product_Categories.Size = new System.Drawing.Size(121, 21);
            this.Product_Categories.TabIndex = 1;
            // 
            // Products_Listing
            // 
            this.Products_Listing.FormattingEnabled = true;
            this.Products_Listing.Location = new System.Drawing.Point(98, 202);
            this.Products_Listing.Name = "Products_Listing";
            this.Products_Listing.Size = new System.Drawing.Size(357, 95);
            this.Products_Listing.TabIndex = 2;
            // 
            // Add_Product
            // 
            this.Add_Product.Location = new System.Drawing.Point(98, 325);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(75, 23);
            this.Add_Product.TabIndex = 3;
            this.Add_Product.Text = "Add";
            this.Add_Product.UseVisualStyleBackColor = true;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Products Listing";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(190, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add_Product);
            this.Controls.Add(this.Products_Listing);
            this.Controls.Add(this.Product_Categories);
            this.Controls.Add(this.Product_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Product_Name;
        private System.Windows.Forms.ComboBox Product_Categories;
        private System.Windows.Forms.ListBox Products_Listing;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

