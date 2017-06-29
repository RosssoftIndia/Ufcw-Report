namespace Reports
{
    partial class HealthBenefitReport
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.Reporting.ReportParameter reportParameter1 = new Telerik.Reporting.ReportParameter();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.sqlDataSource1 = new Telerik.Reporting.SqlDataSource();
            this.labelsGroupHeader = new Telerik.Reporting.GroupHeaderSection();
            this.firstNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.memberIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.shopIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sSNCaptionTextBox = new Telerik.Reporting.TextBox();
            this.terminatedDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.waitingPeriodCaptionTextBox = new Telerik.Reporting.TextBox();
            this.benefitNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.shopCaptionTextBox = new Telerik.Reporting.TextBox();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.firstNameDataTextBox = new Telerik.Reporting.TextBox();
            this.memberIDDataTextBox = new Telerik.Reporting.TextBox();
            this.shopDataTextBox = new Telerik.Reporting.TextBox();
            this.terminatedDateDataTextBox = new Telerik.Reporting.TextBox();
            this.benefitNameDataTextBox = new Telerik.Reporting.TextBox();
            this.waitingPeriodDataTextBox = new Telerik.Reporting.TextBox();
            this.sSNDataTextBox = new Telerik.Reporting.TextBox();
            this.shopIDDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] {
            new Telerik.Reporting.SqlDataSourceParameter("@Benefit", System.Data.DbType.String, "=Parameters.Benefit.Value")});
            this.sqlDataSource1.SelectCommand = "dbo.HealthBenefitReport_Sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30200439691543579D);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.firstNameCaptionTextBox,
            this.memberIDCaptionTextBox,
            this.shopIDCaptionTextBox,
            this.sSNCaptionTextBox,
            this.terminatedDateCaptionTextBox,
            this.waitingPeriodCaptionTextBox,
            this.benefitNameCaptionTextBox,
            this.shopCaptionTextBox,
            this.textBox2});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelsGroupHeader.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelsGroupHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.labelsGroupHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // firstNameCaptionTextBox
            // 
            this.firstNameCaptionTextBox.CanGrow = true;
            this.firstNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.firstNameCaptionTextBox.Name = "firstNameCaptionTextBox";
            this.firstNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D));
            this.firstNameCaptionTextBox.StyleName = "Caption";
            this.firstNameCaptionTextBox.Value = "First Name";
            // 
            // memberIDCaptionTextBox
            // 
            this.memberIDCaptionTextBox.CanGrow = true;
            this.memberIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.9000787734985352D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.memberIDCaptionTextBox.Name = "memberIDCaptionTextBox";
            this.memberIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D));
            this.memberIDCaptionTextBox.StyleName = "Caption";
            this.memberIDCaptionTextBox.Value = "Member ID";
            // 
            // shopIDCaptionTextBox
            // 
            this.shopIDCaptionTextBox.CanGrow = true;
            this.shopIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.shopIDCaptionTextBox.Name = "shopIDCaptionTextBox";
            this.shopIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999994039535523D), Telerik.Reporting.Drawing.Unit.Inch(0.30200439691543579D));
            this.shopIDCaptionTextBox.StyleName = "Caption";
            this.shopIDCaptionTextBox.Value = "Shop ID";
            // 
            // sSNCaptionTextBox
            // 
            this.sSNCaptionTextBox.CanGrow = true;
            this.sSNCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.sSNCaptionTextBox.Name = "sSNCaptionTextBox";
            this.sSNCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7998428344726563D), Telerik.Reporting.Drawing.Unit.Inch(0.30200439691543579D));
            this.sSNCaptionTextBox.StyleName = "Caption";
            this.sSNCaptionTextBox.Value = "SSN";
            // 
            // terminatedDateCaptionTextBox
            // 
            this.terminatedDateCaptionTextBox.CanGrow = true;
            this.terminatedDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.800000190734863D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.terminatedDateCaptionTextBox.Name = "terminatedDateCaptionTextBox";
            this.terminatedDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5999208688735962D), Telerik.Reporting.Drawing.Unit.Inch(0.30200439691543579D));
            this.terminatedDateCaptionTextBox.StyleName = "Caption";
            this.terminatedDateCaptionTextBox.Value = "Terminated Date";
            // 
            // waitingPeriodCaptionTextBox
            // 
            this.waitingPeriodCaptionTextBox.CanGrow = true;
            this.waitingPeriodCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.399999618530273D), Telerik.Reporting.Drawing.Unit.Inch(7.9472862068996619E-08D));
            this.waitingPeriodCaptionTextBox.Name = "waitingPeriodCaptionTextBox";
            this.waitingPeriodCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D));
            this.waitingPeriodCaptionTextBox.StyleName = "Caption";
            this.waitingPeriodCaptionTextBox.Value = "Waiting Period";
            // 
            // benefitNameCaptionTextBox
            // 
            this.benefitNameCaptionTextBox.CanGrow = true;
            this.benefitNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.400076866149902D), Telerik.Reporting.Drawing.Unit.Inch(7.9472862068996619E-08D));
            this.benefitNameCaptionTextBox.Name = "benefitNameCaptionTextBox";
            this.benefitNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999637603759766D), Telerik.Reporting.Drawing.Unit.Inch(0.3020043671131134D));
            this.benefitNameCaptionTextBox.StyleName = "Caption";
            this.benefitNameCaptionTextBox.Value = "Benefit Name";
            // 
            // shopCaptionTextBox
            // 
            this.shopCaptionTextBox.CanGrow = true;
            this.shopCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.shopCaptionTextBox.Name = "shopCaptionTextBox";
            this.shopCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2D), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D));
            this.shopCaptionTextBox.StyleName = "Caption";
            this.shopCaptionTextBox.Value = "Shop";
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
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
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999605417251587D), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.textBox1,
            this.currentTimeTextBox});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.reportHeader.Style.Color = System.Drawing.Color.Maroon;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(6.9039688110351562D), Telerik.Reporting.Drawing.Unit.Inch(0.78740161657333374D));
            this.titleTextBox.Style.Color = System.Drawing.Color.Maroon;
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "UFCW Local 312 Health Fund - Health Benefits Report";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.004168510437012D), Telerik.Reporting.Drawing.Unit.Inch(0.3999999463558197D));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.3958733081817627D), Telerik.Reporting.Drawing.Unit.Inch(0.40819564461708069D));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Name = "Tahoma";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.Value = "Count : {Count(Fields.BenefitName)}";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.004168510437012D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.3958346843719482D), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448D));
            this.currentTimeTextBox.Style.Font.Bold = true;
            this.currentTimeTextBox.Style.Font.Name = "Tahoma";
            this.currentTimeTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            this.currentTimeTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.currentTimeTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "= Today().ToString(\"MM-dd-yyyy\")";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30204397439956665D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.firstNameDataTextBox,
            this.terminatedDateDataTextBox,
            this.benefitNameDataTextBox,
            this.waitingPeriodDataTextBox,
            this.sSNDataTextBox,
            this.textBox3,
            this.shopIDDataTextBox,
            this.shopDataTextBox,
            this.memberIDDataTextBox});
            this.detail.Name = "detail";
            this.detail.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.detail.Style.Color = System.Drawing.Color.Black;
            this.detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // firstNameDataTextBox
            // 
            this.firstNameDataTextBox.CanGrow = true;
            this.firstNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.firstNameDataTextBox.Name = "firstNameDataTextBox";
            this.firstNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D));
            this.firstNameDataTextBox.StyleName = "Data";
            this.firstNameDataTextBox.Value = "=Fields.FirstName";
            // 
            // memberIDDataTextBox
            // 
            this.memberIDDataTextBox.CanGrow = true;
            this.memberIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.9000787734985352D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.memberIDDataTextBox.Name = "memberIDDataTextBox";
            this.memberIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0999999046325684D), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D));
            this.memberIDDataTextBox.StyleName = "Data";
            this.memberIDDataTextBox.Value = "=Fields.MemberID";
            // 
            // shopDataTextBox
            // 
            this.shopDataTextBox.CanGrow = true;
            this.shopDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.shopDataTextBox.Name = "shopDataTextBox";
            this.shopDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2D), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D));
            this.shopDataTextBox.StyleName = "Data";
            this.shopDataTextBox.Value = "=Fields.Shop";
            // 
            // terminatedDateDataTextBox
            // 
            this.terminatedDateDataTextBox.CanGrow = true;
            this.terminatedDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.800000190734863D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.terminatedDateDataTextBox.Name = "terminatedDateDataTextBox";
            this.terminatedDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5999208688735962D), Telerik.Reporting.Drawing.Unit.Inch(0.29162731766700745D));
            this.terminatedDateDataTextBox.StyleName = "Data";
            this.terminatedDateDataTextBox.Value = "=Fields.TerminatedDate";
            // 
            // benefitNameDataTextBox
            // 
            this.benefitNameDataTextBox.CanGrow = true;
            this.benefitNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.400077819824219D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.benefitNameDataTextBox.Name = "benefitNameDataTextBox";
            this.benefitNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999637603759766D), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773D));
            this.benefitNameDataTextBox.StyleName = "Data";
            this.benefitNameDataTextBox.Value = "=Fields.BenefitName";
            // 
            // waitingPeriodDataTextBox
            // 
            this.waitingPeriodDataTextBox.CanGrow = true;
            this.waitingPeriodDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.399999618530273D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.waitingPeriodDataTextBox.Name = "waitingPeriodDataTextBox";
            this.waitingPeriodDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1D), Telerik.Reporting.Drawing.Unit.Inch(0.3019651472568512D));
            this.waitingPeriodDataTextBox.StyleName = "Data";
            this.waitingPeriodDataTextBox.Value = "=Fields.WaitingPeriod";
            // 
            // sSNDataTextBox
            // 
            this.sSNDataTextBox.CanGrow = true;
            this.sSNDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.sSNDataTextBox.Name = "sSNDataTextBox";
            this.sSNDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7998428344726563D), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773D));
            this.sSNDataTextBox.StyleName = "Data";
            this.sSNDataTextBox.Value = "=IIf(IsNull(Fields.SSN,0)>0,Substr(Fields.SSN,0,3)+\"-\"+Substr(Fields.SSN,3,2)+\"-\"" +
    "+Substr(Fields.SSN,5,4),\"\") ";
            // 
            // shopIDDataTextBox
            // 
            this.shopIDDataTextBox.CanGrow = true;
            this.shopIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.shopIDDataTextBox.Name = "shopIDDataTextBox";
            this.shopIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9999994039535523D), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773D));
            this.shopIDDataTextBox.StyleName = "Data";
            this.shopIDDataTextBox.Value = "=Fields.ShopID";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5D), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D));
            this.textBox2.StyleName = "Caption";
            this.textBox2.Value = "Last Name";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421D), Telerik.Reporting.Drawing.Unit.Inch(0D));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5D), Telerik.Reporting.Drawing.Unit.Inch(0.30000001192092896D));
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "= Fields.LastName";
            // 
            // HealthBenefitReport
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
            this.Name = "Health_Benefit_Reports";
            this.PageSettings.Margins.Bottom = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Left = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Right = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.Margins.Top = Telerik.Reporting.Drawing.Unit.Inch(1D);
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Letter;
            reportParameter1.Name = "Benefit";
            reportParameter1.Text = "Benefit";
            reportParameter1.Value = "@Benefit";
            this.ReportParameters.Add(reportParameter1);
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.Black;
            styleRule1.Style.Font.Bold = true;
            styleRule1.Style.Font.Italic = false;
            styleRule1.Style.Font.Name = "Tahoma";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule1.Style.Font.Strikeout = false;
            styleRule1.Style.Font.Underline = false;
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.Color = System.Drawing.Color.Black;
            styleRule2.Style.Font.Name = "Tahoma";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Font.Name = "Tahoma";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Font.Name = "Tahoma";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(15.400042533874512D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox firstNameCaptionTextBox;
        private Telerik.Reporting.TextBox memberIDCaptionTextBox;
        private Telerik.Reporting.TextBox shopCaptionTextBox;
        private Telerik.Reporting.TextBox shopIDCaptionTextBox;
        private Telerik.Reporting.TextBox sSNCaptionTextBox;
        private Telerik.Reporting.TextBox terminatedDateCaptionTextBox;
        private Telerik.Reporting.TextBox waitingPeriodCaptionTextBox;
        private Telerik.Reporting.TextBox benefitNameCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox firstNameDataTextBox;
        private Telerik.Reporting.TextBox memberIDDataTextBox;
        private Telerik.Reporting.TextBox shopDataTextBox;
        private Telerik.Reporting.TextBox shopIDDataTextBox;
        private Telerik.Reporting.TextBox sSNDataTextBox;
        private Telerik.Reporting.TextBox terminatedDateDataTextBox;
        private Telerik.Reporting.TextBox waitingPeriodDataTextBox;
        private Telerik.Reporting.TextBox benefitNameDataTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
    }
}