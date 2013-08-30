<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Medida>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.criar_nova %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.criar_nova %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>
<script type="text/javascript">
    $.validator.methods.number = function (value, element) {
        return !isNaN($.parseFloat(value));
    }

    $(function () {
        $.preferCulture('pt-BR');
    });
</script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.medida %></legend>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Matricula) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Matricula) %>
            <%: Html.ValidationMessageFor(model => model.Matricula) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Data) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Data) %>
            <%: Html.ValidationMessageFor(model => model.Data) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Altura) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Altura) %>
            <%: Html.ValidationMessageFor(model => model.Altura) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Peso) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Peso) %>
            <%: Html.ValidationMessageFor(model => model.Peso) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.IMC) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.IMC) %>
            <%: Html.ValidationMessageFor(model => model.IMC) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Gordura) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Gordura) %>
            <%: Html.ValidationMessageFor(model => model.Gordura) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Abdomen) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Abdomen) %>
            <%: Html.ValidationMessageFor(model => model.Abdomen) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Cintura) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cintura) %>
            <%: Html.ValidationMessageFor(model => model.Cintura) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Costa) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Costa) %>
            <%: Html.ValidationMessageFor(model => model.Costa) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Peitoral) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Peitoral) %>
            <%: Html.ValidationMessageFor(model => model.Peitoral) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Quadril) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Quadril) %>
            <%: Html.ValidationMessageFor(model => model.Quadril) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Ombro) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Ombro) %>
            <%: Html.ValidationMessageFor(model => model.Ombro) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.BicepsEsq) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.BicepsEsq) %>
            <%: Html.ValidationMessageFor(model => model.BicepsEsq) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.BicepsDir) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.BicepsDir) %>
            <%: Html.ValidationMessageFor(model => model.BicepsDir) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.AnteBracoEsq) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.AnteBracoEsq) %>
            <%: Html.ValidationMessageFor(model => model.AnteBracoEsq) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.AnteBracoDir) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.AnteBracoDir) %>
            <%: Html.ValidationMessageFor(model => model.AnteBracoDir) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CoxaEsq) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CoxaEsq) %>
            <%: Html.ValidationMessageFor(model => model.CoxaEsq) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CoxaDir) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CoxaDir) %>
            <%: Html.ValidationMessageFor(model => model.CoxaDir) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PanturrilhaEsq) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PanturrilhaEsq) %>
            <%: Html.ValidationMessageFor(model => model.PanturrilhaEsq) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PanturrilhaDir) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PanturrilhaDir) %>
            <%: Html.ValidationMessageFor(model => model.PanturrilhaDir) %>
        </div>
        
        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.adicionar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index")%>
</div>

</asp:Content>
