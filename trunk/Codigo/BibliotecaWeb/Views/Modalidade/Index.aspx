<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Modalidade>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Gerenciar Modalidade</h2>

<p>
    <%: Html.ActionLink("Inserir Nova", "Create") %>
</p>
<table>
    <tr>
        <th>
            Código
        </th>
        <th>
            Nome
        </th>
        <th>
            Valor
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Codigo) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Nome) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Valor) %>
        </td>
        <td>
            <%: Html.ActionLink("Alterar", "Edit", new { id=item.Codigo }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id=item.Codigo }) %> |
            <%: Html.ActionLink("Excluir", "Delete", new { id=item.Codigo }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
