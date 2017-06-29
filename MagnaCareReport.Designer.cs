namespace Reports
{
    partial class MagnaCareReport
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
            this.benefitsCaptionTextBox = new Telerik.Reporting.TextBox();
            this.memDepCountCaptionTextBox = new Telerik.Reporting.TextBox();
            this.membersCountCaptionTextBox = new Telerik.Reporting.TextBox();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.benefitsDataTextBox = new Telerik.Reporting.TextBox();
            this.memDepCountDataTextBox = new Telerik.Reporting.TextBox();
            this.membersCountDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.Magnacarereport_sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.benefitsCaptionTextBox,
            this.memDepCountCaptionTextBox,
            this.membersCountCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelsGroupHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.labelsGroupHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // benefitsCaptionTextBox
            // 
            this.benefitsCaptionTextBox.CanGrow = true;
            this.benefitsCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.benefitsCaptionTextBox.Name = "benefitsCaptionTextBox";
            this.benefitsCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6000003814697266), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.benefitsCaptionTextBox.StyleName = "Caption";
            this.benefitsCaptionTextBox.Value = "Benefits";
            // 
            // memDepCountCaptionTextBox
            // 
            this.memDepCountCaptionTextBox.CanGrow = true;
            this.memDepCountCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.90000057220459), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.memDepCountCaptionTextBox.Name = "memDepCountCaptionTextBox";
            this.memDepCountCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.50204610824585), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.memDepCountCaptionTextBox.StyleName = "Caption";
            this.memDepCountCaptionTextBox.Value = "Members + Dependent Count";
            // 
            // membersCountCaptionTextBox
            // 
            this.membersCountCaptionTextBox.CanGrow = true;
            this.membersCountCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.60007905960083), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.membersCountCaptionTextBox.Name = "membersCountCaptionTextBox";
            this.membersCountCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.2998414039611816), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.membersCountCaptionTextBox.StyleName = "Caption";
            this.membersCountCaptionTextBox.Value = "Members Count";
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
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264), Telerik.Reporting.Drawing.Unit.Inch(0.281171053647995));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.82898944616317749);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.textBox1});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.reportHeader.Style.Color = System.Drawing.Color.Maroon;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6000003814697266), Telerik.Reporting.Drawing.Unit.Inch(0.82898944616317749));
            this.titleTextBox.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.titleTextBox.Style.Color = System.Drawing.Color.Maroon;
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "UFCW Local 312 Health Fund - MagnaCare";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.100001335144043), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.3020451068878174), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Name = "Tahoma";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.StyleName = "PageInfo";
            this.textBox1.Value = "= Today().ToString(\"MM-dd-yyyy\")";
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
            this.benefitsDataTextBox,
            this.memDepCountDataTextBox,
            this.membersCountDataTextBox});
            this.detail.Name = "detail";
            this.detail.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // benefitsDataTextBox
            // 
            this.benefitsDataTextBox.CanGrow = true;
            this.benefitsDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.benefitsDataTextBox.Name = "benefitsDataTextBox";
            this.benefitsDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6000003814697266), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.benefitsDataTextBox.StyleName = "Data";
            this.benefitsDataTextBox.Value = "=Fields.Benefits";
            // 
            // memDepCountDataTextBox
            // 
            this.memDepCountDataTextBox.CanGrow = true;
            this.memDepCountDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.90000057220459), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.memDepCountDataTextBox.Name = "memDepCountDataTextBox";
            this.memDepCountDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.50204610824585), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.memDepCountDataTextBox.StyleName = "Data";
            this.memDepCountDataTextBox.Value = "=Fields.MemDepCount";
            // 
            // membersCountDataTextBox
            // 
            this.membersCountDataTextBox.CanGrow = true;
            this.membersCountDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.60007905960083), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.membersCountDataTextBox.Name = "membersCountDataTextBox";
            this.membersCountDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.2998404502868652), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.membersCountDataTextBox.StyleName = "Data";
            this.membersCountDataTextBox.Value = "=Fields.MembersCount";
            // 
            // MagnaCareReport
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
            this.Name = "MagnaCareReport";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(15.402085304260254);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox benefitsCaptionTextBox;
        private Telerik.Reporting.TextBox membersCountCaptionTextBox;
        private Telerik.Reporting.TextBox memDepCountCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox benefitsDataTextBox;
        private Telerik.Reporting.TextBox membersCountDataTextBox;
        private Telerik.Reporting.TextBox memDepCountDataTextBox;
        private Telerik.Reporting.TextBox textBox1;

    }
}