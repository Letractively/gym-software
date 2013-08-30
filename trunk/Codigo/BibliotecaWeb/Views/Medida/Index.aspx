<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Medida>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.gerenciar_medida %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.gerenciar_medida %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.criar_nova, "Create")%>
</p>
<table>
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.codigo_medida %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.matricula %>
        </th> 
        <th>
            <%: Models.App_GlobalResources.Mensagem.data_medida %>
        </th>
   
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.CodigoMedida) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Matricula) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Data) %>
        </td>

        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.CodigoMedida })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.CodigoMedida })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.excluir, "Delete", new { id = item.CodigoMedida })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
