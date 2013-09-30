<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Matricula>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    SelecionarModalidade
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>SelecionarModalidade</h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Matricula</legend>

  <div class="editor-field">
           
            <%= Html.TextBoxFor(model => model.CodigoMatricula, new { @Value = 0, @type="hidden"})%>
      
        </div>

        <div class="editor-field">
           
            <%= Html.TextBoxFor(model => model.MatriculaAluno, new { @Value = @ViewBag.IdAluno, @type = "hidden" })%>
      
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CodigoAtividade)%>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.CodigoAtividade, ViewBag.Modalidade as SelectList, new { id = "CodigoAtividade" })%>
            <%: Html.ValidationMessageFor(model => model.CodigoAtividade)%>

        <div class="editor-field">
           
            <%= Html.TextBoxFor(model => model.DataMatricula, new { @Value = "01/01/2000", @type="hidden"})%>
      
        </div>


        <div class="editor-field">
           
            <%= Html.TextBoxFor(model => model.NomeAluno, new { @Value = "", @type="hidden"})%>
      
        </div>  
        <div class="editor-field">
           
            <%= Html.TextBoxFor(model => model.NomeModalidade, new { @Value = "", @type="hidden"})%>
      
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.voltar_para_lista , "Index") %>
</div>

</asp:Content>
