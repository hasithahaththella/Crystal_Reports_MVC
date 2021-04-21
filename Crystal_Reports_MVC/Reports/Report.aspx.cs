using Crystal_Reports_MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Crystal_Reports_MVC.Reports
{
    public partial class Report : System.Web.UI.Page
    {
protected void Page_Load(object sender, EventArgs e)
{
    CrystalReportViewer1.ToolPanelView = CrystalDecisions.Web.ToolPanelViewType.None;
    CustomerReport crystalReport = new CustomerReport();
    NorthwindEntities entities = new NorthwindEntities();
    crystalReport.SetDataSource(from customer in entities.Customers.Take(10)
                                    select customer);
    CrystalReportViewer1.ReportSource = crystalReport;
    CrystalReportViewer1.RefreshReport();
}
    }
}