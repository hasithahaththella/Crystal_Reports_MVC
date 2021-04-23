<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Report.aspx.cs" Inherits="Crystal_Reports_MVC.Reports.Report" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src='<%=ResolveUrl("~/content/crystalreportviewers14/js/crviewer/crv.js")%>' type="text/javascript"></script>
   
</head>
<body>
     <script>
         function afterPageLoad() {
             alert('hello');
         }

         window.onload = function afterPageLoad();

     </script>
    <form id="form1" runat="server">
        <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="true" Height="800" Width="1200" />
    </form>
</body>
</html>
