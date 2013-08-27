<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Funcionario>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Create New", "Create") %>
</p>
<table>
    <tr>
        <th>
            CodigoFuncionario
        </th>
        <th>
            Permicao
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.CodigoFuncionario) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Permicao) %>
        </td>
        <td>
            <%: Html.ActionLink("Alterar", "Edit", new {  id=item.CodigoFuncionario  }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id = item.CodigoFuncionario })%> |
            <%: Html.ActionLink("Excluir", "Delete", new { id = item.CodigoFuncionario })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
