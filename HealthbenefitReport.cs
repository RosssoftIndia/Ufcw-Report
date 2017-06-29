namespace Reports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for Health_Benefit_Reports.
    /// </summary>
    public partial class HealthBenefitReport : Telerik.Reporting.Report
    {
        public HealthBenefitReport(string Benefit)
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

           this.ReportParameters["Benefit"].Value = Benefit;
          
            
        }
    }
}