<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Models.Models.Funcionario>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    <%: Models.App_GlobalResources.Mensagem.editar %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

<h2><%: Models.App_GlobalResources.Mensagem.editar %></h2>

<script src="<%: Url.Content("~/Scripts/jquery.validate.min.js") %>" type="text/javascript"></script>
<script src="<%: Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js") %>" type="text/javascript"></script>
<script type="text/javascript">
    $.validator.methods.number = function (value, element) {
        return !isNaN($.parseFloat(value));
    }

    $(function () {
        $.preferCulture('pt-BR');
    });
</script>


<% using (Html.BeginForm()) { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend><%: Models.App_GlobalResources.Mensagem.funcionario %></legend>

        
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.CodigoFuncionario)%>
            <%: Html.ValidationMessageFor(model => model.CodigoFuncionario) %>
        </div>

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Permicao) %>
        </div>
        <div class="editor-field">
            <%: Html.RadioButtonFor(model => model.Permicao, "Atendente")%>  <%: Models.App_GlobalResources.Mensagem.atendente %>  <br /> 
            <%: Html.RadioButtonFor(model => model.Permicao, "Instrutor")%>  <%: Models.App_GlobalResources.Mensagem.instrutor %> <br />
            <%: Html.RadioButtonFor(model => model.Permicao, "Proprietario")%> <%: Models.App_GlobalResources.Mensagem.proprietario %>
            <%: Html.ValidationMessageFor(model => model.Permicao) %>
        </div>


        <div class="editor-field">
            <%: Html.HiddenFor(model => model.CodigoPessoa)%>
            <%: Html.ValidationMessageFor(model => model.CodigoPessoa)%>
        </div>

      

        <div class="editor-field">
            <%: Html.HiddenFor(model => model.CadastradoDesde)%>
            <%: Html.ValidationMessageFor(model => model.CadastradoDesde) %>
        </div>

        
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.NomeRazao) %>
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

      
        <div class="editor-field">
            <%: Html.HiddenFor(model => model.DataNascimento) %>
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

        <div class="editor-label">
            <%: Html.LabelFor(model => model.Fornecedor) %>
        </div>
        <div class="editor-field">
            <%: Html.EditorFor(model => model.Fornecedor)%>
            <%: Html.ValidationMessageFor(model => model.Fornecedor)%>
        </div>

        <p>
            <input type="submit" value="<%: Models.App_GlobalResources.Mensagem.salvar %>" />
        </p>
    </fieldset>
<% } %>

<div>
    <%: Html.ActionLink(Models.App_GlobalResources.Mensagem.voltar_para_lista, "Index")%>
</div>

</asp:Content>
