namespace Reports
{
    partial class MembersLabelMin
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
            this.mergedAddressDataTextBox = new Telerik.Reporting.TextBox();
            this.shopDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.MembersLabel_Sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // detail
            // 
            this.detail.ColumnCount = 2;
            this.detail.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Inch(0.1875);
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(1);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nameDataTextBox,
            this.pri_AddressDataTextBox,
            this.mergedAddressDataTextBox,
            this.shopDataTextBox});
            this.detail.Name = "detail";
            // 
            // nameDataTextBox
            // 
            this.nameDataTextBox.CanGrow = false;
            this.nameDataTextBox.CanShrink = false;
            this.nameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926), Telerik.Reporting.Drawing.Unit.Inch(0.099999941885471344));
            this.nameDataTextBox.Name = "nameDataTextBox";
            this.nameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8801572322845459), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.nameDataTextBox.Value = "=Fields.Name";
            // 
            // pri_AddressDataTextBox
            // 
            this.pri_AddressDataTextBox.CanGrow = false;
            this.pri_AddressDataTextBox.CanShrink = false;
            this.pri_AddressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926), Telerik.Reporting.Drawing.Unit.Inch(0.29999998211860657));
            this.pri_AddressDataTextBox.Name = "pri_AddressDataTextBox";
            this.pri_AddressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8801572322845459), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.pri_AddressDataTextBox.Value = "=Fields.Pri_Address";
            // 
            // mergedAddressDataTextBox
            // 
            this.mergedAddressDataTextBox.CanGrow = false;
            this.mergedAddressDataTextBox.CanShrink = false;
            this.mergedAddressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926), Telerik.Reporting.Drawing.Unit.Inch(0.5));
            this.mergedAddressDataTextBox.Name = "mergedAddressDataTextBox";
            this.mergedAddressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.8801572322845459), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.mergedAddressDataTextBox.Value = "=Fields.MergedAddress";
            // 
            // shopDataTextBox
            // 
            this.shopDataTextBox.CanGrow = false;
            this.shopDataTextBox.CanShrink = false;
            this.shopDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.099999986588954926), Telerik.Reporting.Drawing.Unit.Inch(0.70000004768371582));
            this.shopDataTextBox.Name = "shopDataTextBox";
            this.shopDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5000001192092896), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.shopDataTextBox.Style.Visible = false;
            this.shopDataTextBox.Value = "=Fields.Shop";
            // 
            // MembersLabelMin
            // 
            this.DataSource = this.sqlDataSource1;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail});
            this.Name = "MembersLabelMin";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(0.49960631132125854);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(0.15210644900798798);
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
        private Telerik.Reporting.TextBox mergedAddressDataTextBox;
        private Telerik.Reporting.TextBox shopDataTextBox;
    }
}