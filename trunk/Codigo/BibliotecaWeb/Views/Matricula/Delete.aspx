<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Matricula>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Matricula</legend>

    <div class="display-label">CodigoMatricula:  <%: Html.DisplayFor(model => model.CodigoMatricula) %>
    </div>

    <div class="display-label">MatriculaAluno: <%: Html.DisplayFor(model => model.MatriculaAluno) %>
    </div>

    <div class="display-label">CodigoModalidade: <%: Html.DisplayFor(model => model.CodigoModalidade) %>
    </div>

    <div class="display-label">DataMatricula: <%: Html.DisplayFor(model => model.DataMatricula) %>
    </div>

    <div class="display-label">NomeModalidade <%: Html.DisplayFor(model => model.NomeModalidade) %>
    </div>

    <div class="display-label">NomeAluno: <%: Html.DisplayFor(model => model.NomeAluno) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Delete" /> |
        <%: Html.ActionLink("Back to List", "Index") %>
    </p>
<% } %>

</asp:Content>
