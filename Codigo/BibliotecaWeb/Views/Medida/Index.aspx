<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Models.Models.Medida>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Index</h2>

<p>
    <%: Html.ActionLink("Inserir Nova", "Create") %>
</p>
<table>
    <tr>
        <th>
            Código da Medida
        </th>
        <th>
            Matrícula
        </th> 
        <th>
            Data
        </th>
        <th>
            Altura
        </th>
        <th>
            Peso
        </th>
        <th>
            IMC
        </th>
        <th>
            Gordura
        </th>
        <th>
            Abdomen
        </th>
    </tr>
    <tr>
        <th>
            Cintura
        </th>
        <th>
            Costa
        </th>
        <th>
            Peitoral
        </th>
        <th>
            Quadril
        </th>
        <th>
            Ombro
        </th>    
        <th>
            Bíceps Esquerdo
        </th>
        <th>
            Bíceps Direito
        </th>
    </tr>
    <tr>
        <th>
            AnteBraço Esquerdo
        </th>
        <th>
            AnteBraço Direito
        </th>
        <th>
            Coxa Esquerda
        </th>
        <th>
            Coxa Direita
        </th>
        <th>
            Panturrilha Esquerda
        </th>
        <th>
            Panturrilha Direita
        </th>               
        <th></th>
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
            <%: Html.DisplayFor(modelItem => item.Altura) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Peso) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.IMC) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Gordura) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Abdomen) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Cintura) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Costa) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Peitoral) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Quadril) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.Ombro) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.BicepsEsq) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.BicepsDir) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.AnteBracoEsq) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.AnteBracoDir) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CoxaEsq) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.CoxaDir) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.PanturrilhaEsq) %>
        </td>
        <td>
            <%: Html.DisplayFor(modelItem => item.PanturrilhaDir) %>
        </td>        
        <td>
            <%: Html.ActionLink("Alterar", "Edit", new {  id=item.CodigoMedida }) %> |
            <%: Html.ActionLink("Detalhes", "Details", new { id = item.CodigoMedida })%> |
            <%: Html.ActionLink("Excluir", "Delete", new {  id=item.CodigoMedida }) %>
        </td>
    </tr>
<% } %>

</table>

</asp:Content>
