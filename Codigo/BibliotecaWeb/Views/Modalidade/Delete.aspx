<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Modalidade>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
     <%: Models.App_GlobalResources.Mensagem.excluir %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.excluir%></h2>

<h3> <%: Models.App_GlobalResources.Mensagem.deseja_apagar %></h3>
<fieldset>
    <legend> <%: Models.App_GlobalResources.Mensagem.modalidade %></legend>

    <div class="display-label"> <%: Models.App_GlobalResources.Mensagem.codigo%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Codigo) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.nome%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.valor%></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Valor) %>
    </div>
</fieldset>
<% using (Html.BeginForm()) { %>
    <p>
        <input type="submit" value = "<%: Models.App_GlobalResources.Mensagem.excluir%>" /> |
        <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index")%>
    </p>
<% } %>

</asp:Content>
