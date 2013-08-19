<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Produto>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Gerenciar Produto</h2>

<p>
    <%: Html.ActionLink("Inserir Novo", "Create") %>
</p>
<table>
    <tr>
        <th>
            Codigo
        </th>
        <th>
            CodigoBarra
        </th>
        <th>
            Nome
        </th>
        <th>
            Quantidade
        </th>
        <th>
            Valor
        </th>
        <th>
            QuantidadeMinima
        </th>
        <th>
            PrecoCusto
        </th>
        <th>
            PrecoVenda
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Codigo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CodigoBarra) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Quantidade) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Valor) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.QuantidadeMinima) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.PrecoCusto) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.PrecoVenda) %>
        </td>
        <td>
            <%: Html.ActionLink("Edit", "Edit", new {  id=item.Codigo }) %> |
            <%: Html.ActionLink("Details", "Details", new {  id=item.Codigo }) %> |
            <%: Html.ActionLink("Delete", "Delete", new {  id=item.Codigo }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
