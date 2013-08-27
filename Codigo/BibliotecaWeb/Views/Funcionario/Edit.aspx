<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Funcionario>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Alterar</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Funcionario</legend>

        
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.CodigoFuncionario)%>
            <%: Html.ValidationMessageFor(model => model.CodigoFuncionario) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Permicao) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Permicao) %>
            <%: Html.ValidationMessageFor(model => model.Permicao) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Voltar para Lista", "Index") %>
</div>

</asp:Content>
