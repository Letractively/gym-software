<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Modalidade>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Excluir</h2>

<h3>Você Realmente deseja apagar esse registro?</h3>
<fieldset>
    <legend>Modalidade</legend>

    <div class="display-label">Código</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Codigo) %>
    </div>

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">Valor</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Valor) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value="Excluir" /> |
        <%: Html.ActionLink("Voltar Para Lista", "Index")%>
    </p>
<% } %>

</asp:Content>
