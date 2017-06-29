namespace Reports
{
    partial class ReportGPP
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
            this.memberIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.firstNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.lastNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.sSNCaptionTextBox = new Telerik.Reporting.TextBox();
            this.dOBCaptionTextBox = new Telerik.Reporting.TextBox();
            this.cityCaptionTextBox = new Telerik.Reporting.TextBox();
            this.stateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.zipCaptionTextBox = new Telerik.Reporting.TextBox();
            this.addressCaptionTextBox = new Telerik.Reporting.TextBox();
            this.shopCaptionTextBox = new Telerik.Reporting.TextBox();
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
            this.memberIDDataTextBox = new Telerik.Reporting.TextBox();
            this.firstNameDataTextBox = new Telerik.Reporting.TextBox();
            this.lastNameDataTextBox = new Telerik.Reporting.TextBox();
            this.sSNDataTextBox = new Telerik.Reporting.TextBox();
            this.addressDataTextBox = new Telerik.Reporting.TextBox();
            this.cityDataTextBox = new Telerik.Reporting.TextBox();
            this.stateDataTextBox = new Telerik.Reporting.TextBox();
            this.zipDataTextBox = new Telerik.Reporting.TextBox();
            this.shopDataTextBox = new Telerik.Reporting.TextBox();
            this.dOBDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.ReportGPP_sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30204382538795471);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.memberIDCaptionTextBox,
            this.firstNameCaptionTextBox,
            this.lastNameCaptionTextBox,
            this.sSNCaptionTextBox,
            this.dOBCaptionTextBox,
            this.cityCaptionTextBox,
            this.stateCaptionTextBox,
            this.zipCaptionTextBox,
            this.addressCaptionTextBox,
            this.shopCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelsGroupHeader.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelsGroupHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.labelsGroupHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // memberIDCaptionTextBox
            // 
            this.memberIDCaptionTextBox.CanGrow = true;
            this.memberIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.memberIDCaptionTextBox.Name = "memberIDCaptionTextBox";
            this.memberIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5998817682266235), Telerik.Reporting.Drawing.Unit.Inch(0.3019651472568512));
            this.memberIDCaptionTextBox.Style.Font.Name = "Arial";
            this.memberIDCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.memberIDCaptionTextBox.StyleName = "Caption";
            this.memberIDCaptionTextBox.Value = "Member ID";
            // 
            // firstNameCaptionTextBox
            // 
            this.firstNameCaptionTextBox.CanGrow = true;
            this.firstNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.firstNameCaptionTextBox.Name = "firstNameCaptionTextBox";
            this.firstNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999210596084595), Telerik.Reporting.Drawing.Unit.Inch(0.3019651472568512));
            this.firstNameCaptionTextBox.StyleName = "Caption";
            this.firstNameCaptionTextBox.Value = "First Name";
            // 
            // lastNameCaptionTextBox
            // 
            this.lastNameCaptionTextBox.CanGrow = true;
            this.lastNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameCaptionTextBox.Name = "lastNameCaptionTextBox";
            this.lastNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4998435974121094), Telerik.Reporting.Drawing.Unit.Inch(0.3019651472568512));
            this.lastNameCaptionTextBox.StyleName = "Caption";
            this.lastNameCaptionTextBox.Value = "Last Name";
            // 
            // sSNCaptionTextBox
            // 
            this.sSNCaptionTextBox.CanGrow = true;
            this.sSNCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4999222755432129), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.sSNCaptionTextBox.Name = "sSNCaptionTextBox";
            this.sSNCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4999994039535523), Telerik.Reporting.Drawing.Unit.Inch(0.3019651472568512));
            this.sSNCaptionTextBox.StyleName = "Caption";
            this.sSNCaptionTextBox.Value = "SSN";
            // 
            // dOBCaptionTextBox
            // 
            this.dOBCaptionTextBox.CanGrow = true;
            this.dOBCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0000004768371582), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.dOBCaptionTextBox.Name = "dOBCaptionTextBox";
            this.dOBCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3998407125473023), Telerik.Reporting.Drawing.Unit.Inch(0.30204397439956665));
            this.dOBCaptionTextBox.StyleName = "Caption";
            this.dOBCaptionTextBox.Value = "DOB";
            // 
            // cityCaptionTextBox
            // 
            this.cityCaptionTextBox.CanGrow = true;
            this.cityCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.800000190734863), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05));
            this.cityCaptionTextBox.Name = "cityCaptionTextBox";
            this.cityCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999190807342529), Telerik.Reporting.Drawing.Unit.Inch(0.30200457572937012));
            this.cityCaptionTextBox.StyleName = "Caption";
            this.cityCaptionTextBox.Value = "City";
            // 
            // stateCaptionTextBox
            // 
            this.stateCaptionTextBox.CanGrow = true;
            this.stateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.899998664855957), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.stateCaptionTextBox.Name = "stateCaptionTextBox";
            this.stateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.99992185831069946), Telerik.Reporting.Drawing.Unit.Inch(0.30204397439956665));
            this.stateCaptionTextBox.StyleName = "Caption";
            this.stateCaptionTextBox.Value = "State";
            // 
            // zipCaptionTextBox
            // 
            this.zipCaptionTextBox.CanGrow = true;
            this.zipCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.90000057220459), Telerik.Reporting.Drawing.Unit.Inch(3.9339065551757812E-05));
            this.zipCaptionTextBox.Name = "zipCaptionTextBox";
            this.zipCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4957956075668335), Telerik.Reporting.Drawing.Unit.Inch(0.30200442671775818));
            this.zipCaptionTextBox.StyleName = "Caption";
            this.zipCaptionTextBox.Value = "Zip";
            // 
            // addressCaptionTextBox
            // 
            this.addressCaptionTextBox.CanGrow = true;
            this.addressCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.3999996185302734), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.addressCaptionTextBox.Name = "addressCaptionTextBox";
            this.addressCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3999221324920654), Telerik.Reporting.Drawing.Unit.Inch(0.30204397439956665));
            this.addressCaptionTextBox.StyleName = "Caption";
            this.addressCaptionTextBox.Value = "Address";
            // 
            // shopCaptionTextBox
            // 
            this.shopCaptionTextBox.CanGrow = true;
            this.shopCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.3999199867248535), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopCaptionTextBox.Name = "shopCaptionTextBox";
            this.shopCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.0000007152557373), Telerik.Reporting.Drawing.Unit.Inch(0.30204397439956665));
            this.shopCaptionTextBox.StyleName = "Caption";
            this.shopCaptionTextBox.Value = "Shop";
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
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(4.7000002861022949), Telerik.Reporting.Drawing.Unit.Inch(0.82898944616317749));
            this.titleTextBox.Style.Color = System.Drawing.Color.Maroon;
            this.titleTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "UFCW Local 312 Health Fund - GPP";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.100001335144043), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2957942485809326), Telerik.Reporting.Drawing.Unit.Inch(0.40000000596046448));
            this.textBox1.Style.Font.Bold = true;
            this.textBox1.Style.Font.Name = "Tahoma";
            this.textBox1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18);
            this.textBox1.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox1.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox1.StyleName = "PageInfo";
            this.textBox1.Value = "= Today().ToString(\"MM-dd-yyyy\")";
            // 
            // textBox2
            // 
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.100001335144043), Telerik.Reporting.Drawing.Unit.Inch(0.40007865428924561));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.2957947254180908), Telerik.Reporting.Drawing.Unit.Inch(0.42883181571960449));
            this.textBox2.Style.Font.Bold = true;
            this.textBox2.Style.Font.Name = "Tahoma";
            this.textBox2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18);
            this.textBox2.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.textBox2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.textBox2.Value = "Count : {Count(Fields.Shop)}";
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
            this.memberIDDataTextBox,
            this.firstNameDataTextBox,
            this.lastNameDataTextBox,
            this.sSNDataTextBox,
            this.addressDataTextBox,
            this.cityDataTextBox,
            this.stateDataTextBox,
            this.zipDataTextBox,
            this.shopDataTextBox,
            this.dOBDataTextBox});
            this.detail.Name = "detail";
            this.detail.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // memberIDDataTextBox
            // 
            this.memberIDDataTextBox.CanGrow = true;
            this.memberIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.memberIDDataTextBox.Name = "memberIDDataTextBox";
            this.memberIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5998817682266235), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.memberIDDataTextBox.StyleName = "Data";
            this.memberIDDataTextBox.Value = "=Fields.MemberID";
            // 
            // firstNameDataTextBox
            // 
            this.firstNameDataTextBox.CanGrow = true;
            this.firstNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.6000000238418579), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.firstNameDataTextBox.Name = "firstNameDataTextBox";
            this.firstNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999210596084595), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.firstNameDataTextBox.StyleName = "Data";
            this.firstNameDataTextBox.Value = "=Fields.FirstName";
            // 
            // lastNameDataTextBox
            // 
            this.lastNameDataTextBox.CanGrow = true;
            this.lastNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameDataTextBox.Name = "lastNameDataTextBox";
            this.lastNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4998435974121094), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.lastNameDataTextBox.StyleName = "Data";
            this.lastNameDataTextBox.Value = "=Fields.LastName";
            // 
            // sSNDataTextBox
            // 
            this.sSNDataTextBox.CanGrow = true;
            this.sSNDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.4999222755432129), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.sSNDataTextBox.Name = "sSNDataTextBox";
            this.sSNDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4999994039535523), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.sSNDataTextBox.StyleName = "Data";
            this.sSNDataTextBox.Value = "= IIf(IsNull(Fields.SSN,0)>0,Substr(Fields.SSN,0,3)+\"-\"+Substr(Fields.SSN,3,2)+\"-" +
                "\"+Substr(Fields.SSN,5,4),\"\") ";
            // 
            // addressDataTextBox
            // 
            this.addressDataTextBox.CanGrow = true;
            this.addressDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.3999996185302734), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.addressDataTextBox.Name = "addressDataTextBox";
            this.addressDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.3999221324920654), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.addressDataTextBox.StyleName = "Data";
            this.addressDataTextBox.Value = "=Fields.Address";
            // 
            // cityDataTextBox
            // 
            this.cityDataTextBox.CanGrow = true;
            this.cityDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.800000190734863), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.cityDataTextBox.Name = "cityDataTextBox";
            this.cityDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.099920392036438), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.cityDataTextBox.StyleName = "Data";
            this.cityDataTextBox.Value = "=Fields.City";
            // 
            // stateDataTextBox
            // 
            this.stateDataTextBox.CanGrow = true;
            this.stateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.899998664855957), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.stateDataTextBox.Name = "stateDataTextBox";
            this.stateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(0.999998152256012), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.stateDataTextBox.StyleName = "Data";
            this.stateDataTextBox.Value = "=Fields.State";
            // 
            // zipDataTextBox
            // 
            this.zipDataTextBox.CanGrow = true;
            this.zipDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.90000057220459), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.zipDataTextBox.Name = "zipDataTextBox";
            this.zipDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4957942962646484), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.zipDataTextBox.StyleName = "Data";
            this.zipDataTextBox.Value = "=Fields.Zip";
            // 
            // shopDataTextBox
            // 
            this.shopDataTextBox.CanGrow = true;
            this.shopDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(7.39992094039917), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopDataTextBox.Name = "shopDataTextBox";
            this.shopDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.shopDataTextBox.StyleName = "Data";
            this.shopDataTextBox.Value = "=Fields.Shop";
            // 
            // dOBDataTextBox
            // 
            this.dOBDataTextBox.CanGrow = true;
            this.dOBDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.0000004768371582), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.dOBDataTextBox.Name = "dOBDataTextBox";
            this.dOBDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3998407125473023), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.dOBDataTextBox.StyleName = "Data";
            this.dOBDataTextBox.Value = "=Fields.DOB";
            // 
            // ReportGPP
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
            this.Name = "GPP";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(15.395835876464844);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox memberIDCaptionTextBox;
        private Telerik.Reporting.TextBox firstNameCaptionTextBox;
        private Telerik.Reporting.TextBox lastNameCaptionTextBox;
        private Telerik.Reporting.TextBox sSNCaptionTextBox;
        private Telerik.Reporting.TextBox dOBCaptionTextBox;
        private Telerik.Reporting.TextBox shopCaptionTextBox;
        private Telerik.Reporting.TextBox addressCaptionTextBox;
        private Telerik.Reporting.TextBox cityCaptionTextBox;
        private Telerik.Reporting.TextBox stateCaptionTextBox;
        private Telerik.Reporting.TextBox zipCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox memberIDDataTextBox;
        private Telerik.Reporting.TextBox firstNameDataTextBox;
        private Telerik.Reporting.TextBox lastNameDataTextBox;
        private Telerik.Reporting.TextBox sSNDataTextBox;
        private Telerik.Reporting.TextBox dOBDataTextBox;
        private Telerik.Reporting.TextBox shopDataTextBox;
        private Telerik.Reporting.TextBox addressDataTextBox;
        private Telerik.Reporting.TextBox cityDataTextBox;
        private Telerik.Reporting.TextBox stateDataTextBox;
        private Telerik.Reporting.TextBox zipDataTextBox;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
    }
}