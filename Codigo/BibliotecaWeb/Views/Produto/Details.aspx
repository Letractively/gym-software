<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Produto>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhes %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhes %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.produto %></legend>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.codigo %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Codigo) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.codigo_barra %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoBarra) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.nome %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.quantidade %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Quantidade) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.quantidade_minima %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.QuantidadeMinima) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.preco_custo %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PrecoCusto) %>
    </div>

    <div class="display-label"><b><%: Models.App_GlobalResources.Mensagem.preco_venda %></b></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PrecoVenda) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new {  id=Model.Codigo }) %> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index")%>
</p>

</asp:Content>
