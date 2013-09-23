<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Aluno>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.gerenciar_medida %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.gerenciar_medida %></h2>


<table>
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nome_razao %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.matricula %>
        </th> 
        <th>
            <%: Models.App_GlobalResources.Mensagem.cpf_cnpj %>
        </th>
   
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeRazao) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Matricula) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CpfCnpj) %>
        </td>

        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.criar_nova, "Create", new { id = item.Matricula })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.Matricula })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.Matricula })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.excluir, "Delete", new { id = item.Matricula })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
