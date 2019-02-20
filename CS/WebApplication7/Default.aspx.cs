using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DataAccess.Sql;
using System;
using System.Linq;

namespace WebApplication7 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            ASPxDashboard1.AllowExecutingCustomSql = true;
            ASPxDashboard1.SetDashboardStorage(new DashboardFileStorage("~/App_Data/Dashboards"));
        }

        protected void ASPxDashboard1_DashboardLoading(object sender, DevExpress.DashboardWeb.DashboardLoadingWebEventArgs e) {
            if (e.DashboardId == "dashboard0") {
                Dashboard dashboard = new Dashboard();
                dashboard.LoadFromXDocument(e.DashboardXml);
                // customization code
                var parameterCountry = dashboard.Parameters.FirstOrDefault(p => p.Name == "CountryDashboardParameter");
                if (parameterCountry != null) {
                    parameterCountry.Value = "Germany";
                }
                var nwindDataSource = dashboard.DataSources.OfType<DashboardSqlDataSource>().FirstOrDefault(ds => ds.Name == "NwindDataSource");
                if (nwindDataSource != null) {
                    var customNwindQuery = nwindDataSource.Queries.OfType<CustomSqlQuery>().FirstOrDefault(q => q.Name == "CustomInvoicesQuery");
                    if (customNwindQuery != null) {
                        customNwindQuery.Sql += " AND (Invoices.OrderDate >= #2015-01-01 00:00:00#)";
                    }
                }
                //...
                e.DashboardXml = dashboard.SaveToXDocument();
            }
        }
    }
}