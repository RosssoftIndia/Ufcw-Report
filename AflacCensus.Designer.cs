namespace Reports
{
    partial class AflacCensus
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.firstNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.lastNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sSNCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_AddressCaptionTextBox = new Telerik.Reporting.TextBox();
            this.birthDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.waitingPeriodCaptionTextBox = new Telerik.Reporting.TextBox();
            this.shopCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_CityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.firstNameDataTextBox = new Telerik.Reporting.TextBox();
            this.lastNameDataTextBox = new Telerik.Reporting.TextBox();
            this.sSNDataTextBox = new Telerik.Reporting.TextBox();
            this.birthDateDataTextBox = new Telerik.Reporting.TextBox();
            this.waitingPeriodDataTextBox = new Telerik.Reporting.TextBox();
            this.shopDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_CityDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_AddressDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "SELECT        FirstName, LastName, SSN, Pri_Address, Pri_City, BirthDate, Shop, W" +
                "aitingPeriod\r\nFROM            AflacCensus";
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.firstNameCaptionTextBox,
            this.lastNameCaptionTextBox,
            this.sSNCaptionTextBox,
            this.pri_AddressCaptionTextBox,
            this.birthDateCaptionTextBox,
            this.waitingPeriodCaptionTextBox,
            this.shopCaptionTextBox,
            this.pri_CityCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelsGroupHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.labelsGroupHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // firstNameCaptionTextBox
            // 
            this.firstNameCaptionTextBox.CanGrow = true;
            this.firstNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.firstNameCaptionTextBox.Name = "firstNameCaptionTextBox";
            this.firstNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.firstNameCaptionTextBox.StyleName = "Caption";
            this.firstNameCaptionTextBox.Value = "First Name";
            // 
            // lastNameCaptionTextBox
            // 
            this.lastNameCaptionTextBox.CanGrow = true;
            this.lastNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2000789642333984), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameCaptionTextBox.Name = "lastNameCaptionTextBox";
            this.lastNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999213695526123), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.lastNameCaptionTextBox.StyleName = "Caption";
            this.lastNameCaptionTextBox.Value = "Last Name";
            // 
            // sSNCaptionTextBox
            // 
            this.sSNCaptionTextBox.CanGrow = true;
            this.sSNCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4000792503356934), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.sSNCaptionTextBox.Name = "sSNCaptionTextBox";
            this.sSNCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8998419046401978), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.sSNCaptionTextBox.StyleName = "Caption";
            this.sSNCaptionTextBox.Value = "SSN";
            // 
            // pri_AddressCaptionTextBox
            // 
            this.pri_AddressCaptionTextBox.CanGrow = true;
            this.pri_AddressCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.2999997138977051), Telerik.Reporting.Drawing.Unit.Inch(7.9472862068996619E-08));
            this.pri_AddressCaptionTextBox.Name = "pri_AddressCaptionTextBox";
            this.pri_AddressCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999213695526123), Telerik.Reporting.Drawing.Unit.Inch(0.281210333108902));
            this.pri_AddressCaptionTextBox.StyleName = "Caption";
            this.pri_AddressCaptionTextBox.Value = "Pri_Address";
            // 
            // birthDateCaptionTextBox
            // 
            this.birthDateCaptionTextBox.CanGrow = true;
            this.birthDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.40000057220459), Telerik.Reporting.Drawing.Unit.Inch(7.9472862068996619E-08));
            this.birthDateCaptionTextBox.Name = "birthDateCaptionTextBox";
            this.birthDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999996185302734), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.birthDateCaptionTextBox.StyleName = "Caption";
            this.birthDateCaptionTextBox.Value = "Birth Date";
            // 
            // waitingPeriodCaptionTextBox
            // 
            this.waitingPeriodCaptionTextBox.CanGrow = true;
            this.waitingPeriodCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.000079154968262), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.waitingPeriodCaptionTextBox.Name = "waitingPeriodCaptionTextBox";
            this.waitingPeriodCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3998826742172241), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.waitingPeriodCaptionTextBox.StyleName = "Caption";
            this.waitingPeriodCaptionTextBox.Value = "Waiting Period";
            // 
            // shopCaptionTextBox
            // 
            this.shopCaptionTextBox.CanGrow = true;
            this.shopCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.800079345703125), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopCaptionTextBox.Name = "shopCaptionTextBox";
            this.shopCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999213695526123), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.shopCaptionTextBox.StyleName = "Caption";
            this.shopCaptionTextBox.Value = "Shop";
            // 
            // pri_CityCaptionTextBox
            // 
            this.pri_CityCaptionTextBox.CanGrow = true;
            this.pri_CityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.5), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_CityCaptionTextBox.Name = "pri_CityCaptionTextBox";
            this.pri_CityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999214172363281), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.pri_CityCaptionTextBox.StyleName = "Caption";
            this.pri_CityCaptionTextBox.Value = "Pri_City";
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.labelsGroupFooter.Name = "labelsGroupFooter";
            this.labelsGroupFooter.Style.Visible = false;
            // 
            // labelsGroup
            // 
            this.labelsGroup.GroupFooter = this.labelsGroupFooter;
            this.labelsGroup.GroupHeader = this.labelsGroupHeader;
            this.labelsGroup.Name = "labelsGroup";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.20000004768371582);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264), Telerik.Reporting.Drawing.Unit.Inch(0.20000003278255463));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.textBox1,
            this.textBox2});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.reportHeader.Style.Color = System.Drawing.Color.Maroon;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.5000004768371582), Telerik.Reporting.Drawing.Unit.Inch(0.78740161657333374));
            this.titleTextBox.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.titleTextBox.Style.Color = System.Drawing.Color.Maroon;
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "UFCW Local 312 Health Fund - AflacCensus";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.202044486999512), Telerik.Reporting.Drawing.Unit.Inch(0.42083334922790527));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979160308837891), Telerik.Reporting.Drawing.Unit.Inch(0.38736215233802795));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Name = "Tahoma";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "Count : {Count(Fields.Shop)}";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.202044486999512), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264), Telerik.Reporting.Drawing.Unit.Inch(0.42075467109680176));
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.Font.Name = "Tahoma";
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.StyleName = "PageInfo";
            this.textBox2.Value = "=Today().ToString(\"MM-dd-yyyy\")";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.firstNameDataTextBox,
            this.lastNameDataTextBox,
            this.sSNDataTextBox,
            this.birthDateDataTextBox,
            this.waitingPeriodDataTextBox,
            this.shopDataTextBox,
            this.pri_CityDataTextBox,
            this.pri_AddressDataTextBox});
            this.detail.Name = "detail";
            this.detail.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // firstNameDataTextBox
            // 
            this.firstNameDataTextBox.CanGrow = true;
            this.firstNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.firstNameDataTextBox.Name = "firstNameDataTextBox";
            this.firstNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2000000476837158), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.firstNameDataTextBox.StyleName = "Data";
            this.firstNameDataTextBox.Value = "=Fields.FirstName";
            // 
            // lastNameDataTextBox
            // 
            this.lastNameDataTextBox.CanGrow = true;
            this.lastNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.2000789642333984), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameDataTextBox.Name = "lastNameDataTextBox";
            this.lastNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999213695526123), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.lastNameDataTextBox.StyleName = "Data";
            this.lastNameDataTextBox.Value = "=Fields.LastName";
            // 
            // sSNDataTextBox
            // 
            this.sSNDataTextBox.CanGrow = true;
            this.sSNDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4000792503356934), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.sSNDataTextBox.Name = "sSNDataTextBox";
            this.sSNDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8998419046401978), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.sSNDataTextBox.StyleName = "Data";
            this.sSNDataTextBox.Value = "= IIf(IsNull(Fields.SSN,0)>0,Substr(Fields.SSN,0,3)+\"-\"+Substr(Fields.SSN,3,2)+\"-" +
                "\"+Substr(Fields.SSN,5,4),\"\") ";
            // 
            // birthDateDataTextBox
            // 
            this.birthDateDataTextBox.CanGrow = true;
            this.birthDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.400001525878906), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.birthDateDataTextBox.Name = "birthDateDataTextBox";
            this.birthDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999996185302734), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.birthDateDataTextBox.StyleName = "Data";
            this.birthDateDataTextBox.Value = "=Fields.BirthDate";
            // 
            // waitingPeriodDataTextBox
            // 
            this.waitingPeriodDataTextBox.CanGrow = true;
            this.waitingPeriodDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.000080108642578), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.waitingPeriodDataTextBox.Name = "waitingPeriodDataTextBox";
            this.waitingPeriodDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3998813629150391), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.waitingPeriodDataTextBox.StyleName = "Data";
            this.waitingPeriodDataTextBox.Value = "=Fields.WaitingPeriod";
            // 
            // shopDataTextBox
            // 
            this.shopDataTextBox.CanGrow = true;
            this.shopDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.800079345703125), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopDataTextBox.Name = "shopDataTextBox";
            this.shopDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999213695526123), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.shopDataTextBox.StyleName = "Data";
            this.shopDataTextBox.Value = "=Fields.Shop";
            // 
            // pri_CityDataTextBox
            // 
            this.pri_CityDataTextBox.CanGrow = true;
            this.pri_CityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.5000009536743164), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_CityDataTextBox.Name = "pri_CityDataTextBox";
            this.pri_CityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999214172363281), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.pri_CityDataTextBox.StyleName = "Data";
            this.pri_CityDataTextBox.Value = "=Fields.Pri_City";
            // 
            // pri_AddressDataTextBox
            // 
            this.pri_AddressDataTextBox.CanGrow = true;
            this.pri_AddressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.30000114440918), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.pri_AddressDataTextBox.Name = "pri_AddressDataTextBox";
            this.pri_AddressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999201774597168), Telerik.Reporting.Drawing.Unit.Inch(0.28117123246192932));
            this.pri_AddressDataTextBox.StyleName = "Data";
            this.pri_AddressDataTextBox.Value = "=Fields.Pri_Address";
            // 
            // AflacCensus
            // 
            this.DataSource = this.sqlDataSource1;
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.labelsGroup});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeader,
            this.labelsGroupFooter,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "ReportAflacCensus";
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(1);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(1);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(1);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(1);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.Black;
            styleRule1.Style.Font.Bold = true;
            styleRule1.Style.Font.Italic = false;
            styleRule1.Style.Font.Name = "Tahoma";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18);
            styleRule1.Style.Font.Strikeout = false;
            styleRule1.Style.Font.Underline = false;
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(15.400001525878906);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox firstNameCaptionTextBox;
        private Telerik.Reporting.TextBox lastNameCaptionTextBox;
        private Telerik.Reporting.TextBox sSNCaptionTextBox;
        private Telerik.Reporting.TextBox pri_AddressCaptionTextBox;
        private Telerik.Reporting.TextBox pri_CityCaptionTextBox;
        private Telerik.Reporting.TextBox birthDateCaptionTextBox;
        private Telerik.Reporting.TextBox shopCaptionTextBox;
        private Telerik.Reporting.TextBox waitingPeriodCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox firstNameDataTextBox;
        private Telerik.Reporting.TextBox lastNameDataTextBox;
        private Telerik.Reporting.TextBox sSNDataTextBox;
        private Telerik.Reporting.TextBox pri_AddressDataTextBox;
        private Telerik.Reporting.TextBox pri_CityDataTextBox;
        private Telerik.Reporting.TextBox birthDateDataTextBox;
        private Telerik.Reporting.TextBox shopDataTextBox;
        private Telerik.Reporting.TextBox waitingPeriodDataTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;

    }
}