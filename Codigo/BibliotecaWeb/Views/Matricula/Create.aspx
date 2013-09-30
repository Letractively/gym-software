<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Matricula>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.novo %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.novo %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>

<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Matricula</legend>

        

      
        <div class="editor-field">
           
            <%= Html.TextBoxFor(model => model.MatriculaAluno, new { @Value = @ViewBag.Id, @type="hidden"})%>
      
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CodigoModalidade) %>
        </div>
        <div class="editor-field">
            <%: Html.DropDownListFor(model => model.CodigoModalidade, ViewBag.Modalidade as SelectList, new { id = "Modalidade" })%>
            <%: Html.ValidationMessageFor(model => model.CodigoModalidade) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataMatricula) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.DataMatricula, new { @Value = String.Format("{0:dd/MM/yyyy}", DateTime.Now.Date) })%>
            <%: Html.ValidationMessageFor(model => model.DataMatricula) %>
        </div>




        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink( Models.App_GlobalResources.Mensagem.voltar_para_lista , "Index") %>
</div>

</asp:Content>
