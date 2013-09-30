<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Aluno>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Gerenciar Matrícula</h2>


<table>
    <tr>
        <th>
            Matricula
        </th>   
        <th>
            NomeRazao
        </th>
        <th>
            ApelidoFantasia
        </th>
        <th>
            DataNascimento
        </th>


        <th></th>
    </tr>

<% foreach (var item in Model) { %>
    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.Matricula) %>
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
            <%: Html.ActionLink("Edit", "Edit", new { id=item.Matricula }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
