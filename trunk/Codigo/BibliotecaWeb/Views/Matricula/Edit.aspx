<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Matricula>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Editar</h2>

<p>

  <%: Html.ActionLink("Create", "Create", new { id = @ViewBag.Id })%>
</p>
<table>
    <tr>
        <th>
            CodigoMatricula
        </th>
        <th>
            MatriculaAluno
        </th>
        <th>
            NomeAluno
        </th>
        <th>
            CodigoModalidade
        </th>
        <th>
            DataMatricula
        </th>
        <th>
            NomeModalidade
        </th>
 
        <th></th>
    </tr>
    
<% foreach (var item in Model) { %>

    <tr>
        <td>
            <%: Html.DisplayFor(modelItem => item.CodigoMatricula) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.MatriculaAluno) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeAluno) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CodigoModalidade) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.DataMatricula) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.NomeModalidade) %>
        </td>

        <td>
            <%: Html.ActionLink("Delete", "Delete", new { id=item.CodigoMatricula }) %>
        </td>
    </tr>
    
<% } %>

</table>
<%: Html.ActionLink("Voltar para a Lista", "Index") %>
</asp:Content>
