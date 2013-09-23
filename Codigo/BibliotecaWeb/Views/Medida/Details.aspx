<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Medida>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.detalhes %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.detalhes %></h2>

<fieldset>
    <legend><%: Models.App_GlobalResources.Mensagem.medida %></legend>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.codigo_medida %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CodigoMedida) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.matricula %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Matricula) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.data_medida %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Data) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.altura %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Altura) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.peso %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Peso) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.imc %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.IMC) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.gordura %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Gordura) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.abdomen %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Abdomen) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.cintura %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Cintura) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.costa %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Costa) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.peitoral %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Peitoral) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.quadril %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Quadril) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.ombro %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.Ombro) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.biceps_esquerdo %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.BicepsEsq) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.biceps_direito %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.BicepsDir) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.ante_braco_esquerdo %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.AnteBracoEsq) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.ante_braco_direito %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.AnteBracoDir) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.coxa_esquerda %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CoxaEsq) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.coxa_direita %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.CoxaDir) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.panturrilha_esquerdo %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PanturrilhaEsq) %>
    </div>

    <div class="display-label"><%: Models.App_GlobalResources.Mensagem.panturrilha_direita %></div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.PanturrilhaDir) %>
    </div>
</fieldset>
<p>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.editar, "Edit", new { id = Model.Matricula })%> |
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index")%>
</p>

</asp:Content>
