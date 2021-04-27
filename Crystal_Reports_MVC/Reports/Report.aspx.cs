using Crystal_Reports_MVC;
using CrystalDecisions.Shared;
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

            ListOfCustomers crystalReport = new ListOfCustomers();

            string dbUser = "";
            string dbPassword = "";
            string server = "";
            string database = "";

            foreach (CrystalDecisions.Shared.IConnectionInfo dsc in crystalReport.DataSourceConnections)
            {
                dsc.SetLogon(dbUser, dbPassword);
                dsc.SetConnection(server, database, false);
            }

            crystalReport.SetDatabaseLogon(dbUser, dbPassword);

            foreach (CrystalDecisions.CrystalReports.Engine.Table table in crystalReport.Database.Tables)
            {
                table.LogOnInfo.ConnectionInfo.UserID = dbUser;
                table.LogOnInfo.ConnectionInfo.Password = dbPassword;
                table.LogOnInfo.ConnectionInfo.ServerName = server;
                table.LogOnInfo.ConnectionInfo.DatabaseName = database;
            }

            // Set to sub reports

            CrystalReportViewer1.ReportSource = crystalReport;
            CrystalReportViewer1.RefreshReport();
        }
    }
}