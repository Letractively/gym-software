<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Atividade>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <%: Models.App_GlobalResources.Mensagem.excluir %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.excluir %></h2>

<h3><%: Models.App_GlobalResources.Mensagem.deseja_apagar %></h3>
<fieldset>
    <legend>Atividade</legend>

    <div class="display-label">CodigoAtividade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoAtividade) %>
    </div>

    <div class="display-label">CodigoModalidade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoModalidade) %>
    </div>

    <div class="display-label">NomeAtividade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeAtividade) %>
    </div>

    <div class="display-label">NomeModalidade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.NomeModalidade) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value=<%: Models.App_GlobalResources.Mensagem.excluir %> /> |
       <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index") %>
    </p>
<% } %>

</asp:Content>
