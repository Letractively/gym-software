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
            Código
        </th>
        <th>
            Código de Barra
        </th>
        <th>
            Nome
        </th>
        <th>
            Quantidade
        </th>        
        <th>
            Quantidade Mínima
        </th>
        <th>
            Preço de Custo
        </th>
        <th>
            Preço de Venda
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
            <%: Html.ActionLink("Alterar", "Edit", new {  id=item.Codigo }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new {  id=item.Codigo }) %> |
            <%: Html.ActionLink("Excluir", "Delete", new {  id=item.Codigo }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
