namespace Northwind.Test.Views
{
    partial class ShowProductsWithCView
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
            this.components = new System.ComponentModel.Container();
            this.ShowProducts = new ENV.Printing.Grid();
            this.gcProductID = new ENV.Printing.GridColumn();
            this.txtProductID = new ENV.Printing.TextBox();
            this.gcProductName = new ENV.Printing.GridColumn();
            this.txtProductName = new ENV.Printing.TextBox();
            this.gcUnitPrice = new ENV.Printing.GridColumn();
            this.txtUnitPrice = new ENV.Printing.TextBox();
            this.ShowProducts.SuspendLayout();
            this.gcProductID.SuspendLayout();
            this.gcProductName.SuspendLayout();
            this.gcUnitPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowProducts
            // 
            this.ShowProducts.BackColor = System.Drawing.Color.LightGray;
            this.ShowProducts.Border = Firefly.Box.UI.ControlBorderStyle.Thick;
            this.ShowProducts.ColumnHeadersBackColor = System.Drawing.Color.Gray;
            this.ShowProducts.ColumnHeadersForeColor = System.Drawing.Color.Gray;
            this.ShowProducts.Controls.Add(this.gcProductID);
            this.ShowProducts.Controls.Add(this.gcProductName);
            this.ShowProducts.Controls.Add(this.gcUnitPrice);
            this.ShowProducts.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ShowProducts.Location = new System.Drawing.Point(56, 14);
            this.ShowProducts.Name = "ShowProducts";
            this.ShowProducts.Size = new System.Drawing.Size(392, 379);
            this.ShowProducts.StartOnRowPosition = Firefly.Box.UI.GridStartOnRowPosition.MiddleRowNeverBelow;
            this.ShowProducts.Text = "ShowProducts";
            this.ShowProducts.Click += new System.EventHandler(this.ShowProducts_Click);
            // 
            // gcProductID
            // 
            this.gcProductID.Controls.Add(this.txtProductID);
            this.gcProductID.Name = "gcProductID";
            this.gcProductID.Text = "ProductID";
            this.gcProductID.Width = 131;
            // 
            // txtProductID
            // 
            this.txtProductID.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtProductID.Location = new System.Drawing.Point(2, 1);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(125, 21);
            this.txtProductID.Data = this._controller.products.ProductID;
            // 
            // gcProductName
            // 
            this.gcProductName.Controls.Add(this.txtProductName);
            this.gcProductName.Name = "gcProductName";
            this.gcProductName.Text = "ProductName";
            this.gcProductName.Width = 149;
            this.gcProductName.Click += new System.EventHandler(this.gcProductName_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtProductName.Location = new System.Drawing.Point(2, 1);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(279, 21);
            this.txtProductName.Data = this._controller.products.ProductName;
            // 
            // gcUnitPrice
            // 
            this.gcUnitPrice.Controls.Add(this.txtUnitPrice);
            this.gcUnitPrice.Name = "gcUnitPrice";
            this.gcUnitPrice.Text = "UnitPrice";
            this.gcUnitPrice.Width = 88;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AdvancedAnchor = new Firefly.Box.UI.AdvancedAnchor(0, 100, 0, 100);
            this.txtUnitPrice.Location = new System.Drawing.Point(2, 1);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(158, 21);
            this.txtUnitPrice.Data = this._controller.products.UnitPrice;
            // 
            // ShowProductsWithCView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 431);
            this.Controls.Add(this.ShowProducts);
            this.HorizontalExpressionFactor = 1D;
            this.Name = "ShowProductsWithCView";
            this.Text = "Show product begin With C";
            this.VerticalExpressionFactor = 1D;
            this.Load += new System.EventHandler(this.ShowProductsWithCView_Load);
            this.ShowProducts.ResumeLayout(false);
            this.gcProductID.ResumeLayout(false);
            this.gcProductName.ResumeLayout(false);
            this.gcUnitPrice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ENV.Printing.Grid ShowProducts;
        private ENV.Printing.GridColumn gcProductID;
        private ENV.Printing.TextBox txtProductID;
        private ENV.Printing.GridColumn gcProductName;
        private ENV.Printing.TextBox txtProductName;
        private ENV.Printing.GridColumn gcUnitPrice;
        private ENV.Printing.TextBox txtUnitPrice;
    }
}