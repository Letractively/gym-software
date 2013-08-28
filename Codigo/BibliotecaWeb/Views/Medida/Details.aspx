<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Medida>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Details
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2>Detalhes</h2>

<fieldset>
    <legend>Medida</legend>

    <div class="display-label">Código da Medida</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoMedida) %>
    </div>

    <div class="display-label">Matrícula</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Matricula) %>
    </div>

    <div class="display-label">Data</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Data) %>
    </div>

    <div class="display-label">Altura</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Altura) %>
    </div>

    <div class="display-label">Peso</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Peso) %>
    </div>

    <div class="display-label">IMC</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IMC) %>
    </div>

    <div class="display-label">Gordura</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Gordura) %>
    </div>

    <div class="display-label">Abdomen</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Abdomen) %>
    </div>

    <div class="display-label">Cintura</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cintura) %>
    </div>

    <div class="display-label">Costa</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Costa) %>
    </div>

    <div class="display-label">Peitoral</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Peitoral) %>
    </div>

    <div class="display-label">Quadril</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Quadril) %>
    </div>

    <div class="display-label">Ombro</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Ombro) %>
    </div>

    <div class="display-label">Bíceps Esquerdo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.BicepsEsq) %>
    </div>

    <div class="display-label">Bíceps Direito</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.BicepsDir) %>
    </div>

    <div class="display-label">AnteBraço Esquerdo</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.AnteBracoEsq) %>
    </div>

    <div class="display-label">AnteBraço Direito</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.AnteBracoDir) %>
    </div>

    <div class="display-label">Coxa Esquerda</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CoxaEsq) %>
    </div>

    <div class="display-label">Coxa Direita</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CoxaDir) %>
    </div>

    <div class="display-label">Panturrilha Esquerda</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PanturrilhaEsq) %>
    </div>

    <div class="display-label">Panturrilha Direita</div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PanturrilhaDir) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink("Alterar", "Edit", new { id = Model.CodigoMedida })%> |
    <%: Html.ActionLink("Voltar para Lista", "Index") %>
</p>

</asp:Content>
