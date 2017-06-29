namespace Reports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for Hartford.
    /// </summary>
    public partial class Hartford : Telerik.Reporting.Report
    {
        public Hartford()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        private void genderDataTextBox_ItemDataBinding(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_ItemDataBound(object sender, EventArgs e)
        {

        }
    }
}