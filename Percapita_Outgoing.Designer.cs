namespace Reports
{
    partial class Percapita_Outgoing
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
            this.localNumberCaptionTextBox = new Telerik.Reporting.TextBox();
            this.report_DateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sSNCaptionTextBox = new Telerik.Reporting.TextBox();
            this.firstNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.eventCodeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.initialCaptionTextBox = new Telerik.Reporting.TextBox();
            this.eventDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.lastNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.localNumberDataTextBox = new Telerik.Reporting.TextBox();
            this.report_DateDataTextBox = new Telerik.Reporting.TextBox();
            this.sSNDataTextBox = new Telerik.Reporting.TextBox();
            this.lastNameDataTextBox = new Telerik.Reporting.TextBox();
            this.initialDataTextBox = new Telerik.Reporting.TextBox();
            this.eventDateDataTextBox = new Telerik.Reporting.TextBox();
            this.eventCodeDataTextBox = new Telerik.Reporting.TextBox();
            this.firstNameDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.Percapita_outgoing_sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30204397439956665);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.localNumberCaptionTextBox,
            this.report_DateCaptionTextBox,
            this.sSNCaptionTextBox,
            this.firstNameCaptionTextBox,
            this.eventCodeCaptionTextBox,
            this.initialCaptionTextBox,
            this.eventDateCaptionTextBox,
            this.lastNameCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelsGroupHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            // 
            // localNumberCaptionTextBox
            // 
            this.localNumberCaptionTextBox.CanGrow = true;
            this.localNumberCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.localNumberCaptionTextBox.Name = "localNumberCaptionTextBox";
            this.localNumberCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6791666746139526), Telerik.Reporting.Drawing.Unit.Inch(0.30200472474098206));
            this.localNumberCaptionTextBox.StyleName = "Caption";
            this.localNumberCaptionTextBox.Value = "Local Number";
            // 
            // report_DateCaptionTextBox
            // 
            this.report_DateCaptionTextBox.CanGrow = true;
            this.report_DateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7000786066055298), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.report_DateCaptionTextBox.Name = "report_DateCaptionTextBox";
            this.report_DateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.30196529626846313));
            this.report_DateCaptionTextBox.StyleName = "Caption";
            this.report_DateCaptionTextBox.Value = "Report_Date";
            // 
            // sSNCaptionTextBox
            // 
            this.sSNCaptionTextBox.CanGrow = true;
            this.sSNCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4000787734985352), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.sSNCaptionTextBox.Name = "sSNCaptionTextBox";
            this.sSNCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999210119247437), Telerik.Reporting.Drawing.Unit.Inch(0.30200472474098206));
            this.sSNCaptionTextBox.StyleName = "Caption";
            this.sSNCaptionTextBox.Value = "SSN";
            // 
            // firstNameCaptionTextBox
            // 
            this.firstNameCaptionTextBox.CanGrow = true;
            this.firstNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.900078296661377), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.firstNameCaptionTextBox.Name = "firstNameCaptionTextBox";
            this.firstNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999210357666016), Telerik.Reporting.Drawing.Unit.Inch(0.30200472474098206));
            this.firstNameCaptionTextBox.StyleName = "Caption";
            this.firstNameCaptionTextBox.Value = "First Name";
            // 
            // eventCodeCaptionTextBox
            // 
            this.eventCodeCaptionTextBox.CanGrow = true;
            this.eventCodeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.400080680847168), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.eventCodeCaptionTextBox.Name = "eventCodeCaptionTextBox";
            this.eventCodeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999208211898804), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773));
            this.eventCodeCaptionTextBox.StyleName = "Caption";
            this.eventCodeCaptionTextBox.Value = "Event Code";
            // 
            // initialCaptionTextBox
            // 
            this.initialCaptionTextBox.CanGrow = true;
            this.initialCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.700078010559082), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.initialCaptionTextBox.Name = "initialCaptionTextBox";
            this.initialCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999225616455078), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773));
            this.initialCaptionTextBox.StyleName = "Caption";
            this.initialCaptionTextBox.Value = "Initial";
            // 
            // eventDateCaptionTextBox
            // 
            this.eventDateCaptionTextBox.CanGrow = true;
            this.eventDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.300079345703125), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.eventDateCaptionTextBox.Name = "eventDateCaptionTextBox";
            this.eventDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999214172363281), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773));
            this.eventDateCaptionTextBox.StyleName = "Caption";
            this.eventDateCaptionTextBox.Value = "Event Date";
            // 
            // lastNameCaptionTextBox
            // 
            this.lastNameCaptionTextBox.CanGrow = true;
            this.lastNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.1000785827636719), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameCaptionTextBox.Name = "lastNameCaptionTextBox";
            this.lastNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999210357666016), Telerik.Reporting.Drawing.Unit.Inch(0.30200472474098206));
            this.lastNameCaptionTextBox.StyleName = "Caption";
            this.lastNameCaptionTextBox.Value = "Last Name";
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
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.pageHeader.Name = "pageHeader";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.pageFooter.Name = "pageFooter";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.82898944616317749);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.textBox6,
            this.textBox8});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.reportHeader.Style.Color = System.Drawing.Color.Maroon;
            this.reportHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.reportHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.020833810791373253), Telerik.Reporting.Drawing.Unit.Inch(0.31874999403953552));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6791664361953735), Telerik.Reporting.Drawing.Unit.Inch(0.51016056537628174));
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "=Fields.LocalNumber";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4000790119171143), Telerik.Reporting.Drawing.Unit.Inch(0.31874999403953552));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999210119247437), Telerik.Reporting.Drawing.Unit.Inch(0.51019984483718872));
            this.textBox6.Style.Color = System.Drawing.Color.Maroon;
            this.textBox6.StyleName = "Caption";
            this.textBox6.Value = "OUTGOINGFILE";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7000789642333984), Telerik.Reporting.Drawing.Unit.Inch(0.31874999403953552));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.51019996404647827));
            this.textBox8.StyleName = "Data";
            this.textBox8.Value = "=Fields.Report_Date";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30200472474098206);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2,
            this.textBox3,
            this.textBox7});
            this.reportFooter.Name = "reportFooter";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6791664361953735), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773));
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "=Fields.LocalNumber";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7000786066055298), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "=Fields.Report_Date";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.1000785827636719), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox3.Name = "textBox1";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999213933944702), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773));
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "= Count(Fields.FirstName)";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = true;
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4000787734985352), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999210119247437), Telerik.Reporting.Drawing.Unit.Inch(0.30200472474098206));
            this.textBox7.StyleName = "Caption";
            this.textBox7.Value = "OUTGOINGFILE";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.localNumberDataTextBox,
            this.report_DateDataTextBox,
            this.sSNDataTextBox,
            this.lastNameDataTextBox,
            this.initialDataTextBox,
            this.eventDateDataTextBox,
            this.eventCodeDataTextBox,
            this.firstNameDataTextBox});
            this.detail.Name = "detail";
            this.detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // localNumberDataTextBox
            // 
            this.localNumberDataTextBox.CanGrow = true;
            this.localNumberDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.localNumberDataTextBox.Name = "localNumberDataTextBox";
            this.localNumberDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999603509902954), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.localNumberDataTextBox.StyleName = "Data";
            this.localNumberDataTextBox.Value = "=Fields.LocalNumber";
            // 
            // report_DateDataTextBox
            // 
            this.report_DateDataTextBox.CanGrow = true;
            this.report_DateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7000786066055298), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.report_DateDataTextBox.Name = "report_DateDataTextBox";
            this.report_DateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.report_DateDataTextBox.StyleName = "Data";
            this.report_DateDataTextBox.Value = "=Fields.Report_Date";
            // 
            // sSNDataTextBox
            // 
            this.sSNDataTextBox.CanGrow = true;
            this.sSNDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4000787734985352), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.sSNDataTextBox.Name = "sSNDataTextBox";
            this.sSNDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999210119247437), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.sSNDataTextBox.StyleName = "Data";
            this.sSNDataTextBox.Value = "=Fields.SSN";
            // 
            // lastNameDataTextBox
            // 
            this.lastNameDataTextBox.CanGrow = true;
            this.lastNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.1000785827636719), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameDataTextBox.Name = "lastNameDataTextBox";
            this.lastNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999210357666016), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.lastNameDataTextBox.StyleName = "Data";
            this.lastNameDataTextBox.Value = "=Fields.LastName";
            // 
            // initialDataTextBox
            // 
            this.initialDataTextBox.CanGrow = true;
            this.initialDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.700078010559082), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.initialDataTextBox.Name = "initialDataTextBox";
            this.initialDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999231576919556), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.initialDataTextBox.StyleName = "Data";
            this.initialDataTextBox.Value = "=Fields.Initial";
            // 
            // eventDateDataTextBox
            // 
            this.eventDateDataTextBox.CanGrow = true;
            this.eventDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.300079345703125), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.eventDateDataTextBox.Name = "eventDateDataTextBox";
            this.eventDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8998819589614868), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.eventDateDataTextBox.StyleName = "Data";
            this.eventDateDataTextBox.Value = "=Fields.EventDate";
            // 
            // eventCodeDataTextBox
            // 
            this.eventCodeDataTextBox.CanGrow = true;
            this.eventCodeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.400080680847168), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.eventCodeDataTextBox.Name = "eventCodeDataTextBox";
            this.eventCodeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999201059341431), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.eventCodeDataTextBox.StyleName = "Data";
            this.eventCodeDataTextBox.Value = "=Fields.EventCode";
            // 
            // firstNameDataTextBox
            // 
            this.firstNameDataTextBox.CanGrow = true;
            this.firstNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.900078296661377), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.firstNameDataTextBox.Name = "firstNameDataTextBox";
            this.firstNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999210357666016), Telerik.Reporting.Drawing.Unit.Inch(0.28117123246192932));
            this.firstNameDataTextBox.StyleName = "Data";
            this.firstNameDataTextBox.Value = "=Fields.FirstName";
            // 
            // Percapita_Outgoing
            // 
            this.DataSource = this.sqlDataSource1;
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.labelsGroup});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeader,
            this.labelsGroupFooter,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "Percapita_Outgoing";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(14.200000762939453);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox localNumberCaptionTextBox;
        private Telerik.Reporting.TextBox report_DateCaptionTextBox;
        private Telerik.Reporting.TextBox sSNCaptionTextBox;
        private Telerik.Reporting.TextBox lastNameCaptionTextBox;
        private Telerik.Reporting.TextBox firstNameCaptionTextBox;
        private Telerik.Reporting.TextBox eventCodeCaptionTextBox;
        private Telerik.Reporting.TextBox eventDateCaptionTextBox;
        private Telerik.Reporting.TextBox initialCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox localNumberDataTextBox;
        private Telerik.Reporting.TextBox report_DateDataTextBox;
        private Telerik.Reporting.TextBox sSNDataTextBox;
        private Telerik.Reporting.TextBox lastNameDataTextBox;
        private Telerik.Reporting.TextBox firstNameDataTextBox;
        private Telerik.Reporting.TextBox initialDataTextBox;
        private Telerik.Reporting.TextBox eventCodeDataTextBox;
        private Telerik.Reporting.TextBox eventDateDataTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox8;

    }
}