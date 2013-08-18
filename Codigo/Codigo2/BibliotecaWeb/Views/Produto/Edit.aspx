<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Produto>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Edit
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Edit</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Produto</legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Codigo) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Codigo) %>
            <%: Html.ValidationMessageFor(model => model.Codigo) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CodigoBarra) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CodigoBarra) %>
            <%: Html.ValidationMessageFor(model => model.CodigoBarra) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Quantidade) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Quantidade) %>
            <%: Html.ValidationMessageFor(model => model.Quantidade) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Valor) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Valor) %>
            <%: Html.ValidationMessageFor(model => model.Valor) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.QuantidadeMinima) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.QuantidadeMinima) %>
            <%: Html.ValidationMessageFor(model => model.QuantidadeMinima) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PrecoCusto) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PrecoCusto) %>
            <%: Html.ValidationMessageFor(model => model.PrecoCusto) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PrecoVenda) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PrecoVenda) %>
            <%: Html.ValidationMessageFor(model => model.PrecoVenda) %>
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink("Back to List", "Index") %>
</div>

</asp:Content>
