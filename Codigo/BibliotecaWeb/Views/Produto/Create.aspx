﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Produto>" %>

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
        <legend><%: Models.App_GlobalResources.Mensagem.produto %></legend>

        

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CodigoBarra) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CodigoBarra) %>
            <%: Html.ValidationMessageFor(model => model.CodigoBarra) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Nome) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Nome) %>
            <%: Html.ValidationMessageFor(model => model.Nome) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Quantidade) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Quantidade) %>
            <%: Html.ValidationMessageFor(model => model.Quantidade) %>
        </div>
               
        <div class="editor-label">
            <%: Html.LabelFor(model => model.QuantidadeMinima) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.QuantidadeMinima) %>
            <%: Html.ValidationMessageFor(model => model.QuantidadeMinima) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PrecoCusto) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PrecoCusto) %>
            <%: Html.ValidationMessageFor(model => model.PrecoCusto) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.PrecoVenda) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.PrecoVenda) %>
            <%: Html.ValidationMessageFor(model => model.PrecoVenda) %>
        </div>

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.adicionar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index")%>
</div>

</asp:Content>
