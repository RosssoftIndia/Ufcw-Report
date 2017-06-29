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
            this.detail.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0.10000000149011612);
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(2);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nameDataTextBox,
            this.pri_AddressDataTextBox,
            this.pri_CityDataTextBox,
            this.pri_StateDataTextBox});
            this.detail.Name = "detail";
            this.detail.Style.BorderStyle.Default = Telerik.Reporting.Drawing.BorderType.None;
            // 
            // nameDataTextBox
            // 
            this.nameDataTextBox.CanGrow = false;
            this.nameDataTextBox.CanShrink = true;
            this.nameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000002384185791), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224));
            this.nameDataTextBox.Name = "nameDataTextBox";
            this.nameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7999999523162842), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448));
            this.nameDataTextBox.Value = "=Fields.Name";
            // 
            // pri_AddressDataTextBox
            // 
            this.pri_AddressDataTextBox.CanGrow = false;
            this.pri_AddressDataTextBox.CanShrink = true;
            this.pri_AddressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000002384185791), Telerik.Reporting.Drawing.Unit.Inch(0.60000002384185791));
            this.pri_AddressDataTextBox.Name = "pri_AddressDataTextBox";
            this.pri_AddressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7999999523162842), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448));
            this.pri_AddressDataTextBox.Value = "=Fields.Pri_Address";
            // 
            // pri_CityDataTextBox
            // 
            this.pri_CityDataTextBox.CanGrow = false;
            this.pri_CityDataTextBox.CanShrink = true;
            this.pri_CityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000002384185791), Telerik.Reporting.Drawing.Unit.Inch(1));
            this.pri_CityDataTextBox.Name = "pri_CityDataTextBox";
            this.pri_CityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7999999523162842), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448));
            this.pri_CityDataTextBox.Value = "=Fields.Pri_City + \' \' + Fields.Pri_State";
            // 
            // pri_StateDataTextBox
            // 
            this.pri_StateDataTextBox.CanGrow = false;
            this.pri_StateDataTextBox.CanShrink = true;
            this.pri_StateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.10000002384185791), Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421));
            this.pri_StateDataTextBox.Name = "pri_StateDataTextBox";
            this.pri_StateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.7999999523162842), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448));
            this.pri_StateDataTextBox.Value = "=Fields.Pri_Zip";
            // 
            // ShopLable
            // 
            this.DataSource = this.sqlDataSource1;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "ShopLabelNew";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0.49960631132125854);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(0.5);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(4);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox nameDataTextBox;
        private Telerik.Reporting.TextBox pri_AddressDataTextBox;
        private Telerik.Reporting.TextBox pri_CityDataTextBox;
        private Telerik.Reporting.TextBox pri_StateDataTextBox;
    }
}