<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/SiteHome.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Aluno>" %>

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
        <legend><%: Models.App_GlobalResources.Mensagem.aluno%></legend>



        <div class="editor-label">
            <%: Html.LabelFor(model => model.NomeRazao) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.NomeRazao) %>
            <%: Html.ValidationMessageFor(model => model.NomeRazao) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.ApelidoFantasia) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.ApelidoFantasia) %>
            <%: Html.ValidationMessageFor(model => model.ApelidoFantasia) %>
        </div>




        <div class="editor-label">
            <%: Html.LabelFor(model => model.DiaVencimento) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.DiaVencimento, new { @class = "ui-datepicker" })%>
            <%: Html.ValidationMessageFor(model => model.DiaVencimento) %>
        </div>



        <div class="editor-label">
            <%: Html.LabelFor(model => model.CpfCnpj) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CpfCnpj) %>
            <%: Html.ValidationMessageFor(model => model.CpfCnpj) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.RG) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.RG) %>
            <%: Html.ValidationMessageFor(model => model.RG) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.DataNascimento) %>
        </div>
        <div class="editor-field">
            <%: Html.TextBoxFor(model => model.DataNascimento, new { @class = "ui-datepicker" })%>
            <%: Html.ValidationMessageFor(model => model.DataNascimento) %>
        </div>

 <div class="editor-label">
            <%: Html.LabelFor(model => model.Sexo) %>
        </div>
        <div class="editor-field">
            <%: Html.RadioButtonFor(model => model.Sexo, "Masculino")%> <%: Models.App_GlobalResources.Mensagem.masculino%>  <br /> 
            <%: Html.RadioButtonFor(model => model.Sexo, "Feminino")%> <%: Models.App_GlobalResources.Mensagem.feminino%>
            <%: Html.ValidationMessageFor(model => model.Sexo) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Rua) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Rua) %>
            <%: Html.ValidationMessageFor(model => model.Rua) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Numero) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Numero) %>
            <%: Html.ValidationMessageFor(model => model.Numero) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Bairro) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Bairro) %>
            <%: Html.ValidationMessageFor(model => model.Bairro) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Cidade) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Cidade) %>
            <%: Html.ValidationMessageFor(model => model.Cidade) %>
        </div>

         <div class="editor-label">
            <%: Html.LabelFor(model => model.Estado) %>
        </div>
        <p>
            <%: @Html.DropDownListFor(model => model.Estado, new[]
            {
                new SelectListItem {Text = "Sergipe", Value = "SE"},
                new SelectListItem {Text = "Bahia", Value = "BA"},
                new SelectListItem {Text = "Alagoas", Value = "AL"},

            }, Models.App_GlobalResources.Mensagem.selecione)%> 
        </p> 

        <div class="editor-label">
            <%: Html.LabelFor(model => model.CEP) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.CEP) %>
            <%: Html.ValidationMessageFor(model => model.CEP) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Complemento) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Complemento) %>
            <%: Html.ValidationMessageFor(model => model.Complemento) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Telefone1) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Telefone1) %>
            <%: Html.ValidationMessageFor(model => model.Telefone1) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Telefone2) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Telefone2) %>
            <%: Html.ValidationMessageFor(model => model.Telefone2) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Email) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Email) %>
            <%: Html.ValidationMessageFor(model => model.Email) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Senha) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Senha) %>
            <%: Html.ValidationMessageFor(model => model.Senha) %>
        </div>

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.adicionar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index") %>
</div>

</asp:Content>
