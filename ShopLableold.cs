namespace Reports
{
    partial class ShopLable
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.detail = new Telerik.Reporting.DetailSection();
            this.nameDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_AddressDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_CityDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_StateDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_ZipDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.ShopLable_Sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // detail
            // 
            this.detail.ColumnCount = 2;
            this.detail.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Mm(2.5);
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Mm(42.299999237060547);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nameDataTextBox,
            this.pri_AddressDataTextBox,
            this.pri_CityDataTextBox,
            this.pri_StateDataTextBox,
            this.pri_ZipDataTextBox});
            this.detail.Name = "detail";
            // 
            // nameDataTextBox
            // 
            this.nameDataTextBox.CanGrow = false;
            this.nameDataTextBox.CanShrink = false;
            this.nameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0.33267712593078613));
            this.nameDataTextBox.Name = "nameDataTextBox";
            this.nameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5511810779571533), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.nameDataTextBox.Value = "=Fields.Name";
            // 
            // pri_AddressDataTextBox
            // 
            this.pri_AddressDataTextBox.CanGrow = false;
            this.pri_AddressDataTextBox.CanShrink = false;
            this.pri_AddressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0.532677173614502));
            this.pri_AddressDataTextBox.Name = "pri_AddressDataTextBox";
            this.pri_AddressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5511810779571533), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.pri_AddressDataTextBox.Value = "=Fields.Pri_Address";
            // 
            // pri_CityDataTextBox
            // 
            this.pri_CityDataTextBox.CanGrow = false;
            this.pri_CityDataTextBox.CanShrink = false;
            this.pri_CityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0.732677161693573));
            this.pri_CityDataTextBox.Name = "pri_CityDataTextBox";
            this.pri_CityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5511810779571533), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.pri_CityDataTextBox.Value = "=Fields.Pri_City";
            // 
            // pri_StateDataTextBox
            // 
            this.pri_StateDataTextBox.CanGrow = false;
            this.pri_StateDataTextBox.CanShrink = false;
            this.pri_StateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0.93267720937728882));
            this.pri_StateDataTextBox.Name = "pri_StateDataTextBox";
            this.pri_StateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5511810779571533), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.pri_StateDataTextBox.Value = "=Fields.Pri_State";
            // 
            // pri_ZipDataTextBox
            // 
            this.pri_ZipDataTextBox.CanGrow = false;
            this.pri_ZipDataTextBox.CanShrink = false;
            this.pri_ZipDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(1.1326771974563599));
            this.pri_ZipDataTextBox.Name = "pri_ZipDataTextBox";
            this.pri_ZipDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.5511810779571533), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.pri_ZipDataTextBox.Style.Visible = true;
            this.pri_ZipDataTextBox.Value = "=Fields.Pri_Zip";
            // 
            // ShopLable
            // 
            this.DataSource = this.sqlDataSource1;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "ShopLable";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm(23.190004348754883);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm(16.5);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm(10.589998245239258);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm(20);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Width = Telerik.Reporting.Drawing.Unit.Mm(90.199996948242188);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox nameDataTextBox;
        private Telerik.Reporting.TextBox pri_AddressDataTextBox;
        private Telerik.Reporting.TextBox pri_CityDataTextBox;
        private Telerik.Reporting.TextBox pri_StateDataTextBox;
        private Telerik.Reporting.TextBox pri_ZipDataTextBox;

    }
}