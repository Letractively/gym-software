<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Funcionario>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.gerenciar_funcionario %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.gerenciar_funcionario %></h2>

<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.criar_novo, "Create")%>
</p>
<table>
    <tr>
        <th>
            <%: Models.App_GlobalResources.Mensagem.codigo_funcionario %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.nome_razao%>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.apelido_fantasia %>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.data_nascimento%>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.rua%>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.numero%>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.bairro%>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.cidade%>
        </th>
        <th>
            <%: Models.App_GlobalResources.Mensagem.estado%>
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
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = item.CodigoFuncionario })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.detalhes, "Details", new { id = item.CodigoFuncionario })%> |
            <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.excluir, "Delete", new { id = item.CodigoFuncionario })%>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
