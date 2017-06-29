namespace Reports
{
    partial class CensusHartford
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
            this.dOBCaptionTextBox = new Telerik.Reporting.TextBox();
            this.genderCaptionTextBox = new Telerik.Reporting.TextBox();
            this.yearHiredCaptionTextBox = new Telerik.Reporting.TextBox();
            this.shopZipCaptionTextBox = new Telerik.Reporting.TextBox();
            this.homeZipCaptionTextBox = new Telerik.Reporting.TextBox();
            this.memberIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            this.textBox18 = new Telerik.Reporting.TextBox();
            this.textBox19 = new Telerik.Reporting.TextBox();
            this.textBox20 = new Telerik.Reporting.TextBox();
            this.textBox21 = new Telerik.Reporting.TextBox();
            this.textBox22 = new Telerik.Reporting.TextBox();
            this.textBox23 = new Telerik.Reporting.TextBox();
            this.textBox24 = new Telerik.Reporting.TextBox();
            this.textBox25 = new Telerik.Reporting.TextBox();
            this.textBox26 = new Telerik.Reporting.TextBox();
            this.textBox27 = new Telerik.Reporting.TextBox();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.memberIDDataTextBox = new Telerik.Reporting.TextBox();
            this.dOBDataTextBox = new Telerik.Reporting.TextBox();
            this.genderDataTextBox = new Telerik.Reporting.TextBox();
            this.yearHiredDataTextBox = new Telerik.Reporting.TextBox();
            this.shopZipDataTextBox = new Telerik.Reporting.TextBox();
            this.homeZipDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox15 = new Telerik.Reporting.TextBox();
            this.textBox16 = new Telerik.Reporting.TextBox();
            this.textBox17 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.ReportHartford_sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.58360910415649414);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.dOBCaptionTextBox,
            this.genderCaptionTextBox,
            this.yearHiredCaptionTextBox,
            this.shopZipCaptionTextBox,
            this.homeZipCaptionTextBox,
            this.memberIDCaptionTextBox,
            this.textBox3,
            this.textBox5,
            this.textBox7,
            this.textBox9,
            this.textBox11,
            this.textBox12,
            this.textBox13,
            this.textBox14,
            this.textBox18,
            this.textBox19,
            this.textBox20,
            this.textBox21,
            this.textBox22,
            this.textBox23,
            this.textBox24,
            this.textBox25,
            this.textBox26,
            this.textBox27});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelsGroupHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.labelsGroupHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // dOBCaptionTextBox
            // 
            this.dOBCaptionTextBox.CanGrow = true;
            this.dOBCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0522016286849976), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.dOBCaptionTextBox.Name = "dOBCaptionTextBox";
            this.dOBCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58317559957504272));
            this.dOBCaptionTextBox.StyleName = "Caption";
            this.dOBCaptionTextBox.Value = "DOB   (MM/DD/YY)";
            // 
            // genderCaptionTextBox
            // 
            this.genderCaptionTextBox.CanGrow = true;
            this.genderCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1043636798858643), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.genderCaptionTextBox.Name = "genderCaptionTextBox";
            this.genderCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.genderCaptionTextBox.StyleName = "Caption";
            this.genderCaptionTextBox.Value = "Sex (M/F)";
            // 
            // yearHiredCaptionTextBox
            // 
            this.yearHiredCaptionTextBox.CanGrow = true;
            this.yearHiredCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1565258502960205), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.yearHiredCaptionTextBox.Name = "yearHiredCaptionTextBox";
            this.yearHiredCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.yearHiredCaptionTextBox.StyleName = "Caption";
            this.yearHiredCaptionTextBox.Value = "Year Hired";
            // 
            // shopZipCaptionTextBox
            // 
            this.shopZipCaptionTextBox.CanGrow = true;
            this.shopZipCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2086882591247559), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopZipCaptionTextBox.Name = "shopZipCaptionTextBox";
            this.shopZipCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.shopZipCaptionTextBox.StyleName = "Caption";
            this.shopZipCaptionTextBox.Value = "Work Location Zip Code";
            // 
            // homeZipCaptionTextBox
            // 
            this.homeZipCaptionTextBox.CanGrow = true;
            this.homeZipCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2608504295349121), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05));
            this.homeZipCaptionTextBox.Name = "homeZipCaptionTextBox";
            this.homeZipCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58309692144393921));
            this.homeZipCaptionTextBox.StyleName = "Caption";
            this.homeZipCaptionTextBox.Value = "Home Zip Code";
            // 
            // memberIDCaptionTextBox
            // 
            this.memberIDCaptionTextBox.CanGrow = true;
            this.memberIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05));
            this.memberIDCaptionTextBox.Name = "memberIDCaptionTextBox";
            this.memberIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58317571878433228));
            this.memberIDCaptionTextBox.StyleName = "Caption";
            this.memberIDCaptionTextBox.Value = "Employee\'s Name or Identifier";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3130125999450684), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.textBox3.StyleName = "Caption";
            this.textBox3.Value = "Occupation";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.3651747703552246), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox5.Name = "textBox3";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3348261117935181), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.textBox5.StyleName = "Caption";
            this.textBox5.Value = "H=Hourly;S=Salaried";
            // 
            // textBox7
            // 
            this.textBox7.CanGrow = true;
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.7000799179077148), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.textBox7.StyleName = "Caption";
            this.textBox7.Value = "Amt of Basic Earnings";
            // 
            // textBox9
            // 
            this.textBox9.CanGrow = true;
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.7522420883178711), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3348261117935181), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.textBox9.StyleName = "Caption";
            this.textBox9.Value = "Earnings Frequency (H,W,B,S,M,A)";
            // 
            // textBox11
            // 
            this.textBox11.CanGrow = true;
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.087146759033203), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.9127744436264038), Telerik.Reporting.Drawing.Unit.Inch(0.29176512360572815));
            this.textBox11.StyleName = "Caption";
            this.textBox11.Value = "Amt. Of Life Insurance";
            // 
            // textBox12
            // 
            this.textBox12.CanGrow = true;
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.textBox12.StyleName = "Caption";
            this.textBox12.Value = "Life Benefit Class (1,2,3,4)";
            // 
            // textBox13
            // 
            this.textBox13.CanGrow = true;
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.087146759033203), Telerik.Reporting.Drawing.Unit.Inch(0.291843980550766));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0128542184829712), Telerik.Reporting.Drawing.Unit.Inch(0.29176512360572815));
            this.textBox13.StyleName = "Caption";
            this.textBox13.Value = "Basic";
            // 
            // textBox14
            // 
            this.textBox14.CanGrow = true;
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.100079536437988), Telerik.Reporting.Drawing.Unit.Inch(0.29180464148521423));
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992016553878784), Telerik.Reporting.Drawing.Unit.Inch(0.29176512360572815));
            this.textBox14.StyleName = "Caption";
            this.textBox14.Value = "ADD";
            // 
            // textBox18
            // 
            this.textBox18.CanGrow = true;
            this.textBox18.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.052162170410156), Telerik.Reporting.Drawing.Unit.Inch(0.0004730224609375));
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7478383779525757), Telerik.Reporting.Drawing.Unit.Inch(0.29129210114479065));
            this.textBox18.StyleName = "Caption";
            this.textBox18.Value = "Basic Dependent Life (Y/N)";
            // 
            // textBox19
            // 
            this.textBox19.CanGrow = true;
            this.textBox19.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.90000057220459), Telerik.Reporting.Drawing.Unit.Inch(0.29180455207824707));
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366), Telerik.Reporting.Drawing.Unit.Inch(0.29133152961730957));
            this.textBox19.StyleName = "Caption";
            this.textBox19.Value = "Child";
            // 
            // textBox20
            // 
            this.textBox20.CanGrow = true;
            this.textBox20.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(14.052162170410156), Telerik.Reporting.Drawing.Unit.Inch(0.29180455207824707));
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.84775924682617188), Telerik.Reporting.Drawing.Unit.Inch(0.29133152961730957));
            this.textBox20.StyleName = "Caption";
            this.textBox20.Value = "Spouse";
            // 
            // textBox21
            // 
            this.textBox21.CanGrow = true;
            this.textBox21.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.800079345703125), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7478383779525757), Telerik.Reporting.Drawing.Unit.Inch(0.29129210114479065));
            this.textBox21.StyleName = "Caption";
            this.textBox21.Value = "Amt of Supp Dep Life Insurance";
            // 
            // textBox22
            // 
            this.textBox22.CanGrow = true;
            this.textBox22.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.800079345703125), Telerik.Reporting.Drawing.Unit.Inch(0.29227757453918457));
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.84775924682617188), Telerik.Reporting.Drawing.Unit.Inch(0.29133152961730957));
            this.textBox22.StyleName = "Caption";
            this.textBox22.Value = "Spouse";
            // 
            // textBox23
            // 
            this.textBox23.CanGrow = true;
            this.textBox23.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.647916793823242), Telerik.Reporting.Drawing.Unit.Inch(0.29227757453918457));
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.900000274181366), Telerik.Reporting.Drawing.Unit.Inch(0.29133152961730957));
            this.textBox23.StyleName = "Caption";
            this.textBox23.Value = "Child";
            // 
            // textBox24
            // 
            this.textBox24.CanGrow = true;
            this.textBox24.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(17.547996520996094), Telerik.Reporting.Drawing.Unit.Inch(0.0004730224609375));
            this.textBox24.Name = "genderCaptionTextBox";
            this.textBox24.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.textBox24.StyleName = "Caption";
            this.textBox24.Value = "LTD Enrolled (Y/N)";
            // 
            // textBox25
            // 
            this.textBox25.CanGrow = true;
            this.textBox25.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.60015869140625), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.textBox25.StyleName = "Caption";
            this.textBox25.Value = "LTD Benefit Class (1,2,3,4)";
            // 
            // textBox26
            // 
            this.textBox26.CanGrow = true;
            this.textBox26.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(19.652320861816406), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.textBox26.StyleName = "Caption";
            this.textBox26.Value = "WD Enrolled (Y/N)";
            // 
            // textBox27
            // 
            this.textBox27.CanGrow = true;
            this.textBox27.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(20.704483032226562), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox27.Name = "textBox26";
            this.textBox27.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.58313614130020142));
            this.textBox27.StyleName = "Caption";
            this.textBox27.Value = "WD Benefit Class (1,2,3,4)";
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
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.80862927436828613);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox,
            this.textBox1});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.reportHeader.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.2000007629394531), Telerik.Reporting.Drawing.Unit.Inch(0.80815625190734863));
            this.titleTextBox.Style.Color = System.Drawing.Color.Maroon;
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "CENSUS HARTFORD";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.456563949584961), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2999610900878906), Telerik.Reporting.Drawing.Unit.Inch(0.39996051788330078));
            this.textBox1.Style.Color = System.Drawing.Color.Maroon;
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
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.29133152961730957);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.memberIDDataTextBox,
            this.dOBDataTextBox,
            this.genderDataTextBox,
            this.yearHiredDataTextBox,
            this.shopZipDataTextBox,
            this.homeZipDataTextBox,
            this.textBox4,
            this.textBox6,
            this.textBox8,
            this.textBox10,
            this.textBox15,
            this.textBox16,
            this.textBox17,
            this.textBox2});
            this.detail.Name = "detail";
            this.detail.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // memberIDDataTextBox
            // 
            this.memberIDDataTextBox.CanGrow = true;
            this.memberIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.memberIDDataTextBox.Name = "memberIDDataTextBox";
            this.memberIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.28117123246192932));
            this.memberIDDataTextBox.StyleName = "Data";
            this.memberIDDataTextBox.Value = "=Fields.MemberID";
            // 
            // dOBDataTextBox
            // 
            this.dOBDataTextBox.CanGrow = true;
            this.dOBDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.0521621704101563), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.dOBDataTextBox.Name = "dOBDataTextBox";
            this.dOBDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.28117123246192932));
            this.dOBDataTextBox.StyleName = "Data";
            this.dOBDataTextBox.Value = "=Fields.DOB";
            // 
            // genderDataTextBox
            // 
            this.genderDataTextBox.CanGrow = true;
            this.genderDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.1043243408203125), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.genderDataTextBox.Name = "genderDataTextBox";
            this.genderDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.genderDataTextBox.StyleName = "Data";
            this.genderDataTextBox.Value = "= IIf((Fields.Gender)=0,\"M\",\"F\")";
            // 
            // yearHiredDataTextBox
            // 
            this.yearHiredDataTextBox.CanGrow = true;
            this.yearHiredDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.1564865112304688), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.yearHiredDataTextBox.Name = "yearHiredDataTextBox";
            this.yearHiredDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.yearHiredDataTextBox.StyleName = "Data";
            this.yearHiredDataTextBox.Value = "=Fields.YearHired";
            // 
            // shopZipDataTextBox
            // 
            this.shopZipDataTextBox.CanGrow = true;
            this.shopZipDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.208648681640625), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopZipDataTextBox.Name = "shopZipDataTextBox";
            this.shopZipDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.shopZipDataTextBox.StyleName = "Data";
            this.shopZipDataTextBox.Value = "=Fields.ShopZip";
            // 
            // homeZipDataTextBox
            // 
            this.homeZipDataTextBox.CanGrow = true;
            this.homeZipDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.2608108520507812), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.homeZipDataTextBox.Name = "homeZipDataTextBox";
            this.homeZipDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.homeZipDataTextBox.StyleName = "Data";
            this.homeZipDataTextBox.Value = "=Fields.HomeZip";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.3130125999450684), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.3651747703552246), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3348261117935181), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "H";
            // 
            // textBox8
            // 
            this.textBox8.CanGrow = true;
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.7000799179077148), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520833730697632), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.textBox8.StyleName = "Data";
            this.textBox8.Value = "";
            // 
            // textBox10
            // 
            this.textBox10.CanGrow = true;
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.7522420883178711), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3348261117935181), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.textBox10.StyleName = "Data";
            this.textBox10.Value = "";
            // 
            // textBox15
            // 
            this.textBox15.CanGrow = true;
            this.textBox15.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.087146759033203), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0128542184829712), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.textBox15.StyleName = "Data";
            this.textBox15.Value = " $25,000";
            // 
            // textBox16
            // 
            this.textBox16.CanGrow = true;
            this.textBox16.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.100079536437988), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.89992016553878784), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.textBox16.StyleName = "Data";
            this.textBox16.Value = " $25,000";
            // 
            // textBox17
            // 
            this.textBox17.CanGrow = true;
            this.textBox17.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.000079154968262), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox17.Name = "textBox16";
            this.textBox17.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0520044565200806), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.textBox17.StyleName = "Data";
            this.textBox17.Value = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(21.80000114440918), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.2999623715877533), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox2.Style.Visible = false;
            this.textBox2.Value = "=Fields.Shop";
            // 
            // CensusHartford
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
            this.Name = "CensusHartford";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(22.100000381469727);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox memberIDCaptionTextBox;
        private Telerik.Reporting.TextBox dOBCaptionTextBox;
        private Telerik.Reporting.TextBox yearHiredCaptionTextBox;
        private Telerik.Reporting.TextBox shopZipCaptionTextBox;
        private Telerik.Reporting.TextBox homeZipCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox memberIDDataTextBox;
        private Telerik.Reporting.TextBox dOBDataTextBox;
        private Telerik.Reporting.TextBox genderDataTextBox;
        private Telerik.Reporting.TextBox yearHiredDataTextBox;
        private Telerik.Reporting.TextBox shopZipDataTextBox;
        private Telerik.Reporting.TextBox homeZipDataTextBox;
        private Telerik.Reporting.TextBox genderCaptionTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.TextBox textBox14;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox15;
        private Telerik.Reporting.TextBox textBox16;
        private Telerik.Reporting.TextBox textBox18;
        private Telerik.Reporting.TextBox textBox19;
        private Telerik.Reporting.TextBox textBox20;
        private Telerik.Reporting.TextBox textBox21;
        private Telerik.Reporting.TextBox textBox22;
        private Telerik.Reporting.TextBox textBox23;
        private Telerik.Reporting.TextBox textBox24;
        private Telerik.Reporting.TextBox textBox25;
        private Telerik.Reporting.TextBox textBox17;
        private Telerik.Reporting.TextBox textBox26;
        private Telerik.Reporting.TextBox textBox27;
        private Telerik.Reporting.TextBox textBox2;
    }
}