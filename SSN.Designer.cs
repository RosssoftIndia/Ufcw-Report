namespace Reports
{
    partial class SSN
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
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.file_TypeDataTextBox = new Telerik.Reporting.TextBox();
            this.report_DateDataTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.dataCountDataTextBox = new Telerik.Reporting.TextBox();
            this.local_NumberDataTextBox = new Telerik.Reporting.TextBox();
            this.textBox1 = new Telerik.Reporting.TextBox();
            this.textBox2 = new Telerik.Reporting.TextBox();
            this.textBox3 = new Telerik.Reporting.TextBox();
            this.textBox4 = new Telerik.Reporting.TextBox();
            this.textBox5 = new Telerik.Reporting.TextBox();
            this.textBox6 = new Telerik.Reporting.TextBox();
            this.textBox7 = new Telerik.Reporting.TextBox();
            this.textBox8 = new Telerik.Reporting.TextBox();
            this.textBox9 = new Telerik.Reporting.TextBox();
            this.textBox10 = new Telerik.Reporting.TextBox();
            this.textBox11 = new Telerik.Reporting.TextBox();
            this.textBox12 = new Telerik.Reporting.TextBox();
            this.textBox13 = new Telerik.Reporting.TextBox();
            this.textBox14 = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionString = "Reports.Properties.Settings.UFCWEntire";
            this.sqlDataSource1.Name = "sqlDataSource1";
            this.sqlDataSource1.SelectCommand = "dbo.SSN_Report_Sp";
            this.sqlDataSource1.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            // 
            // labelsGroupHeader
            // 
            this.labelsGroupHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.labelsGroupHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox4,
            this.textBox5,
            this.textBox6,
            this.textBox7,
            this.textBox8,
            this.textBox9,
            this.textBox10,
            this.textBox11,
            this.textBox12,
            this.textBox13,
            this.textBox14});
            this.labelsGroupHeader.Name = "labelsGroupHeader";
            this.labelsGroupHeader.PrintOnEveryPage = true;
            this.labelsGroupHeader.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelsGroupHeader.Style.Font.Bold = false;
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
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.pageFooter.Name = "pageFooter";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Inch(1.0372617244720459);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.file_TypeDataTextBox,
            this.local_NumberDataTextBox,
            this.report_DateDataTextBox});
            this.reportHeader.Name = "reportHeader";
            this.reportHeader.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.reportHeader.Style.Color = System.Drawing.Color.Maroon;
            this.reportHeader.Style.Font.Bold = true;
            this.reportHeader.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.reportHeader.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // file_TypeDataTextBox
            // 
            this.file_TypeDataTextBox.CanGrow = true;
            this.file_TypeDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8000783920288086), Telerik.Reporting.Drawing.Unit.Inch(0.770908534526825));
            this.file_TypeDataTextBox.Name = "file_TypeDataTextBox";
            this.file_TypeDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.7376577854156494), Telerik.Reporting.Drawing.Unit.Inch(0.26017862558364868));
            this.file_TypeDataTextBox.StyleName = "Data";
            this.file_TypeDataTextBox.Value = "=Fields.File_Type";
            // 
            // report_DateDataTextBox
            // 
            this.report_DateDataTextBox.CanGrow = true;
            this.report_DateDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000787734985352), Telerik.Reporting.Drawing.Unit.Inch(0.77502506971359253));
            this.report_DateDataTextBox.Name = "report_DateDataTextBox";
            this.report_DateDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.26223665475845337));
            this.report_DateDataTextBox.StyleName = "Data";
            this.report_DateDataTextBox.Value = "=Fields.Report_Date";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.reportFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.textBox1,
            this.dataCountDataTextBox,
            this.textBox2,
            this.textBox3});
            this.reportFooter.Name = "reportFooter";
            this.reportFooter.Style.BackgroundColor = System.Drawing.Color.Silver;
            this.reportFooter.Style.Color = System.Drawing.Color.Maroon;
            this.reportFooter.Style.Font.Bold = true;
            this.reportFooter.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Center;
            this.reportFooter.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Inch(0.28125);
            this.detail.Name = "detail";
            // 
            // dataCountDataTextBox
            // 
            this.dataCountDataTextBox.CanGrow = true;
            this.dataCountDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.4207553863525391), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.dataCountDataTextBox.Name = "dataCountDataTextBox";
            this.dataCountDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791671991348267), Telerik.Reporting.Drawing.Unit.Inch(0.28121048212051392));
            this.dataCountDataTextBox.StyleName = "Data";
            this.dataCountDataTextBox.Value = "=Fields.DataCount";
            // 
            // local_NumberDataTextBox
            // 
            this.local_NumberDataTextBox.CanGrow = true;
            this.local_NumberDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505), Telerik.Reporting.Drawing.Unit.Inch(0.77502506971359253));
            this.local_NumberDataTextBox.Name = "local_NumberDataTextBox";
            this.local_NumberDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.2560620903968811));
            this.local_NumberDataTextBox.StyleName = "Data";
            this.local_NumberDataTextBox.Value = "=Fields.Local_Number";
            // 
            // textBox1
            // 
            this.textBox1.CanGrow = true;
            this.textBox1.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox1.Name = "local_NumberDataTextBox";
            this.textBox1.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3999999761581421), Telerik.Reporting.Drawing.Unit.Inch(0.2560620903968811));
            this.textBox1.StyleName = "Data";
            this.textBox1.Value = "=Fields.Local_Number";
            // 
            // textBox2
            // 
            this.textBox2.CanGrow = true;
            this.textBox2.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.8999998569488525), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(2.5206766128540039), Telerik.Reporting.Drawing.Unit.Inch(0.26017862558364868));
            this.textBox2.StyleName = "Data";
            this.textBox2.Value = "=Fields.File_Type";
            // 
            // textBox3
            // 
            this.textBox3.CanGrow = true;
            this.textBox3.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.5), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.0999212265014648), Telerik.Reporting.Drawing.Unit.Inch(0.26223665475845337));
            this.textBox3.StyleName = "Data";
            this.textBox3.Value = "=Fields.Report_Date";
            // 
            // textBox4
            // 
            this.textBox4.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(0.02083333395421505), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox4.Value = "Local Number";
            // 
            // textBox5
            // 
            this.textBox5.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(4.1585698127746582), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox5.Value = "Last Name";
            // 
            // textBox6
            // 
            this.textBox6.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(1.4000787734985352), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox6.Value = "Report Date";
            // 
            // textBox7
            // 
            this.textBox7.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(2.7793242931365967), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox7.Value = "SIN/SSN";
            // 
            // textBox8
            // 
            this.textBox8.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(5.5378150939941406), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox8.Value = "First Name";
            // 
            // textBox9
            // 
            this.textBox9.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(6.9170608520507812), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox9.Value = "Middle Initial";
            // 
            // textBox10
            // 
            this.textBox10.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(8.2963066101074219), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox10.Value = "Old SIN/SSN";
            // 
            // textBox11
            // 
            this.textBox11.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(9.6755533218383789), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox11.Value = "Unused";
            // 
            // textBox12
            // 
            this.textBox12.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(11.054798126220703), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox12.Value = "Old Last Name";
            // 
            // textBox13
            // 
            this.textBox13.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(12.434043884277344), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox13.Value = "Old First Name";
            // 
            // textBox14
            // 
            this.textBox14.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Inch(13.813289642333984), Telerik.Reporting.Drawing.Unit.Inch(0));
            this.textBox14.Name = "textBox11";
            this.textBox14.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Inch(1.3791666030883789), Telerik.Reporting.Drawing.Unit.Inch(0.28121057152748108));
            this.textBox14.Value = "Old initial";
            // 
            // SSN
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
            this.Name = "SSN";
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
            this.Width = Telerik.Reporting.Drawing.Unit.Inch(15.700000762939453);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource sqlDataSource1;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeader;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooter;
        private Telerik.Reporting.Group labelsGroup;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox file_TypeDataTextBox;
        private Telerik.Reporting.TextBox report_DateDataTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox textBox1;
        private Telerik.Reporting.TextBox textBox2;
        private Telerik.Reporting.TextBox dataCountDataTextBox;
        private Telerik.Reporting.TextBox textBox3;
        private Telerik.Reporting.TextBox local_NumberDataTextBox;
        private Telerik.Reporting.TextBox textBox4;
        private Telerik.Reporting.TextBox textBox5;
        private Telerik.Reporting.TextBox textBox6;
        private Telerik.Reporting.TextBox textBox7;
        private Telerik.Reporting.TextBox textBox8;
        private Telerik.Reporting.TextBox textBox9;
        private Telerik.Reporting.TextBox textBox10;
        private Telerik.Reporting.TextBox textBox11;
        private Telerik.Reporting.TextBox textBox12;
        private Telerik.Reporting.TextBox textBox13;
        private Telerik.Reporting.TextBox textBox14;

    }
}