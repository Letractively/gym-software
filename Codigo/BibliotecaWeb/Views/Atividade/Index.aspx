<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Atividade>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <%: Models.App_GlobalResources.Mensagem.gerenciar_atividades %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2> <%: Models.App_GlobalResources.Mensagem.gerenciar_atividades %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.criar_novo, "Create")%>
</p>
<table>
    <tr>
        <th>
            Cód. Atividade
        </th>
        <th>
            Atividade
        </th>
        <th>
            Modalidade
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.CodigoAtividade) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeAtividade) %>
        </td>

        <td>
            <%: Html.DisplayFor(modelItem => item.NomeModalidade) %>
        </td>

        <td>
                      
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.excluir, "Delete", new { id = item.CodigoAtividade }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
