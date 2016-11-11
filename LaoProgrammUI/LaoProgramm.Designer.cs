namespace LaoProgrammUI
{
    partial class LaoProgramm
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
            this.lBoxItems = new System.Windows.Forms.ListBox();
            this.lBoxCart = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnBuy = new System.Windows.Forms.Button();
            this.LboxVendor = new System.Windows.Forms.ListBox();
            this.labelStoreProfit = new System.Windows.Forms.Label();
            this.labelStoreMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lBoxItems
            // 
            this.lBoxItems.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lBoxItems.FormattingEnabled = true;
            this.lBoxItems.ItemHeight = 15;
            this.lBoxItems.Location = new System.Drawing.Point(12, 37);
            this.lBoxItems.Name = "lBoxItems";
            this.lBoxItems.Size = new System.Drawing.Size(146, 184);
            this.lBoxItems.TabIndex = 0;
            // 
            // lBoxCart
            // 
            this.lBoxCart.FormattingEnabled = true;
            this.lBoxCart.Location = new System.Drawing.Point(367, 35);
            this.lBoxCart.Name = "lBoxCart";
            this.lBoxCart.Size = new System.Drawing.Size(146, 186);
            this.lBoxCart.TabIndex = 1;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(208, 107);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(101, 44);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnBuy
            // 
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnBuy.ForeColor = System.Drawing.Color.Crimson;
            this.btnBuy.Location = new System.Drawing.Point(367, 244);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(101, 44);
            this.btnBuy.TabIndex = 3;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // LboxVendor
            // 
            this.LboxVendor.FormattingEnabled = true;
            this.LboxVendor.Location = new System.Drawing.Point(12, 272);
            this.LboxVendor.Name = "LboxVendor";
            this.LboxVendor.Size = new System.Drawing.Size(146, 186);
            this.LboxVendor.TabIndex = 4;
            // 
            // labelStoreProfit
            // 
            this.labelStoreProfit.AutoSize = true;
            this.labelStoreProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelStoreProfit.Location = new System.Drawing.Point(236, 395);
            this.labelStoreProfit.Name = "labelStoreProfit";
            this.labelStoreProfit.Size = new System.Drawing.Size(171, 31);
            this.labelStoreProfit.TabIndex = 5;
            this.labelStoreProfit.Text = "Store Profit:";
            this.labelStoreProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStoreMoney
            // 
            this.labelStoreMoney.AutoSize = true;
            this.labelStoreMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelStoreMoney.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelStoreMoney.Location = new System.Drawing.Point(462, 395);
            this.labelStoreMoney.Name = "labelStoreMoney";
            this.labelStoreMoney.Size = new System.Drawing.Size(87, 31);
            this.labelStoreMoney.TabIndex = 6;
            this.labelStoreMoney.Text = "0.00€";
            this.labelStoreMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vendors";
            // 
            // LaoProgramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 498);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelStoreMoney);
            this.Controls.Add(this.labelStoreProfit);
            this.Controls.Add(this.LboxVendor);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lBoxCart);
            this.Controls.Add(this.lBoxItems);
            this.Name = "LaoProgramm";
            this.Text = "LaoProgramm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBoxItems;
        private System.Windows.Forms.ListBox lBoxCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ListBox LboxVendor;
        private System.Windows.Forms.Label labelStoreProfit;
        private System.Windows.Forms.Label labelStoreMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

