namespace Reports
{
    partial class MemberBenefitsSearch
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
            this.memberIDCaptionTextBox = new Telerik.Reporting.TextBox();
            this.firstNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.lastNameCaptionTextBox = new Telerik.Reporting.TextBox();
            this.shopCaptionTextBox = new Telerik.Reporting.TextBox();
            this.birthDateCaptionTextBox = new Telerik.Reporting.TextBox();
            this.genderCaptionTextBox = new Telerik.Reporting.TextBox();
            this.applicableToCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.memberIDDataTextBox = new Telerik.Reporting.TextBox();
            this.firstNameDataTextBox = new Telerik.Reporting.TextBox();
            this.lastNameDataTextBox = new Telerik.Reporting.TextBox();
            this.shopDataTextBox = new Telerik.Reporting.TextBox();
            this.birthDateDataTextBox = new Telerik.Reporting.TextBox();
            this.genderDataTextBox = new Telerik.Reporting.TextBox();
            this.applicableToDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.ReportMemberBenefits_sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.memberIDCaptionTextBox,
            this.firstNameCaptionTextBox,
            this.lastNameCaptionTextBox,
            this.shopCaptionTextBox,
            this.birthDateCaptionTextBox,
            this.genderCaptionTextBox,
            this.applicableToCaptionTextBox});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelsGroupHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.labelsGroupHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
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
            // memberIDCaptionTextBox
            // 
            this.memberIDCaptionTextBox.CanGrow = true;
            this.memberIDCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.memberIDCaptionTextBox.Name = "memberIDCaptionTextBox";
            this.memberIDCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.5), Telerik.Reporting.Drawing.Unit.Inch(0.30200454592704773));
            this.memberIDCaptionTextBox.StyleName = "Caption";
            this.memberIDCaptionTextBox.Value = "Member ID";
            // 
            // firstNameCaptionTextBox
            // 
            this.firstNameCaptionTextBox.CanGrow = true;
            this.firstNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5000787973403931), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.firstNameCaptionTextBox.Name = "firstNameCaptionTextBox";
            this.firstNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999214172363281), Telerik.Reporting.Drawing.Unit.Inch(0.30192571878433228));
            this.firstNameCaptionTextBox.StyleName = "Caption";
            this.firstNameCaptionTextBox.Value = "First Name";
            // 
            // lastNameCaptionTextBox
            // 
            this.lastNameCaptionTextBox.CanGrow = true;
            this.lastNameCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4000790119171143), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameCaptionTextBox.Name = "lastNameCaptionTextBox";
            this.lastNameCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999215364456177), Telerik.Reporting.Drawing.Unit.Inch(0.3019651472568512));
            this.lastNameCaptionTextBox.StyleName = "Caption";
            this.lastNameCaptionTextBox.Value = "Last Name";
            // 
            // shopCaptionTextBox
            // 
            this.shopCaptionTextBox.CanGrow = true;
            this.shopCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.300079345703125), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopCaptionTextBox.Name = "shopCaptionTextBox";
            this.shopCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.9998424053192139), Telerik.Reporting.Drawing.Unit.Inch(0.3019651472568512));
            this.shopCaptionTextBox.StyleName = "Caption";
            this.shopCaptionTextBox.Value = "Shop";
            // 
            // birthDateCaptionTextBox
            // 
            this.birthDateCaptionTextBox.CanGrow = true;
            this.birthDateCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.3000001907348633), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.birthDateCaptionTextBox.Name = "birthDateCaptionTextBox";
            this.birthDateCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1000003814697266), Telerik.Reporting.Drawing.Unit.Inch(0.3019651472568512));
            this.birthDateCaptionTextBox.StyleName = "Caption";
            this.birthDateCaptionTextBox.Value = "Birth Date";
            // 
            // genderCaptionTextBox
            // 
            this.genderCaptionTextBox.CanGrow = true;
            this.genderCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.400080680847168), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.genderCaptionTextBox.Name = "genderCaptionTextBox";
            this.genderCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999213695526123), Telerik.Reporting.Drawing.Unit.Inch(0.30192571878433228));
            this.genderCaptionTextBox.StyleName = "Caption";
            this.genderCaptionTextBox.Value = "Gender";
            // 
            // applicableToCaptionTextBox
            // 
            this.applicableToCaptionTextBox.CanGrow = true;
            this.applicableToCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.600079536437988), Telerik.Reporting.Drawing.Unit.Inch(3.9418537198798731E-05));
            this.applicableToCaptionTextBox.Name = "applicableToCaptionTextBox";
            this.applicableToCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6998817920684814), Telerik.Reporting.Drawing.Unit.Inch(0.30192571878433228));
            this.applicableToCaptionTextBox.StyleName = "Caption";
            this.applicableToCaptionTextBox.Value = "Applicable To";
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
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(3.1979167461395264), Telerik.Reporting.Drawing.Unit.Inch(0.28117138147354126));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Left;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.82898944616317749);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.reportHeader.Style.BackgroundImage.Repeat = Telerik.Reporting.Drawing.BackgroundRepeat.NoRepeat;
            this.reportHeader.Style.Color = System.Drawing.Color.Maroon;
            this.reportHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.reportHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(5.6000003814697266), Telerik.Reporting.Drawing.Unit.Inch(0.82894998788833618));
            this.titleTextBox.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.titleTextBox.Style.Color = System.Drawing.Color.Maroon;
            this.titleTextBox.Style.Font.Bold = true;
            this.titleTextBox.Style.Font.Name = "Tahoma";
            this.titleTextBox.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18);
            this.titleTextBox.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "MemberBenefitsSearch";
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
            this.applicableToDataTextBox,
            this.genderDataTextBox,
            this.birthDateDataTextBox,
            this.shopDataTextBox,
            this.lastNameDataTextBox,
            this.firstNameDataTextBox});
            this.detail.Name = "detail";
            this.detail.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.detail.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.detail.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // memberIDDataTextBox
            // 
            this.memberIDDataTextBox.CanGrow = true;
            this.memberIDDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.9378803194267675E-05), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.memberIDDataTextBox.Name = "memberIDDataTextBox";
            this.memberIDDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.4999607801437378), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.memberIDDataTextBox.StyleName = "Data";
            this.memberIDDataTextBox.Value = "=Fields.MemberID";
            // 
            // firstNameDataTextBox
            // 
            this.firstNameDataTextBox.CanGrow = true;
            this.firstNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5000787973403931), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.firstNameDataTextBox.Name = "firstNameDataTextBox";
            this.firstNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999214172363281), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.firstNameDataTextBox.StyleName = "Data";
            this.firstNameDataTextBox.Value = "=Fields.FirstName";
            // 
            // lastNameDataTextBox
            // 
            this.lastNameDataTextBox.CanGrow = true;
            this.lastNameDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(3.4000790119171143), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.lastNameDataTextBox.Name = "lastNameDataTextBox";
            this.lastNameDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.8999214172363281), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.lastNameDataTextBox.StyleName = "Data";
            this.lastNameDataTextBox.Value = "=Fields.LastName";
            // 
            // shopDataTextBox
            // 
            this.shopDataTextBox.CanGrow = true;
            this.shopDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.300079345703125), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.shopDataTextBox.Name = "shopDataTextBox";
            this.shopDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.9998431205749512), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.shopDataTextBox.StyleName = "Data";
            this.shopDataTextBox.Value = "=Fields.Shop";
            // 
            // birthDateDataTextBox
            // 
            this.birthDateDataTextBox.CanGrow = true;
            this.birthDateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.3000001907348633), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.birthDateDataTextBox.Name = "birthDateDataTextBox";
            this.birthDateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1000003814697266), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.birthDateDataTextBox.StyleName = "Data";
            this.birthDateDataTextBox.Value = "=Fields.BirthDate";
            // 
            // genderDataTextBox
            // 
            this.genderDataTextBox.CanGrow = true;
            this.genderDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(10.400080680847168), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.genderDataTextBox.Name = "genderDataTextBox";
            this.genderDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.1999199390411377), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.genderDataTextBox.StyleName = "Data";
            this.genderDataTextBox.Value = "= IIf((Fields.Gender)=0,\"Male\",\"Female\")";
            // 
            // applicableToDataTextBox
            // 
            this.applicableToDataTextBox.CanGrow = true;
            this.applicableToDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.600079536437988), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.applicableToDataTextBox.Name = "applicableToDataTextBox";
            this.applicableToDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.6998832225799561), Telerik.Reporting.Drawing.Unit.Inch(0.28121063113212585));
            this.applicableToDataTextBox.StyleName = "Data";
            this.applicableToDataTextBox.Value = "= IIf((Fields.ApplicableTo)=0,\"Single\",\"Family\")";
            // 
            // MemberBenefitsSearch
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
            this.Name = "MemberBenefitsSearch";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(15.300000190734863);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.TextBox memberIDCaptionTextBox;
        private Telerik.Reporting.TextBox firstNameCaptionTextBox;
        private Telerik.Reporting.TextBox lastNameCaptionTextBox;
        private Telerik.Reporting.TextBox shopCaptionTextBox;
        private Telerik.Reporting.TextBox birthDateCaptionTextBox;
        private Telerik.Reporting.TextBox genderCaptionTextBox;
        private Telerik.Reporting.TextBox applicableToCaptionTextBox;
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
        private Telerik.Reporting.TextBox shopDataTextBox;
        private Telerik.Reporting.TextBox birthDateDataTextBox;
        private Telerik.Reporting.TextBox genderDataTextBox;
        private Telerik.Reporting.TextBox applicableToDataTextBox;

    }
}