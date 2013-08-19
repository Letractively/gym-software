<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Produto>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Detalhes</h2>

<fieldset>
    <legend>Produto</legend>

    <div class="display-label">Codigo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Codigo) %>
    </div>

    <div class="display-label">CodigoBarra</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoBarra) %>
    </div>

    <div class="display-label">Nome</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Nome) %>
    </div>

    <div class="display-label">Quantidade</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Quantidade) %>
    </div>

    <div class="display-label">Valor</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Valor) %>
    </div>

    <div class="display-label">QuantidadeMinima</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.QuantidadeMinima) %>
    </div>

    <div class="display-label">PrecoCusto</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PrecoCusto) %>
    </div>

    <div class="display-label">PrecoVenda</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PrecoVenda) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Edit", "Edit", new {  id=Model.Codigo }) %> |
    <%: Html.ActionLink("Voltar Para Lista", "Index")%>
</p>

</asp:Content>
