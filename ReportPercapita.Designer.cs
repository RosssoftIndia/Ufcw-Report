namespace Reports
{
    partial class ReportPercapita
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
            this.local_NumberCaptionTextBox = new Telerik.Reporting.TextBox();
            this.report_DateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sSNCaptionTextBox = new Telerik.Reporting.TextBox();
            this.lastNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.firstNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.initialCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_AddressCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_CityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_StateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.countryCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_PhoneCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_EmailCaptionTextBox = new Telerik.Reporting.TextBox();
            this.genderCaptionTextBox = new Telerik.Reporting.TextBox();
            this.party_AffiliationCaptionTextBox = new Telerik.Reporting.TextBox();
            this.full_timeCaptionTextBox = new Telerik.Reporting.TextBox();
            this.affiliation_DateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pAC_Contribution_CycleCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pAC_MembershipCaptionTextBox = new Telerik.Reporting.TextBox();
            this.shopIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pAC_Contribution_RateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dues_RateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.terminatedDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.hiredDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.birthDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.mail_FlagCaptionTextBox = new Telerik.Reporting.TextBox();
            this.member_ClassCaptionTextBox = new Telerik.Reporting.TextBox();
            this.voter_Registration_FlagCaptionTextBox = new Telerik.Reporting.TextBox();
            this.marital_statusCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pri_ZipCaptionTextBox = new Telerik.Reporting.TextBox();
            this.labelsGroupFooter = new Telerik.Reporting.GroupFooterSection();
            this.labelsGroup = new Telerik.Reporting.Group();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.detail = new Telerik.Reporting.DetailSection();
            this.local_NumberDataTextBox = new Telerik.Reporting.TextBox();
            this.lastNameDataTextBox = new Telerik.Reporting.TextBox();
            this.firstNameDataTextBox = new Telerik.Reporting.TextBox();
            this.initialDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_AddressDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_ZipDataTextBox = new Telerik.Reporting.TextBox();
            this.countryDataTextBox = new Telerik.Reporting.TextBox();
            this.voter_Registration_FlagDataTextBox = new Telerik.Reporting.TextBox();
            this.terminatedDateDataTextBox = new Telerik.Reporting.TextBox();
            this.affiliation_DateDataTextBox = new Telerik.Reporting.TextBox();
            this.hiredDateDataTextBox = new Telerik.Reporting.TextBox();
            this.dues_RateDataTextBox = new Telerik.Reporting.TextBox();
            this.birthDateDataTextBox = new Telerik.Reporting.TextBox();
            this.mail_FlagDataTextBox = new Telerik.Reporting.TextBox();
            this.full_timeDataTextBox = new Telerik.Reporting.TextBox();
            this.shopIDDataTextBox = new Telerik.Reporting.TextBox();
            this.member_ClassDataTextBox = new Telerik.Reporting.TextBox();
            this.pAC_MembershipDataTextBox = new Telerik.Reporting.TextBox();
            this.pAC_Contribution_CycleDataTextBox = new Telerik.Reporting.TextBox();
            this.pAC_Contribution_RateDataTextBox = new Telerik.Reporting.TextBox();
            this.party_AffiliationDataTextBox = new Telerik.Reporting.TextBox();
            this.genderDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_EmailDataTextBox = new Telerik.Reporting.TextBox();
            this.marital_statusDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_PhoneDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_StateDataTextBox = new Telerik.Reporting.TextBox();
            this.pri_CityDataTextBox = new Telerik.Reporting.TextBox();
            this.sSNDataTextBox = new Telerik.Reporting.TextBox();
            this.report_DateDataTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.Active_Percaptia_N_sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.58482652902603149);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.local_NumberCaptionTextBox,
            this.report_DateCaptionTextBox,
            this.sSNCaptionTextBox,
            this.lastNameCaptionTextBox,
            this.firstNameCaptionTextBox,
            this.initialCaptionTextBox,
            this.pri_AddressCaptionTextBox,
            this.pri_CityCaptionTextBox,
            this.pri_StateCaptionTextBox,
            this.countryCaptionTextBox,
            this.pri_PhoneCaptionTextBox,
            this.pri_EmailCaptionTextBox,
            this.genderCaptionTextBox,
            this.party_AffiliationCaptionTextBox,
            this.full_timeCaptionTextBox,
            this.affiliation_DateCaptionTextBox,
            this.pAC_Contribution_CycleCaptionTextBox,
            this.pAC_MembershipCaptionTextBox,
            this.shopIDCaptionTextBox,
            this.pAC_Contribution_RateCaptionTextBox,
            this.dues_RateCaptionTextBox,
            this.terminatedDateCaptionTextBox,
            this.hiredDateCaptionTextBox,
            this.birthDateCaptionTextBox,
            this.mail_FlagCaptionTextBox,
            this.member_ClassCaptionTextBox,
            this.voter_Registration_FlagCaptionTextBox,
            this.marital_statusCaptionTextBox,
            this.pri_ZipCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelsGroupHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.labelsGroupHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // local_NumberCaptionTextBox
            // 
            this.local_NumberCaptionTextBox.CanGrow = true;
            this.local_NumberCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.0207544956356287), Telerik.Reporting.Drawing.Unit.Inch(0.020833412185311317));
            this.local_NumberCaptionTextBox.Name = "local_NumberCaptionTextBox";
            this.local_NumberCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6612902879714966), Telerik.Reporting.Drawing.Unit.Inch(0.56399315595626831));
            this.local_NumberCaptionTextBox.StyleName = "Caption";
            this.local_NumberCaptionTextBox.Value = "Local_Number";
            // 
            // report_DateCaptionTextBox
            // 
            this.report_DateCaptionTextBox.CanGrow = true;
            this.report_DateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6821236610412598), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.report_DateCaptionTextBox.Name = "report_DateCaptionTextBox";
            this.report_DateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1603442430496216), Telerik.Reporting.Drawing.Unit.Inch(0.5640721321105957));
            this.report_DateCaptionTextBox.StyleName = "Caption";
            this.report_DateCaptionTextBox.Value = "Report_Date";
            // 
            // sSNCaptionTextBox
            // 
            this.sSNCaptionTextBox.CanGrow = true;
            this.sSNCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8425467014312744), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.sSNCaptionTextBox.Name = "sSNCaptionTextBox";
            this.sSNCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2574536800384521), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.sSNCaptionTextBox.StyleName = "Caption";
            this.sSNCaptionTextBox.Value = "SSN";
            // 
            // lastNameCaptionTextBox
            // 
            this.lastNameCaptionTextBox.CanGrow = true;
            this.lastNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.10007905960083), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameCaptionTextBox.Name = "lastNameCaptionTextBox";
            this.lastNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6671997308731079), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.lastNameCaptionTextBox.StyleName = "Caption";
            this.lastNameCaptionTextBox.Value = "Last Name";
            // 
            // firstNameCaptionTextBox
            // 
            this.firstNameCaptionTextBox.CanGrow = true;
            this.firstNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.767357349395752), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.firstNameCaptionTextBox.Name = "firstNameCaptionTextBox";
            this.firstNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4186044931411743), Telerik.Reporting.Drawing.Unit.Inch(0.58478707075119019));
            this.firstNameCaptionTextBox.StyleName = "Caption";
            this.firstNameCaptionTextBox.Value = "First Name";
            // 
            // initialCaptionTextBox
            // 
            this.initialCaptionTextBox.CanGrow = true;
            this.initialCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1860408782958984), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.initialCaptionTextBox.Name = "initialCaptionTextBox";
            this.initialCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83056640625), Telerik.Reporting.Drawing.Unit.Inch(0.58482646942138672));
            this.initialCaptionTextBox.StyleName = "Caption";
            this.initialCaptionTextBox.Value = "Initial";
            // 
            // pri_AddressCaptionTextBox
            // 
            this.pri_AddressCaptionTextBox.CanGrow = true;
            this.pri_AddressCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.01668643951416), Telerik.Reporting.Drawing.Unit.Inch(0.020833412185311317));
            this.pri_AddressCaptionTextBox.Name = "pri_AddressCaptionTextBox";
            this.pri_AddressCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7491700649261475), Telerik.Reporting.Drawing.Unit.Inch(0.56399315595626831));
            this.pri_AddressCaptionTextBox.StyleName = "Caption";
            this.pri_AddressCaptionTextBox.Value = "Pri_Address";
            // 
            // pri_CityCaptionTextBox
            // 
            this.pri_CityCaptionTextBox.CanGrow = true;
            this.pri_CityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.765934944152832), Telerik.Reporting.Drawing.Unit.Inch(0.01041682530194521));
            this.pri_CityCaptionTextBox.Name = "pri_CityCaptionTextBox";
            this.pri_CityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6569111347198486), Telerik.Reporting.Drawing.Unit.Inch(0.56395357847213745));
            this.pri_CityCaptionTextBox.StyleName = "Caption";
            this.pri_CityCaptionTextBox.Value = "Pri_City";
            // 
            // pri_StateCaptionTextBox
            // 
            this.pri_StateCaptionTextBox.CanGrow = true;
            this.pri_StateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.422924995422363), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_StateCaptionTextBox.Name = "pri_StateCaptionTextBox";
            this.pri_StateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.55365538597106934));
            this.pri_StateCaptionTextBox.StyleName = "Caption";
            this.pri_StateCaptionTextBox.Value = "Pri_State";
            // 
            // countryCaptionTextBox
            // 
            this.countryCaptionTextBox.CanGrow = true;
            this.countryCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.614582061767578), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.countryCaptionTextBox.Name = "countryCaptionTextBox";
            this.countryCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.countryCaptionTextBox.StyleName = "Caption";
            this.countryCaptionTextBox.Value = "Country";
            // 
            // pri_PhoneCaptionTextBox
            // 
            this.pri_PhoneCaptionTextBox.CanGrow = true;
            this.pri_PhoneCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.314582824707031), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_PhoneCaptionTextBox.Name = "pri_PhoneCaptionTextBox";
            this.pri_PhoneCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.699920654296875), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.pri_PhoneCaptionTextBox.StyleName = "Caption";
            this.pri_PhoneCaptionTextBox.Value = "Pri_Phone";
            // 
            // pri_EmailCaptionTextBox
            // 
            this.pri_EmailCaptionTextBox.CanGrow = true;
            this.pri_EmailCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(20.014581680297852), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pri_EmailCaptionTextBox.Name = "pri_EmailCaptionTextBox";
            this.pri_EmailCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.599921464920044), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.pri_EmailCaptionTextBox.StyleName = "Caption";
            this.pri_EmailCaptionTextBox.Value = "Pri_Email";
            // 
            // genderCaptionTextBox
            // 
            this.genderCaptionTextBox.CanGrow = true;
            this.genderCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(21.614580154418945), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.genderCaptionTextBox.Name = "genderCaptionTextBox";
            this.genderCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.699920654296875), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.genderCaptionTextBox.StyleName = "Caption";
            this.genderCaptionTextBox.Value = "Gender";
            // 
            // party_AffiliationCaptionTextBox
            // 
            this.party_AffiliationCaptionTextBox.CanGrow = true;
            this.party_AffiliationCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(26.660421371459961), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.party_AffiliationCaptionTextBox.Name = "party_AffiliationCaptionTextBox";
            this.party_AffiliationCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.56407195329666138));
            this.party_AffiliationCaptionTextBox.StyleName = "Caption";
            this.party_AffiliationCaptionTextBox.Value = "Party_Affiliation";
            // 
            // full_timeCaptionTextBox
            // 
            this.full_timeCaptionTextBox.CanGrow = true;
            this.full_timeCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(36.839572906494141), Telerik.Reporting.Drawing.Unit.Inch(0.020833412185311317));
            this.full_timeCaptionTextBox.Name = "full_timeCaptionTextBox";
            this.full_timeCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999225616455078), Telerik.Reporting.Drawing.Unit.Inch(0.543238639831543));
            this.full_timeCaptionTextBox.StyleName = "Caption";
            this.full_timeCaptionTextBox.Value = "Full_time";
            // 
            // affiliation_DateCaptionTextBox
            // 
            this.affiliation_DateCaptionTextBox.CanGrow = true;
            this.affiliation_DateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(43.704158782958984), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.affiliation_DateCaptionTextBox.Name = "affiliation_DateCaptionTextBox";
            this.affiliation_DateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6728382110595703), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.affiliation_DateCaptionTextBox.StyleName = "Caption";
            this.affiliation_DateCaptionTextBox.Value = "Affiliation_Date";
            // 
            // pAC_Contribution_CycleCaptionTextBox
            // 
            this.pAC_Contribution_CycleCaptionTextBox.CanGrow = true;
            this.pAC_Contribution_CycleCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(31.760412216186523), Telerik.Reporting.Drawing.Unit.Inch(0.010416666977107525));
            this.pAC_Contribution_CycleCaptionTextBox.Name = "pAC_Contribution_CycleCaptionTextBox";
            this.pAC_Contribution_CycleCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.55365544557571411));
            this.pAC_Contribution_CycleCaptionTextBox.StyleName = "Caption";
            this.pAC_Contribution_CycleCaptionTextBox.Value = "PAC_Contribution_Cycle";
            // 
            // pAC_MembershipCaptionTextBox
            // 
            this.pAC_MembershipCaptionTextBox.CanGrow = true;
            this.pAC_MembershipCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(28.360418319702148), Telerik.Reporting.Drawing.Unit.Inch(0.010416666977107525));
            this.pAC_MembershipCaptionTextBox.Name = "pAC_MembershipCaptionTextBox";
            this.pAC_MembershipCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.699920654296875), Telerik.Reporting.Drawing.Unit.Inch(0.55365532636642456));
            this.pAC_MembershipCaptionTextBox.StyleName = "Caption";
            this.pAC_MembershipCaptionTextBox.Value = "PAC_Membership";
            // 
            // shopIDCaptionTextBox
            // 
            this.shopIDCaptionTextBox.CanGrow = true;
            this.shopIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(33.460407257080078), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05));
            this.shopIDCaptionTextBox.Name = "shopIDCaptionTextBox";
            this.shopIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.56403273344039917));
            this.shopIDCaptionTextBox.StyleName = "Caption";
            this.shopIDCaptionTextBox.Value = "Shop ID";
            // 
            // pAC_Contribution_RateCaptionTextBox
            // 
            this.pAC_Contribution_RateCaptionTextBox.CanGrow = true;
            this.pAC_Contribution_RateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(30.060415267944336), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pAC_Contribution_RateCaptionTextBox.Name = "pAC_Contribution_RateCaptionTextBox";
            this.pAC_Contribution_RateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.56407195329666138));
            this.pAC_Contribution_RateCaptionTextBox.StyleName = "Caption";
            this.pAC_Contribution_RateCaptionTextBox.Value = "PAC_Contribution_Rate";
            // 
            // dues_RateCaptionTextBox
            // 
            this.dues_RateCaptionTextBox.CanGrow = true;
            this.dues_RateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(47.104167938232422), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.dues_RateCaptionTextBox.Name = "dues_RateCaptionTextBox";
            this.dues_RateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999607086181641), Telerik.Reporting.Drawing.Unit.Inch(0.56407195329666138));
            this.dues_RateCaptionTextBox.StyleName = "Caption";
            this.dues_RateCaptionTextBox.Value = "Dues_Rate";
            // 
            // terminatedDateCaptionTextBox
            // 
            this.terminatedDateCaptionTextBox.CanGrow = true;
            this.terminatedDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(45.3770751953125), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.terminatedDateCaptionTextBox.Name = "terminatedDateCaptionTextBox";
            this.terminatedDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7270056009292603), Telerik.Reporting.Drawing.Unit.Inch(0.5640721321105957));
            this.terminatedDateCaptionTextBox.StyleName = "Caption";
            this.terminatedDateCaptionTextBox.Value = "Terminated Date";
            // 
            // hiredDateCaptionTextBox
            // 
            this.hiredDateCaptionTextBox.CanGrow = true;
            this.hiredDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(42.004154205322266), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.hiredDateCaptionTextBox.Name = "hiredDateCaptionTextBox";
            this.hiredDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.hiredDateCaptionTextBox.StyleName = "Caption";
            this.hiredDateCaptionTextBox.Value = "Hired Date";
            // 
            // birthDateCaptionTextBox
            // 
            this.birthDateCaptionTextBox.CanGrow = true;
            this.birthDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(40.239570617675781), Telerik.Reporting.Drawing.Unit.Inch(0.010416666977107525));
            this.birthDateCaptionTextBox.Name = "birthDateCaptionTextBox";
            this.birthDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7645078897476196), Telerik.Reporting.Drawing.Unit.Inch(0.55365538597106934));
            this.birthDateCaptionTextBox.StyleName = "Caption";
            this.birthDateCaptionTextBox.Value = "Birth Date";
            // 
            // mail_FlagCaptionTextBox
            // 
            this.mail_FlagCaptionTextBox.CanGrow = true;
            this.mail_FlagCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(38.539569854736328), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.mail_FlagCaptionTextBox.Name = "mail_FlagCaptionTextBox";
            this.mail_FlagCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999225616455078), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.mail_FlagCaptionTextBox.StyleName = "Caption";
            this.mail_FlagCaptionTextBox.Value = "Mail_Flag";
            // 
            // member_ClassCaptionTextBox
            // 
            this.member_ClassCaptionTextBox.CanGrow = true;
            this.member_ClassCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(35.160404205322266), Telerik.Reporting.Drawing.Unit.Inch(0.010456006042659283));
            this.member_ClassCaptionTextBox.Name = "member_ClassCaptionTextBox";
            this.member_ClassCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6790891885757446), Telerik.Reporting.Drawing.Unit.Inch(0.5536159873008728));
            this.member_ClassCaptionTextBox.StyleName = "Caption";
            this.member_ClassCaptionTextBox.Value = "Member_Class";
            // 
            // voter_Registration_FlagCaptionTextBox
            // 
            this.voter_Registration_FlagCaptionTextBox.CanGrow = true;
            this.voter_Registration_FlagCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(24.960420608520508), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.voter_Registration_FlagCaptionTextBox.Name = "voter_Registration_FlagCaptionTextBox";
            this.voter_Registration_FlagCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999218463897705), Telerik.Reporting.Drawing.Unit.Inch(0.5640721321105957));
            this.voter_Registration_FlagCaptionTextBox.StyleName = "Caption";
            this.voter_Registration_FlagCaptionTextBox.Value = "Voter_Registration_Flag";
            // 
            // marital_statusCaptionTextBox
            // 
            this.marital_statusCaptionTextBox.CanGrow = true;
            this.marital_statusCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(23.3145809173584), Telerik.Reporting.Drawing.Unit.Inch(0.010416666977107525));
            this.marital_statusCaptionTextBox.Name = "marital_statusCaptionTextBox";
            this.marital_statusCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6457633972167969), Telerik.Reporting.Drawing.Unit.Inch(0.55365532636642456));
            this.marital_statusCaptionTextBox.StyleName = "Caption";
            this.marital_statusCaptionTextBox.Value = "Marital_status";
            // 
            // pri_ZipCaptionTextBox
            // 
            this.pri_ZipCaptionTextBox.CanGrow = true;
            this.pri_ZipCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.1229248046875), Telerik.Reporting.Drawing.Unit.Inch(0.010416666977107525));
            this.pri_ZipCaptionTextBox.Name = "pri_ZipCaptionTextBox";
            this.pri_ZipCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4915784597396851), Telerik.Reporting.Drawing.Unit.Inch(0.56407207250595093));
            this.pri_ZipCaptionTextBox.StyleName = "Caption";
            this.pri_ZipCaptionTextBox.Value = "Pri_Zip";
            // 
            // labelsGroupFooter
            // 
            this.labelsGroupFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666);
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
            this.pageFooter.Name = "pageFooter";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.43893614411354065);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox8,
            this.textBox4,
            this.textBox5,
            this.textBox6});
            this.reportFooter.Name = "reportFooter";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.2063908576965332), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.9820447564125061), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.textBox8.Style.Font.Bold = false;
            this.textBox8.Style.Font.Name = "Tahoma";
            this.textBox8.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9);
            this.textBox8.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox8.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox8.Value = "= Count(Fields.Local_Number)";
            // 
            // textBox4
            // 
            this.textBox4.CanGrow = true;
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.699999988079071), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.96121150255203247), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.textBox4.StyleName = "Data";
            this.textBox4.Value = "=Fields.Local_Number";
            // 
            // textBox5
            // 
            this.textBox5.CanGrow = true;
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.7999998331069946), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1603442430496216), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.textBox5.StyleName = "Data";
            this.textBox5.Value = "=Fields.Report_Date";
            // 
            // textBox6
            // 
            this.textBox6.CanGrow = true;
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.9604232311248779), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2458887100219727), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.textBox6.StyleName = "Data";
            this.textBox6.Value = "MEMBERFILE";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.43392348289489746);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.local_NumberDataTextBox,
            this.lastNameDataTextBox,
            this.firstNameDataTextBox,
            this.initialDataTextBox,
            this.pri_AddressDataTextBox,
            this.pri_ZipDataTextBox,
            this.countryDataTextBox,
            this.voter_Registration_FlagDataTextBox,
            this.terminatedDateDataTextBox,
            this.affiliation_DateDataTextBox,
            this.hiredDateDataTextBox,
            this.dues_RateDataTextBox,
            this.birthDateDataTextBox,
            this.mail_FlagDataTextBox,
            this.full_timeDataTextBox,
            this.shopIDDataTextBox,
            this.member_ClassDataTextBox,
            this.pAC_MembershipDataTextBox,
            this.pAC_Contribution_CycleDataTextBox,
            this.pAC_Contribution_RateDataTextBox,
            this.party_AffiliationDataTextBox,
            this.genderDataTextBox,
            this.pri_EmailDataTextBox,
            this.marital_statusDataTextBox,
            this.pri_PhoneDataTextBox,
            this.pri_StateDataTextBox,
            this.pri_CityDataTextBox,
            this.sSNDataTextBox,
            this.report_DateDataTextBox});
            this.detail.Name = "detail";
            this.detail.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // local_NumberDataTextBox
            // 
            this.local_NumberDataTextBox.CanGrow = true;
            this.local_NumberDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.local_NumberDataTextBox.Name = "local_NumberDataTextBox";
            this.local_NumberDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6612114906311035), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.local_NumberDataTextBox.StyleName = "Data";
            this.local_NumberDataTextBox.Value = "=Fields.Local_Number";
            // 
            // lastNameDataTextBox
            // 
            this.lastNameDataTextBox.CanGrow = true;
            this.lastNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.1000003814697266), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameDataTextBox.Name = "lastNameDataTextBox";
            this.lastNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6672782897949219), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.lastNameDataTextBox.StyleName = "Data";
            this.lastNameDataTextBox.Value = "=Fields.LastName";
            // 
            // firstNameDataTextBox
            // 
            this.firstNameDataTextBox.CanGrow = true;
            this.firstNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.767357349395752), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.firstNameDataTextBox.Name = "firstNameDataTextBox";
            this.firstNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4186044931411743), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.firstNameDataTextBox.StyleName = "Data";
            this.firstNameDataTextBox.Value = "=Fields.FirstName";
            // 
            // initialDataTextBox
            // 
            this.initialDataTextBox.CanGrow = true;
            this.initialDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.1860408782958984), Telerik.Reporting.Drawing.Unit.Inch(7.8837074397597462E-05));
            this.initialDataTextBox.Name = "initialDataTextBox";
            this.initialDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.83056610822677612), Telerik.Reporting.Drawing.Unit.Inch(0.43380507826805115));
            this.initialDataTextBox.StyleName = "Data";
            this.initialDataTextBox.Value = "=Fields.Initial";
            // 
            // pri_AddressDataTextBox
            // 
            this.pri_AddressDataTextBox.CanGrow = true;
            this.pri_AddressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.01668643951416), Telerik.Reporting.Drawing.Unit.Inch(7.8837074397597462E-05));
            this.pri_AddressDataTextBox.Name = "pri_AddressDataTextBox";
            this.pri_AddressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7491695880889893), Telerik.Reporting.Drawing.Unit.Inch(0.43380507826805115));
            this.pri_AddressDataTextBox.StyleName = "Data";
            this.pri_AddressDataTextBox.Value = "=Fields.Pri_Address";
            // 
            // pri_ZipDataTextBox
            // 
            this.pri_ZipDataTextBox.CanGrow = true;
            this.pri_ZipDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(15.1229248046875), Telerik.Reporting.Drawing.Unit.Inch(7.8837074397597462E-05));
            this.pri_ZipDataTextBox.Name = "pri_ZipDataTextBox";
            this.pri_ZipDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.491580605506897), Telerik.Reporting.Drawing.Unit.Inch(0.43380507826805115));
            this.pri_ZipDataTextBox.StyleName = "Data";
            this.pri_ZipDataTextBox.Value = "=Fields.Pri_Zip";
            // 
            // countryDataTextBox
            // 
            this.countryDataTextBox.CanGrow = true;
            this.countryDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(16.614582061767578), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.countryDataTextBox.Name = "countryDataTextBox";
            this.countryDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.69992196559906), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.countryDataTextBox.StyleName = "Data";
            this.countryDataTextBox.Value = "=Fields.Country";
            // 
            // voter_Registration_FlagDataTextBox
            // 
            this.voter_Registration_FlagDataTextBox.CanGrow = true;
            this.voter_Registration_FlagDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(24.960420608520508), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505));
            this.voter_Registration_FlagDataTextBox.Name = "voter_Registration_FlagDataTextBox";
            this.voter_Registration_FlagDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999212503433228), Telerik.Reporting.Drawing.Unit.Inch(0.41305056214332581));
            this.voter_Registration_FlagDataTextBox.StyleName = "Data";
            this.voter_Registration_FlagDataTextBox.Value = "=Fields.Voter_Registration_Flag";
            // 
            // terminatedDateDataTextBox
            // 
            this.terminatedDateDataTextBox.CanGrow = true;
            this.terminatedDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(45.404117584228516), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.terminatedDateDataTextBox.Name = "terminatedDateDataTextBox";
            this.terminatedDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999632120132446), Telerik.Reporting.Drawing.Unit.Inch(0.43388405442237854));
            this.terminatedDateDataTextBox.StyleName = "Data";
            this.terminatedDateDataTextBox.Value = "=Fields.TerminatedDate";
            // 
            // affiliation_DateDataTextBox
            // 
            this.affiliation_DateDataTextBox.CanGrow = true;
            this.affiliation_DateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(43.704158782958984), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.affiliation_DateDataTextBox.Name = "affiliation_DateDataTextBox";
            this.affiliation_DateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6728355884552002), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.affiliation_DateDataTextBox.StyleName = "Data";
            this.affiliation_DateDataTextBox.Value = "=Fields.Affiliation_Date";
            // 
            // hiredDateDataTextBox
            // 
            this.hiredDateDataTextBox.CanGrow = true;
            this.hiredDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(42.004154205322266), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.hiredDateDataTextBox.Name = "hiredDateDataTextBox";
            this.hiredDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999174356460571), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.hiredDateDataTextBox.StyleName = "Data";
            this.hiredDateDataTextBox.Value = "=Fields.HiredDate";
            // 
            // dues_RateDataTextBox
            // 
            this.dues_RateDataTextBox.CanGrow = true;
            this.dues_RateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(47.104167938232422), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505));
            this.dues_RateDataTextBox.Name = "dues_RateDataTextBox";
            this.dues_RateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999607086181641), Telerik.Reporting.Drawing.Unit.Inch(0.41305056214332581));
            this.dues_RateDataTextBox.StyleName = "Data";
            this.dues_RateDataTextBox.Value = "=Fields.Dues_Rate";
            // 
            // birthDateDataTextBox
            // 
            this.birthDateDataTextBox.CanGrow = true;
            this.birthDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(40.239570617675781), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505));
            this.birthDateDataTextBox.Name = "birthDateDataTextBox";
            this.birthDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.7645078897476196), Telerik.Reporting.Drawing.Unit.Inch(0.41305056214332581));
            this.birthDateDataTextBox.StyleName = "Data";
            this.birthDateDataTextBox.Value = "=Fields.BirthDate";
            // 
            // mail_FlagDataTextBox
            // 
            this.mail_FlagDataTextBox.CanGrow = true;
            this.mail_FlagDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(38.539569854736328), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505));
            this.mail_FlagDataTextBox.Name = "mail_FlagDataTextBox";
            this.mail_FlagDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999225616455078), Telerik.Reporting.Drawing.Unit.Inch(0.41305056214332581));
            this.mail_FlagDataTextBox.StyleName = "Data";
            this.mail_FlagDataTextBox.Value = "=Fields.Mail_Flag";
            // 
            // full_timeDataTextBox
            // 
            this.full_timeDataTextBox.CanGrow = true;
            this.full_timeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(36.839572906494141), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.full_timeDataTextBox.Name = "full_timeDataTextBox";
            this.full_timeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999231576919556), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.full_timeDataTextBox.StyleName = "Data";
            this.full_timeDataTextBox.Value = "=Fields.Full_time";
            // 
            // shopIDDataTextBox
            // 
            this.shopIDDataTextBox.CanGrow = true;
            this.shopIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(33.460407257080078), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopIDDataTextBox.Name = "shopIDDataTextBox";
            this.shopIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.699920654296875), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.shopIDDataTextBox.StyleName = "Data";
            this.shopIDDataTextBox.Value = "=Fields.ShopID";
            // 
            // member_ClassDataTextBox
            // 
            this.member_ClassDataTextBox.CanGrow = true;
            this.member_ClassDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(35.160404205322266), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.member_ClassDataTextBox.Name = "member_ClassDataTextBox";
            this.member_ClassDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6790891885757446), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.member_ClassDataTextBox.StyleName = "Data";
            this.member_ClassDataTextBox.Value = "=Fields.Member_Class";
            // 
            // pAC_MembershipDataTextBox
            // 
            this.pAC_MembershipDataTextBox.CanGrow = true;
            this.pAC_MembershipDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(28.360418319702148), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.pAC_MembershipDataTextBox.Name = "pAC_MembershipDataTextBox";
            this.pAC_MembershipDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999199390411377), Telerik.Reporting.Drawing.Unit.Inch(0.43384447693824768));
            this.pAC_MembershipDataTextBox.StyleName = "Data";
            this.pAC_MembershipDataTextBox.Value = "=Fields.PAC_Membership";
            // 
            // pAC_Contribution_CycleDataTextBox
            // 
            this.pAC_Contribution_CycleDataTextBox.CanGrow = true;
            this.pAC_Contribution_CycleDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(31.760412216186523), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pAC_Contribution_CycleDataTextBox.Name = "pAC_Contribution_CycleDataTextBox";
            this.pAC_Contribution_CycleDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999199390411377), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.pAC_Contribution_CycleDataTextBox.StyleName = "Data";
            this.pAC_Contribution_CycleDataTextBox.Value = "=Fields.PAC_Contribution_Cycle";
            // 
            // pAC_Contribution_RateDataTextBox
            // 
            this.pAC_Contribution_RateDataTextBox.CanGrow = true;
            this.pAC_Contribution_RateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(30.060415267944336), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.pAC_Contribution_RateDataTextBox.Name = "pAC_Contribution_RateDataTextBox";
            this.pAC_Contribution_RateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.699920654296875), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.pAC_Contribution_RateDataTextBox.StyleName = "Data";
            this.pAC_Contribution_RateDataTextBox.Value = "=Fields.PAC_Contribution_Rate";
            // 
            // party_AffiliationDataTextBox
            // 
            this.party_AffiliationDataTextBox.CanGrow = true;
            this.party_AffiliationDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(26.660421371459961), Telerik.Reporting.Drawing.Unit.Inch(7.8837074397597462E-05));
            this.party_AffiliationDataTextBox.Name = "party_AffiliationDataTextBox";
            this.party_AffiliationDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999200582504273), Telerik.Reporting.Drawing.Unit.Inch(0.43380507826805115));
            this.party_AffiliationDataTextBox.StyleName = "Data";
            this.party_AffiliationDataTextBox.Value = "=Fields.Party_Affiliation";
            // 
            // genderDataTextBox
            // 
            this.genderDataTextBox.CanGrow = true;
            this.genderDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(21.614580154418945), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505));
            this.genderDataTextBox.Name = "genderDataTextBox";
            this.genderDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.69992196559906), Telerik.Reporting.Drawing.Unit.Inch(0.41305056214332581));
            this.genderDataTextBox.StyleName = "Data";
            this.genderDataTextBox.Value = "=Fields.Gender";
            // 
            // pri_EmailDataTextBox
            // 
            this.pri_EmailDataTextBox.CanGrow = true;
            this.pri_EmailDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(20.014581680297852), Telerik.Reporting.Drawing.Unit.Inch(7.8837074397597462E-05));
            this.pri_EmailDataTextBox.Name = "pri_EmailDataTextBox";
            this.pri_EmailDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.59992253780365), Telerik.Reporting.Drawing.Unit.Inch(0.43380507826805115));
            this.pri_EmailDataTextBox.StyleName = "Data";
            this.pri_EmailDataTextBox.Value = "=Fields.Pri_Email";
            // 
            // marital_statusDataTextBox
            // 
            this.marital_statusDataTextBox.CanGrow = true;
            this.marital_statusDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(23.3145809173584), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505));
            this.marital_statusDataTextBox.Name = "marital_statusDataTextBox";
            this.marital_statusDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6457614898681641), Telerik.Reporting.Drawing.Unit.Inch(0.41305056214332581));
            this.marital_statusDataTextBox.StyleName = "Data";
            this.marital_statusDataTextBox.Value = "=Fields.Marital_status";
            // 
            // pri_PhoneDataTextBox
            // 
            this.pri_PhoneDataTextBox.CanGrow = true;
            this.pri_PhoneDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(18.314582824707031), Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505));
            this.pri_PhoneDataTextBox.Name = "pri_PhoneDataTextBox";
            this.pri_PhoneDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999202966690064), Telerik.Reporting.Drawing.Unit.Inch(0.41305056214332581));
            this.pri_PhoneDataTextBox.StyleName = "Data";
            this.pri_PhoneDataTextBox.Value = "=Fields.Pri_Phone";
            // 
            // pri_StateDataTextBox
            // 
            this.pri_StateDataTextBox.CanGrow = true;
            this.pri_StateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.422924995422363), Telerik.Reporting.Drawing.Unit.Inch(7.8837074397597462E-05));
            this.pri_StateDataTextBox.Name = "pri_StateDataTextBox";
            this.pri_StateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6999210119247437), Telerik.Reporting.Drawing.Unit.Inch(0.43380507826805115));
            this.pri_StateDataTextBox.StyleName = "Data";
            this.pri_StateDataTextBox.Value = "=Fields.Pri_State";
            // 
            // pri_CityDataTextBox
            // 
            this.pri_CityDataTextBox.CanGrow = true;
            this.pri_CityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.765934944152832), Telerik.Reporting.Drawing.Unit.Inch(7.8837074397597462E-05));
            this.pri_CityDataTextBox.Name = "pri_CityDataTextBox";
            this.pri_CityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6569118499755859), Telerik.Reporting.Drawing.Unit.Inch(0.43380507826805115));
            this.pri_CityDataTextBox.StyleName = "Data";
            this.pri_CityDataTextBox.Value = "=Fields.Pri_City";
            // 
            // sSNDataTextBox
            // 
            this.sSNDataTextBox.CanGrow = true;
            this.sSNDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8425467014312744), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.sSNDataTextBox.Name = "sSNDataTextBox";
            this.sSNDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.2574539184570312), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.sSNDataTextBox.StyleName = "Data";
            this.sSNDataTextBox.Value = "=Fields.SSN";
            // 
            // report_DateDataTextBox
            // 
            this.report_DateDataTextBox.CanGrow = true;
            this.report_DateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6821236610412598), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.report_DateDataTextBox.Name = "report_DateDataTextBox";
            this.report_DateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1603442430496216), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.report_DateDataTextBox.StyleName = "Data";
            this.report_DateDataTextBox.Value = "=Fields.Report_Date";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.45463863015174866);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox2,
            this.textBox1,
            this.textBox3});
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.pageHeader.Style.Color = System.Drawing.Color.Maroon;
            this.pageHeader.Style.Font.Bold = true;
            this.pageHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.pageHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6821235418319702), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.1603444814682007), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "=Fields.Report_Date";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.6612114906311035), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "=Fields.Local_Number";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8425467014312744), Telerik.Reporting.Drawing.Unit.Inch(0.020715394988656044));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.2458887100219727), Telerik.Reporting.Drawing.Unit.Inch(0.4338839054107666));
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "MEMBERFILE";
            // 
            // ReportPercapita
            // 
            this.DataSource = this.sqlDataSource1;
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            this.labelsGroup});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.labelsGroupHeader,
            this.labelsGroupFooter,
            this.pageHeader,
            this.pageFooter,
            this.reportFooter,
            this.detail});
            this.Name = "ReportPercapita";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(48.804168701171875);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox local_NumberCaptionTextBox;
        private Telerik.Reporting.TextBox report_DateCaptionTextBox;
        private Telerik.Reporting.TextBox sSNCaptionTextBox;
        private Telerik.Reporting.TextBox lastNameCaptionTextBox;
        private Telerik.Reporting.TextBox firstNameCaptionTextBox;
        private Telerik.Reporting.TextBox initialCaptionTextBox;
        private Telerik.Reporting.TextBox pri_AddressCaptionTextBox;
        private Telerik.Reporting.TextBox pri_CityCaptionTextBox;
        private Telerik.Reporting.TextBox pri_StateCaptionTextBox;
        private Telerik.Reporting.TextBox pri_ZipCaptionTextBox;
        private Telerik.Reporting.TextBox countryCaptionTextBox;
        private Telerik.Reporting.TextBox pri_PhoneCaptionTextBox;
        private Telerik.Reporting.TextBox pri_EmailCaptionTextBox;
        private Telerik.Reporting.TextBox genderCaptionTextBox;
        private Telerik.Reporting.TextBox marital_statusCaptionTextBox;
        private Telerik.Reporting.TextBox voter_Registration_FlagCaptionTextBox;
        private Telerik.Reporting.TextBox party_AffiliationCaptionTextBox;
        private Telerik.Reporting.TextBox pAC_MembershipCaptionTextBox;
        private Telerik.Reporting.TextBox pAC_Contribution_RateCaptionTextBox;
        private Telerik.Reporting.TextBox pAC_Contribution_CycleCaptionTextBox;
        private Telerik.Reporting.TextBox shopIDCaptionTextBox;
        private Telerik.Reporting.TextBox member_ClassCaptionTextBox;
        private Telerik.Reporting.TextBox full_timeCaptionTextBox;
        private Telerik.Reporting.TextBox mail_FlagCaptionTextBox;
        private Telerik.Reporting.TextBox birthDateCaptionTextBox;
        private Telerik.Reporting.TextBox hiredDateCaptionTextBox;
        private Telerik.Reporting.TextBox affiliation_DateCaptionTextBox;
        private Telerik.Reporting.TextBox terminatedDateCaptionTextBox;
        private Telerik.Reporting.TextBox dues_RateCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox local_NumberDataTextBox;
        private Telerik.Reporting.TextBox report_DateDataTextBox;
        private Telerik.Reporting.TextBox sSNDataTextBox;
        private Telerik.Reporting.TextBox lastNameDataTextBox;
        private Telerik.Reporting.TextBox firstNameDataTextBox;
        private Telerik.Reporting.TextBox initialDataTextBox;
        private Telerik.Reporting.TextBox pri_AddressDataTextBox;
        private Telerik.Reporting.TextBox pri_CityDataTextBox;
        private Telerik.Reporting.TextBox pri_StateDataTextBox;
        private Telerik.Reporting.TextBox pri_ZipDataTextBox;
        private Telerik.Reporting.TextBox countryDataTextBox;
        private Telerik.Reporting.TextBox pri_PhoneDataTextBox;
        private Telerik.Reporting.TextBox pri_EmailDataTextBox;
        private Telerik.Reporting.TextBox genderDataTextBox;
        private Telerik.Reporting.TextBox marital_statusDataTextBox;
        private Telerik.Reporting.TextBox voter_Registration_FlagDataTextBox;
        private Telerik.Reporting.TextBox party_AffiliationDataTextBox;
        private Telerik.Reporting.TextBox pAC_MembershipDataTextBox;
        private Telerik.Reporting.TextBox pAC_Contribution_RateDataTextBox;
        private Telerik.Reporting.TextBox pAC_Contribution_CycleDataTextBox;
        private Telerik.Reporting.TextBox shopIDDataTextBox;
        private Telerik.Reporting.TextBox member_ClassDataTextBox;
        private Telerik.Reporting.TextBox full_timeDataTextBox;
        private Telerik.Reporting.TextBox mail_FlagDataTextBox;
        private Telerik.Reporting.TextBox birthDateDataTextBox;
        private Telerik.Reporting.TextBox hiredDateDataTextBox;
        private Telerik.Reporting.TextBox affiliation_DateDataTextBox;
        private Telerik.Reporting.TextBox terminatedDateDataTextBox;
        private Telerik.Reporting.TextBox dues_RateDataTextBox;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
    }
}