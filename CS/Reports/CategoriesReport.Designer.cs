namespace T132094 {
    partial class CategoriesReport {
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
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoriesReport));
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbHeader = new DevExpress.XtraReports.UI.XRLabel();
            this.lbDescription = new DevExpress.XtraReports.UI.XRLabel();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.pbPicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.lbCategoryName = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.nwindDataSource = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHeader});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new DevExpress.Drawing.DXFont("Times New Roman", 36F);
            this.lbHeader.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbHeader.SizeF = new System.Drawing.SizeF(650.0001F, 79.99998F);
            this.lbHeader.StylePriority.UseFont = false;
            this.lbHeader.StylePriority.UseTextAlignment = false;
            this.lbHeader.Text = "Categories Report";
            this.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lbDescription
            // 
            this.lbDescription.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Description]")});
            this.lbDescription.Font = new DevExpress.Drawing.DXFont("Times New Roman", 14F);
            this.lbDescription.LocationFloat = new DevExpress.Utils.PointFloat(220F, 53.08332F);
            this.lbDescription.Multiline = true;
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDescription.SizeF = new System.Drawing.SizeF(430F, 56.91668F);
            this.lbDescription.StylePriority.UseFont = false;
            this.lbDescription.Text = "lbDescription";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbDescription,
            this.pbPicture,
            this.lbCategoryName});
            this.Detail.HeightF = 110F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // pbPicture
            // 
            this.pbPicture.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "ImageSource", "[Picture]")});
            this.pbPicture.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.SizeF = new System.Drawing.SizeF(200F, 100F);
            this.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[CategoryName]")});
            this.lbCategoryName.Font = new DevExpress.Drawing.DXFont("Times New Roman", 16F, DevExpress.Drawing.DXFontStyle.Bold);
            this.lbCategoryName.LocationFloat = new DevExpress.Utils.PointFloat(220F, 10.00001F);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCategoryName.SizeF = new System.Drawing.SizeF(430F, 32F);
            this.lbCategoryName.StylePriority.UseFont = false;
            this.lbCategoryName.Text = "lbCategoryName";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nwindDataSource
            // 
            this.nwindDataSource.ConnectionName = "nwindConnection";
            this.nwindDataSource.Name = "nwindDataSource";
            columnExpression1.ColumnName = "CategoryID";
            table1.Name = "Categories";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "CategoryName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "Description";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "Picture";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Name = "Categories";
            selectQuery1.Tables.Add(table1);
            this.nwindDataSource.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.nwindDataSource.ResultSchemaSerializable = resources.GetString("nwindDataSource.ResultSchemaSerializable");
            // 
            // CategoriesReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataMember = "Categories";
            this.DataSource = this.nwindDataSource;
            this.Version = "20.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel lbHeader;
        private DevExpress.XtraReports.UI.XRLabel lbDescription;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRPictureBox pbPicture;
        private DevExpress.XtraReports.UI.XRLabel lbCategoryName;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource nwindDataSource;

    }
}
