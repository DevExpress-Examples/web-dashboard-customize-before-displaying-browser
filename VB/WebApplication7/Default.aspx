﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication7.Default" %>

<%@ Register Assembly="DevExpress.Dashboard.v18.2.Web.WebForms, Version=18.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.DashboardWeb" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxDashboard ID="ASPxDashboard1" runat="server" OnDashboardLoading="ASPxDashboard1_DashboardLoading"></dx:ASPxDashboard>
        </div>
    </form>
</body>
</html>
