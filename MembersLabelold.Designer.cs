namespace Reports
{
    partial class MembersLabelold
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
            this.pri_CityDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.pageHeaderSection1 = new Telerik.Reporting.PageHeaderSection();
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
            this.detail.ColumnSpacing = Telerik.Reporting.Drawing.Unit.Mm(2.5);
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Mm(25.400001525878906);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nameDataTextBox,
            this.pri_CityDataTextBox,
            this.textBox1,
            this.textBox3});
            this.detail.Name = "detail";
            // 
            // nameDataTextBox
            // 
            this.nameDataTextBox.CanGrow = false;
            this.nameDataTextBox.CanShrink = false;
            this.nameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.nameDataTextBox.Name = "nameDataTextBox";
            this.nameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224));
            this.nameDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.nameDataTextBox.Value = "=Fields.Name ";
            // 
            // pri_CityDataTextBox
            // 
            this.pri_CityDataTextBox.CanGrow = false;
            this.pri_CityDataTextBox.CanShrink = false;
            this.pri_CityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448));
            this.pri_CityDataTextBox.Name = "pri_CityDataTextBox";
            this.pri_CityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224));
            this.pri_CityDataTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.pri_CityDataTextBox.Value = "= Fields.MergedAddress";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05), Telerik.Reporting.Drawing.Unit.Inch(0.7000001072883606));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.59996062517166138), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224));
            this.textBox1.Style.Visible = false;
            this.textBox1.Value = "= Fields.Shop";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = false;
            this.textBox3.CanShrink = false;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4), Telerik.Reporting.Drawing.Unit.Inch(0.20000000298023224));
            this.textBox3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox3.Value = "=Fields.Pri_Address";
            // 
            // pageHeaderSection1
            // 
            this.pageHeaderSection1.Height = Telerik.Reporting.Drawing.Unit.Inch(2.3000001907348633);
            this.pageHeaderSection1.Name = "pageHeaderSection1";
            // 
            // MembersLabelold
            // 
            this.DataSource = this.sqlDataSource1;
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.detail,
            this.pageHeaderSection1});
            this.Name = "MembersLabel";
            this.PageSettings.Landscape = false;
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Mm(23.190004348754883);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Mm(16.5);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Mm(10.589998245239258);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Mm(20);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            this.Width = Telerik.Reporting.Drawing.Unit.Mm(101.59999847412109);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox nameDataTextBox;
        private Telerik.Reporting.TextBox pri_CityDataTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.PageHeaderSection pageHeaderSection1;

    }
}