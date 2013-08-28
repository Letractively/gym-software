<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Funcionario>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Inserir Novo", "Create") %>
</p>
<table>
    <tr>
        <th>
            CodigoFuncionario
        </th>
        <th>
            Nome / Razão
        </th>
        <th>
            Apelido / Fantasia
        </th>
        <th>
            Data Nascimento
        </th>
        <th>
            Rua
        </th>
        <th>
            Numero
        </th>
        <th>
            Bairro
        </th>
        <th>
            Cidade
        </th>
        <th>
            Estado
        </th>
        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.CodigoFuncionario) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeRazao) %>
        </td>

        <td>
            <%: Html.DisplayFor(modelItem => item.ApelidoFantasia) %>
        </td>

        <td>
            <%: Html.DisplayFor(modelItem => item.DataNascimento) %>
        </td>

        <td>
            <%: Html.DisplayFor(modelItem => item.Rua) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Numero) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Bairro) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Cidade) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Estado) %>
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
