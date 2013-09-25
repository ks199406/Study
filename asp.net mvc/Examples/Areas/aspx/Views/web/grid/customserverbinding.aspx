<%@ Page Title="" Language="C#" MasterPageFile="~/Areas/aspx/Views/Shared/Web.Master" Inherits="System.Web.Mvc.ViewPage<System.Collections.IEnumerable>" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
<%: Html.Kendo().Grid<Domas.Web.Mvc.Examples.Models.Order>()
    .Name("Grid")
    .EnableCustomBinding(true)
    .BindTo(Model)
    .Columns(columns =>
    {
        columns.Bound(o => o.OrderID).Groupable(false);
        columns.Bound(o => o.ShipCity);
        columns.Bound(o => o.ShipCountry);
        columns.Bound(o => o.ShipName);
    })
    .Pageable()
    .Sortable()
    .Filterable()
    .Scrollable()
    .Groupable()
    .DataSource(dataSource => dataSource.Server().Total((int)ViewData["total"]))
%>
</asp:Content>
