namespace T132094 {
    partial class ProductsReport {
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.DataAccess.Sql.TableQuery tableQuery1 = new DevExpress.DataAccess.Sql.TableQuery();
            DevExpress.DataAccess.Sql.TableInfo tableInfo1 = new DevExpress.DataAccess.Sql.TableInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo1 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo2 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo3 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo4 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo5 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo6 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo7 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo8 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo9 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo10 = new DevExpress.DataAccess.Sql.ColumnInfo();
            DevExpress.DataAccess.Sql.ColumnInfo columnInfo11 = new DevExpress.DataAccess.Sql.ColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsReport));
            this.tcUnitPrice = new DevExpress.XtraReports.UI.XRTableCell();
            this.tbProductData = new DevExpress.XtraReports.UI.XRTable();
            this.lbHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.tcUnitsOnOrderHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.trProductHeader = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcDiscontHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitPriceHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.cbDiscont = new DevExpress.XtraReports.UI.XRCheckBox();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.tcUnitsOnOrder = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsInStock = new DevExpress.XtraReports.UI.XRTableCell();
            this.GroupHeaderTitle = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.tcDiscont = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcUnitsInStockHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.tcProductNameHeader = new DevExpress.XtraReports.UI.XRTableCell();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.trProductData = new DevExpress.XtraReports.UI.XRTableRow();
            this.tcProductName = new DevExpress.XtraReports.UI.XRTableCell();
            this.tbProductHeader = new DevExpress.XtraReports.UI.XRTable();
            this.nwindDataSource = new DevExpress.DataAccess.Sql.SqlDataSource("nwindConnection");
            ((System.ComponentModel.ISupportInitialize)(this.tbProductData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // tcUnitPrice
            // 
            this.tcUnitPrice.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitPrice", "{0:c}")});
            this.tcUnitPrice.Name = "tcUnitPrice";
            this.tcUnitPrice.StylePriority.UseTextAlignment = false;
            this.tcUnitPrice.Text = "tcUnitPrice";
            this.tcUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcUnitPrice.Weight = 0.4663461624235804D;
            // 
            // tbProductData
            // 
            this.tbProductData.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbProductData.Name = "tbProductData";
            this.tbProductData.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trProductData});
            this.tbProductData.SizeF = new System.Drawing.SizeF(649.9999F, 25F);
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.lbHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbHeader.SizeF = new System.Drawing.SizeF(650.0001F, 79.99998F);
            this.lbHeader.StylePriority.UseFont = false;
            this.lbHeader.StylePriority.UseTextAlignment = false;
            this.lbHeader.Text = "Products Report";
            this.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // tcUnitsOnOrderHeader
            // 
            this.tcUnitsOnOrderHeader.Name = "tcUnitsOnOrderHeader";
            this.tcUnitsOnOrderHeader.Text = "Units On Order";
            this.tcUnitsOnOrderHeader.Weight = 0.44903843327809806D;
            // 
            // trProductHeader
            // 
            this.trProductHeader.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcProductNameHeader,
            this.tcUnitPriceHeader,
            this.tcUnitsInStockHeader,
            this.tcUnitsOnOrderHeader,
            this.tcDiscontHeader});
            this.trProductHeader.Name = "trProductHeader";
            this.trProductHeader.Weight = 1D;
            // 
            // tcDiscontHeader
            // 
            this.tcDiscontHeader.Name = "tcDiscontHeader";
            this.tcDiscontHeader.Text = "Discont.";
            this.tcDiscontHeader.Weight = 0.23846170170351017D;
            // 
            // tcUnitPriceHeader
            // 
            this.tcUnitPriceHeader.Name = "tcUnitPriceHeader";
            this.tcUnitPriceHeader.Text = "Unit Price";
            this.tcUnitPriceHeader.Weight = 0.4663460215732067D;
            // 
            // Detail
            // 
            this.Detail.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbProductData});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.StylePriority.UseBorders = false;
            this.Detail.StylePriority.UseTextAlignment = false;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // cbDiscont
            // 
            this.cbDiscont.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.cbDiscont.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("CheckState", null, "Products.Discontinued")});
            this.cbDiscont.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.cbDiscont.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.cbDiscont.Name = "cbDiscont";
            this.cbDiscont.SizeF = new System.Drawing.SizeF(50F, 23F);
            this.cbDiscont.StylePriority.UseBorders = false;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // tcUnitsOnOrder
            // 
            this.tcUnitsOnOrder.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitsOnOrder")});
            this.tcUnitsOnOrder.Name = "tcUnitsOnOrder";
            this.tcUnitsOnOrder.StylePriority.UseTextAlignment = false;
            this.tcUnitsOnOrder.Text = "tcUnitsOnOrder";
            this.tcUnitsOnOrder.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcUnitsOnOrder.Weight = 0.44903843327809811D;
            // 
            // tcUnitsInStock
            // 
            this.tcUnitsInStock.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitsInStock")});
            this.tcUnitsInStock.Name = "tcUnitsInStock";
            this.tcUnitsInStock.StylePriority.UseTextAlignment = false;
            this.tcUnitsInStock.Text = "tcUnitsInStock";
            this.tcUnitsInStock.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.tcUnitsInStock.Weight = 0.46634616242358046D;
            // 
            // GroupHeaderTitle
            // 
            this.GroupHeaderTitle.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.GroupHeaderTitle.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.tbProductHeader});
            this.GroupHeaderTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.GroupHeaderTitle.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
            this.GroupHeaderTitle.HeightF = 25F;
            this.GroupHeaderTitle.Name = "GroupHeaderTitle";
            this.GroupHeaderTitle.RepeatEveryPage = true;
            this.GroupHeaderTitle.StylePriority.UseBorders = false;
            this.GroupHeaderTitle.StylePriority.UseFont = false;
            this.GroupHeaderTitle.StylePriority.UseTextAlignment = false;
            this.GroupHeaderTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter;
            // 
            // tcDiscont
            // 
            this.tcDiscont.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.cbDiscont});
            this.tcDiscont.Name = "tcDiscont";
            this.tcDiscont.Text = "tcDiscont";
            this.tcDiscont.Weight = 0.2384614904279494D;
            // 
            // tcUnitsInStockHeader
            // 
            this.tcUnitsInStockHeader.Name = "tcUnitsInStockHeader";
            this.tcUnitsInStockHeader.Text = "Units In Stock";
            this.tcUnitsInStockHeader.Weight = 0.46634598636061309D;
            // 
            // tcProductNameHeader
            // 
            this.tcProductNameHeader.Name = "tcProductNameHeader";
            this.tcProductNameHeader.Text = "Product Name";
            this.tcProductNameHeader.Weight = 1.379807857084572D;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHeader});
            this.ReportHeader.HeightF = 100F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // trProductData
            // 
            this.trProductData.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tcProductName,
            this.tcUnitPrice,
            this.tcUnitsInStock,
            this.tcUnitsOnOrder,
            this.tcDiscont});
            this.trProductData.Name = "trProductData";
            this.trProductData.Weight = 1D;
            // 
            // tcProductName
            // 
            this.tcProductName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.ProductName")});
            this.tcProductName.Name = "tcProductName";
            this.tcProductName.StylePriority.UseTextAlignment = false;
            this.tcProductName.Text = "tcProductName";
            this.tcProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.tcProductName.Weight = 1.3798077514467915D;
            // 
            // tbProductHeader
            // 
            this.tbProductHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.tbProductHeader.Name = "tbProductHeader";
            this.tbProductHeader.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.trProductHeader});
            this.tbProductHeader.SizeF = new System.Drawing.SizeF(649.9999F, 25F);
            // 
            // nwindDataSource
            // 
            tableQuery1.Name = "Products";
            tableInfo1.Name = "Products";
            columnInfo1.Name = "ProductID";
            columnInfo2.Name = "ProductName";
            columnInfo3.Name = "SupplierID";
            columnInfo4.Name = "CategoryID";
            columnInfo5.Name = "QuantityPerUnit";
            columnInfo6.Name = "UnitPrice";
            columnInfo7.Name = "UnitsInStock";
            columnInfo8.Name = "UnitsOnOrder";
            columnInfo9.Name = "ReorderLevel";
            columnInfo10.Name = "Discontinued";
            columnInfo11.Name = "EAN13";
            tableInfo1.SelectedColumns.AddRange(new DevExpress.DataAccess.Sql.ColumnInfo[] {
            columnInfo1,
            columnInfo2,
            columnInfo3,
            columnInfo4,
            columnInfo5,
            columnInfo6,
            columnInfo7,
            columnInfo8,
            columnInfo9,
            columnInfo10,
            columnInfo11});
            tableQuery1.Tables.AddRange(new DevExpress.DataAccess.Sql.TableInfo[] {
            tableInfo1});
            this.nwindDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            tableQuery1});
            this.nwindDataSource.ResultSchemaSerializable = resources.GetString("nwindDataSource.ResultSchemaSerializable");
            // 
            // ProductsReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.GroupHeaderTitle,
            this.ReportHeader});
            this.DataMember = "Products";
            this.DataSource = this.nwindDataSource;
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this.tbProductData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.XRTableCell tcUnitPrice;
        private DevExpress.XtraReports.UI.XRTable tbProductData;
        private DevExpress.XtraReports.UI.XRTableRow trProductData;
        private DevExpress.XtraReports.UI.XRTableCell tcProductName;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsInStock;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsOnOrder;
        private DevExpress.XtraReports.UI.XRTableCell tcDiscont;
        private DevExpress.XtraReports.UI.XRCheckBox cbDiscont;
        private DevExpress.XtraReports.UI.XRLabel lbHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsOnOrderHeader;
        private DevExpress.XtraReports.UI.XRTableRow trProductHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcProductNameHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitPriceHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcUnitsInStockHeader;
        private DevExpress.XtraReports.UI.XRTableCell tcDiscontHeader;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeaderTitle;
        private DevExpress.XtraReports.UI.XRTable tbProductHeader;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.DataAccess.Sql.SqlDataSource nwindDataSource;

    }
}
