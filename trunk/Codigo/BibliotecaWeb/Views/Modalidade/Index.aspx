<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Modalidade>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.gerenciar_modalidade %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.criar_novo, "Create") %>
</p>
<table>
    <tr>
        <th>
             <%: Models.App_GlobalResources.Mensagem.codigo %>
        </th>
        <th>
             <%: Models.App_GlobalResources.Mensagem.nome %>
        </th>
        <th>
             <%: Models.App_GlobalResources.Mensagem.valor %>
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
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id=item.Codigo }) %> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id=item.Codigo }) %> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.excluir, "Delete", new { id=item.Codigo }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
