namespace Reports
{
    partial class Percapita_EmployerFile
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
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.localNumberCaptionTextBox = new Telerik.Reporting.TextBox();
            this.report_DateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.shopIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.employer_DBA_NameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_AddressCaptionTextBox = new Telerik.Reporting.TextBox();
            this.cityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_StateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_ZipCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_PhoneCaptionTextBox = new Telerik.Reporting.TextBox();
            this.uFCW_ContractNumberCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.localNumberDataTextBox = new Telerik.Reporting.TextBox();
            this.report_DateDataTextBox = new Telerik.Reporting.TextBox();
            this.shopIDDataTextBox = new Telerik.Reporting.TextBox();
            this.nameDataTextBox = new Telerik.Reporting.TextBox();
            this.employer_DBA_NameDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_AddressDataTextBox = new Telerik.Reporting.TextBox();
            this.cityDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_StateDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_ZipDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_PhoneDataTextBox = new Telerik.Reporting.TextBox();
            this.uFCW_ContractNumberDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.ReportPercapita_EmployerFile_sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.localNumberCaptionTextBox,
            this.report_DateCaptionTextBox,
            this.shopIDCaptionTextBox,
            this.nameCaptionTextBox,
            this.employer_DBA_NameCaptionTextBox,
            this.pri_AddressCaptionTextBox,
            this.cityCaptionTextBox,
            this.pri_StateCaptionTextBox,
            this.pri_ZipCaptionTextBox,
            this.pri_PhoneCaptionTextBox,
            this.uFCW_ContractNumberCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.Aqua;
            this.labelsGroupHeader.Style.Font.Name = "Tahoma";
            this.labelsGroupHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.labelsGroupHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.50819557905197144);
            this.labelsGroupFooter.Name = "labelsGroupFooter";
            this.labelsGroupFooter.Style.Visible = false;
            // 
            // labelsGroup
            // 
            this.labelsGroup.GroupFooter = this.labelsGroupFooter;
            this.labelsGroup.GroupHeader = this.labelsGroupHeader;
            this.labelsGroup.Name = "labelsGroup";
            // 
            // localNumberCaptionTextBox
            // 
            this.localNumberCaptionTextBox.CanGrow = true;
            this.localNumberCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9378803194267675E-05), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05));
            this.localNumberCaptionTextBox.Name = "localNumberCaptionTextBox";
            this.localNumberCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1998816728591919), Telerik.Reporting.Drawing.Unit.Inch(0.28117123246192932));
            this.localNumberCaptionTextBox.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.localNumberCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.localNumberCaptionTextBox.StyleName = "Caption";
            this.localNumberCaptionTextBox.Value = "Local Number";
            // 
            // report_DateCaptionTextBox
            // 
            this.report_DateCaptionTextBox.CanGrow = true;
            this.report_DateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1999999284744263), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.report_DateCaptionTextBox.Name = "report_DateCaptionTextBox";
            this.report_DateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3000000715255737), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.report_DateCaptionTextBox.StyleName = "Caption";
            this.report_DateCaptionTextBox.Value = "Report_Date";
            // 
            // shopIDCaptionTextBox
            // 
            this.shopIDCaptionTextBox.CanGrow = true;
            this.shopIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5000789165496826), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopIDCaptionTextBox.Name = "shopIDCaptionTextBox";
            this.shopIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1998426914215088), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.shopIDCaptionTextBox.StyleName = "Caption";
            this.shopIDCaptionTextBox.Value = "Shop ID";
            // 
            // nameCaptionTextBox
            // 
            this.nameCaptionTextBox.CanGrow = true;
            this.nameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7000002861022949), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05));
            this.nameCaptionTextBox.Name = "nameCaptionTextBox";
            this.nameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999208927154541), Telerik.Reporting.Drawing.Unit.Inch(0.28117123246192932));
            this.nameCaptionTextBox.StyleName = "Caption";
            this.nameCaptionTextBox.Value = "Name";
            // 
            // employer_DBA_NameCaptionTextBox
            // 
            this.employer_DBA_NameCaptionTextBox.CanGrow = true;
            this.employer_DBA_NameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.9000000953674316), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.employer_DBA_NameCaptionTextBox.Name = "employer_DBA_NameCaptionTextBox";
            this.employer_DBA_NameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7019689083099365), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.employer_DBA_NameCaptionTextBox.StyleName = "Caption";
            this.employer_DBA_NameCaptionTextBox.Value = "Employer_DBA_Name";
            // 
            // pri_AddressCaptionTextBox
            // 
            this.pri_AddressCaptionTextBox.CanGrow = true;
            this.pri_AddressCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.60204792022705), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_AddressCaptionTextBox.Name = "pri_AddressCaptionTextBox";
            this.pri_AddressCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999995946884155), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.pri_AddressCaptionTextBox.StyleName = "Caption";
            this.pri_AddressCaptionTextBox.Value = "Pri_Address";
            // 
            // cityCaptionTextBox
            // 
            this.cityCaptionTextBox.CanGrow = true;
            this.cityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.402126312255859), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.cityCaptionTextBox.Name = "cityCaptionTextBox";
            this.cityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3998432159423828), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.cityCaptionTextBox.StyleName = "Caption";
            this.cityCaptionTextBox.Value = "City";
            // 
            // pri_StateCaptionTextBox
            // 
            this.pri_StateCaptionTextBox.CanGrow = true;
            this.pri_StateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.802047729492188), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_StateCaptionTextBox.Name = "pri_StateCaptionTextBox";
            this.pri_StateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1645044088363648), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.pri_StateCaptionTextBox.StyleName = "Caption";
            this.pri_StateCaptionTextBox.Value = "Pri_State";
            // 
            // pri_ZipCaptionTextBox
            // 
            this.pri_ZipCaptionTextBox.CanGrow = true;
            this.pri_ZipCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.966631889343262), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05));
            this.pri_ZipCaptionTextBox.Name = "pri_ZipCaptionTextBox";
            this.pri_ZipCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016), Telerik.Reporting.Drawing.Unit.Inch(0.28117123246192932));
            this.pri_ZipCaptionTextBox.StyleName = "Caption";
            this.pri_ZipCaptionTextBox.Value = "Pri_Zip";
            // 
            // pri_PhoneCaptionTextBox
            // 
            this.pri_PhoneCaptionTextBox.CanGrow = true;
            this.pri_PhoneCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.266631126403809), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_PhoneCaptionTextBox.Name = "pri_PhoneCaptionTextBox";
            this.pri_PhoneCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5999196767807007), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.pri_PhoneCaptionTextBox.StyleName = "Caption";
            this.pri_PhoneCaptionTextBox.Value = "Pri_Phone";
            // 
            // uFCW_ContractNumberCaptionTextBox
            // 
            this.uFCW_ContractNumberCaptionTextBox.CanGrow = true;
            this.uFCW_ContractNumberCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.866628646850586), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.uFCW_ContractNumberCaptionTextBox.Name = "uFCW_ContractNumberCaptionTextBox";
            this.uFCW_ContractNumberCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7541682720184326), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.uFCW_ContractNumberCaptionTextBox.StyleName = "Caption";
            this.uFCW_ContractNumberCaptionTextBox.Value = "UFCW_Contract Number";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.pageFooter.Name = "pageFooter";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.80823493003845215);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.textBox2,
            this.textBox3});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.reportHeader.Style.Font.Name = "Tahoma";
            this.reportHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.reportHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.50819557905197144);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.textBox8});
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.localNumberDataTextBox,
            this.report_DateDataTextBox,
            this.shopIDDataTextBox,
            this.nameDataTextBox,
            this.employer_DBA_NameDataTextBox,
            this.pri_AddressDataTextBox,
            this.cityDataTextBox,
            this.pri_StateDataTextBox,
            this.pri_ZipDataTextBox,
            this.pri_PhoneDataTextBox,
            this.uFCW_ContractNumberDataTextBox});
            this.detail.Name = "detail";
            this.detail.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.detail.Style.Font.Name = "Tahoma";
            this.detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // localNumberDataTextBox
            // 
            this.localNumberDataTextBox.CanGrow = true;
            this.localNumberDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9378803194267675E-05), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.localNumberDataTextBox.Name = "localNumberDataTextBox";
            this.localNumberDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1998816728591919), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.localNumberDataTextBox.StyleName = "Data";
            this.localNumberDataTextBox.Value = "=Fields.LocalNumber";
            // 
            // report_DateDataTextBox
            // 
            this.report_DateDataTextBox.CanGrow = true;
            this.report_DateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.1999999284744263), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.report_DateDataTextBox.Name = "report_DateDataTextBox";
            this.report_DateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3000000715255737), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.report_DateDataTextBox.StyleName = "Data";
            this.report_DateDataTextBox.Value = "=Fields.Report_Date";
            // 
            // shopIDDataTextBox
            // 
            this.shopIDDataTextBox.CanGrow = true;
            this.shopIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5000789165496826), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopIDDataTextBox.Name = "shopIDDataTextBox";
            this.shopIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1998426914215088), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.shopIDDataTextBox.StyleName = "Data";
            this.shopIDDataTextBox.Value = "=Fields.ShopID";
            // 
            // nameDataTextBox
            // 
            this.nameDataTextBox.CanGrow = true;
            this.nameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.7000002861022949), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.nameDataTextBox.Name = "nameDataTextBox";
            this.nameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999208927154541), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.nameDataTextBox.StyleName = "Data";
            this.nameDataTextBox.Value = "=Fields.Name";
            // 
            // employer_DBA_NameDataTextBox
            // 
            this.employer_DBA_NameDataTextBox.CanGrow = true;
            this.employer_DBA_NameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.9000000953674316), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.employer_DBA_NameDataTextBox.Name = "employer_DBA_NameDataTextBox";
            this.employer_DBA_NameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7019689083099365), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.employer_DBA_NameDataTextBox.StyleName = "Data";
            this.employer_DBA_NameDataTextBox.Value = "=Fields.Employer_DBA_Name";
            // 
            // pri_AddressDataTextBox
            // 
            this.pri_AddressDataTextBox.CanGrow = true;
            this.pri_AddressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.60204792022705), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_AddressDataTextBox.Name = "pri_AddressDataTextBox";
            this.pri_AddressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7999988794326782), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.pri_AddressDataTextBox.StyleName = "Data";
            this.pri_AddressDataTextBox.Value = "=Fields.Pri_Address";
            // 
            // cityDataTextBox
            // 
            this.cityDataTextBox.CanGrow = true;
            this.cityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.402125358581543), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.cityDataTextBox.Name = "cityDataTextBox";
            this.cityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3998432159423828), Telerik.Reporting.Drawing.Unit.Inch(0.28117123246192932));
            this.cityDataTextBox.StyleName = "Data";
            this.cityDataTextBox.Value = "=Fields.City";
            // 
            // pri_StateDataTextBox
            // 
            this.pri_StateDataTextBox.CanGrow = true;
            this.pri_StateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.802047729492188), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_StateDataTextBox.Name = "pri_StateDataTextBox";
            this.pri_StateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1645036935806274), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.pri_StateDataTextBox.StyleName = "Data";
            this.pri_StateDataTextBox.Value = "=Fields.Pri_State";
            // 
            // pri_ZipDataTextBox
            // 
            this.pri_ZipDataTextBox.CanGrow = true;
            this.pri_ZipDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.966629981994629), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_ZipDataTextBox.Name = "pri_ZipDataTextBox";
            this.pri_ZipDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2999210357666016), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.pri_ZipDataTextBox.StyleName = "Data";
            this.pri_ZipDataTextBox.Value = "=Fields.Pri_Zip";
            // 
            // pri_PhoneDataTextBox
            // 
            this.pri_PhoneDataTextBox.CanGrow = true;
            this.pri_PhoneDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.266629219055176), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_PhoneDataTextBox.Name = "pri_PhoneDataTextBox";
            this.pri_PhoneDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5999208688735962), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.pri_PhoneDataTextBox.StyleName = "Data";
            this.pri_PhoneDataTextBox.Value = "=Fields.Pri_Phone";
            // 
            // uFCW_ContractNumberDataTextBox
            // 
            this.uFCW_ContractNumberDataTextBox.CanGrow = true;
            this.uFCW_ContractNumberDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.866628646850586), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.uFCW_ContractNumberDataTextBox.Name = "uFCW_ContractNumberDataTextBox";
            this.uFCW_ContractNumberDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7541682720184326), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.uFCW_ContractNumberDataTextBox.StyleName = "Data";
            this.uFCW_ContractNumberDataTextBox.Value = "=Fields.UFCW_ContractNumber";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0.29999995231628418));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1998816728591919), Telerik.Reporting.Drawing.Unit.Inch(0.50819557905197144));
            this.textBox1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "=Fields.LocalNumber";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.2000001668930054), Telerik.Reporting.Drawing.Unit.Inch(0.29999995231628418));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3000000715255737), Telerik.Reporting.Drawing.Unit.Inch(0.50815623998641968));
            this.textBox2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "=Fields.Report_Date";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.5000789165496826), Telerik.Reporting.Drawing.Unit.Inch(0.29999995231628418));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2458887100219727), Telerik.Reporting.Drawing.Unit.Inch(0.50815612077713013));
            this.textBox3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textBox3.Style.Font.Bold = true;
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "EMPLOYERFILE";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1998816728591919), Telerik.Reporting.Drawing.Unit.Inch(0.50819557905197144));
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "=Fields.LocalNumber";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6999999284744263), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999999046325684), Telerik.Reporting.Drawing.Unit.Inch(0.50815623998641968));
            this.textBox5.StyleName = "Data";
            this.textBox5.Value = "=Fields.Report_Date";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8000786304473877), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2458887100219727), Telerik.Reporting.Drawing.Unit.Inch(0.50815612077713013));
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "EMPLOYERFILE";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.3000001907348633), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0539537668228149), Telerik.Reporting.Drawing.Unit.Inch(0.50815606117248535));
            this.textBox8.Style.Font.Bold = false;
            this.textBox8.Style.Font.Name = "Tahoma";
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.Value = "= Count(Fields.LocalNumber)";
            // 
            // Percapita_EmployerFile
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
            this.Name = "Percapita_EmployerFile";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(19.62083625793457);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox localNumberCaptionTextBox;
        private Telerik.Reporting.TextBox report_DateCaptionTextBox;
        private Telerik.Reporting.TextBox shopIDCaptionTextBox;
        private Telerik.Reporting.TextBox nameCaptionTextBox;
        private Telerik.Reporting.TextBox employer_DBA_NameCaptionTextBox;
        private Telerik.Reporting.TextBox pri_AddressCaptionTextBox;
        private Telerik.Reporting.TextBox cityCaptionTextBox;
        private Telerik.Reporting.TextBox pri_StateCaptionTextBox;
        private Telerik.Reporting.TextBox pri_ZipCaptionTextBox;
        private Telerik.Reporting.TextBox pri_PhoneCaptionTextBox;
        private Telerik.Reporting.TextBox uFCW_ContractNumberCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox localNumberDataTextBox;
        private Telerik.Reporting.TextBox report_DateDataTextBox;
        private Telerik.Reporting.TextBox shopIDDataTextBox;
        private Telerik.Reporting.TextBox nameDataTextBox;
        private Telerik.Reporting.TextBox employer_DBA_NameDataTextBox;
        private Telerik.Reporting.TextBox pri_AddressDataTextBox;
        private Telerik.Reporting.TextBox cityDataTextBox;
        private Telerik.Reporting.TextBox pri_StateDataTextBox;
        private Telerik.Reporting.TextBox pri_ZipDataTextBox;
        private Telerik.Reporting.TextBox pri_PhoneDataTextBox;
        private Telerik.Reporting.TextBox uFCW_ContractNumberDataTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox8;
    }
}