<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chart.aspx.cs" Inherits="WebApplicationJson.chart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

            <script src="https://unpkg.com/chart.js@2.8.0/dist/Chart.bundle.js"></script>
  <script src="https://unpkg.com/chartjs-gauge@0.3.0/dist/chartjs-gauge.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
          <asp:Literal ID="ltChart" runat="server"></asp:Literal>

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
