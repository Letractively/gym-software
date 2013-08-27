<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Funcionario>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Detalhes</h2>

<fieldset>
    <legend>Funcionario</legend>

    <div class="display-label">CodigoFuncionario</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoFuncionario) %>
    </div>

    <div class="display-label">Permicao</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Permicao) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Alterar", "Edit", new {  id=Model.CodigoFuncionario  }) %> |
    <%: Html.ActionLink("Voltar para Lista", "Index") %>
</p>

</asp:Content>
