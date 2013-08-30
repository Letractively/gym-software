<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Produto>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.gerenciar_produto %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.gerenciar_produto %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.criar_novo, "Create")%>
</p>
<table>
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.codigo %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.codigo_barra %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nome %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.quantidade %>
        </th>        
        <th>
            <%: Models.App_GlobalResources.Mensagem.quantidade_minima %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.preco_custo %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.preco_venda %>
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
            <%: Html.DisplayFor(modelItem => item.QuantidadeMinima) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.PrecoCusto) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.PrecoVenda) %>
        </td>
        <td>
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.Codigo })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.Codigo })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.excluir, "Delete", new { id = item.Codigo })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
