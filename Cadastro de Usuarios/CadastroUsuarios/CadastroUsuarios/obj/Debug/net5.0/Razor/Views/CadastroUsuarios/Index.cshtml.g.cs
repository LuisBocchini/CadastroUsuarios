#pragma checksum "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "571531979c8280010338c738725dc4782fa04a6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CadastroUsuarios_Index), @"mvc.1.0.view", @"/Views/CadastroUsuarios/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\_ViewImports.cshtml"
using CadastroUsuarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\_ViewImports.cshtml"
using CadastroUsuarios.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"571531979c8280010338c738725dc4782fa04a6b", @"/Views/CadastroUsuarios/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee78c98099254d3803799f7c5f4e6e71c4c7c7c3", @"/Views/_ViewImports.cshtml")]
    public class Views_CadastroUsuarios_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-usuario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enderecoId", new global::Microsoft.AspNetCore.Html.HtmlString("0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/CadastroUsuario.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/viacep.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
  
    ViewData["Title"] = "Cadastro de Usu??rios";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n\r\n");
#nullable restore
#line 6 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
     if (ViewBag.usuario != null && ViewBag.editar == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
                         Write(ViewBag.usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571531979c8280010338c738725dc4782fa04a6b6181", async() => {
                WriteLiteral("\r\n            <input type=\"text\" id=\"nome\" name=\"fname\"");
                BeginWriteAttribute("value", " value=\"", 343, "\"", 372, 1);
#nullable restore
#line 11 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 351, ViewBag.usuario.Nome, 351, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Nome\" disabled><br>\r\n            <input type=\"text\" id=\"email\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 462, "\"", 492, 1);
#nullable restore
#line 12 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 470, ViewBag.usuario.Email, 470, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Email\" disabled><br>\r\n            <input type=\"text\" id=\"dataNascimento\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 592, "\"", 654, 1);
#nullable restore
#line 13 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 600, ViewBag.usuario.DataNascimento.ToString("dd/MM/yyyy"), 600, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Data de nascimento\" disabled><br>\r\n            <input type=\"text\" id=\"cpf\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 756, "\"", 784, 1);
#nullable restore
#line 14 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 764, ViewBag.usuario.CPF, 764, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"CPF\" maxlength=\"11\" disabled><br>\r\n            <input type=\"text\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 877, "\"", 914, 1);
#nullable restore
#line 15 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 885, ViewBag.usuario.Endereco.Cep, 885, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"CEP\" id=\"cep\" maxlength=\"9\" onblur=\"pesquisacep(this.value);\" disabled><br>\r\n            <input type=\"text\" id=\"rua\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 1058, "\"", 1102, 1);
#nullable restore
#line 16 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 1066, ViewBag.usuario.Endereco.Logradouro, 1066, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Logradouro\" disabled><br>\r\n            <input type=\"text\" id=\"complemento\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 1204, "\"", 1249, 1);
#nullable restore
#line 17 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 1212, ViewBag.usuario.Endereco.Complemento, 1212, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Complemento\" disabled><br>\r\n            <input type=\"text\" id=\"bairro\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 1347, "\"", 1387, 1);
#nullable restore
#line 18 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 1355, ViewBag.usuario.Endereco.Bairro, 1355, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Bairro\" disabled><br>\r\n            <input type=\"text\" id=\"cidade\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 1480, "\"", 1520, 1);
#nullable restore
#line 19 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 1488, ViewBag.usuario.Endereco.Cidade, 1488, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Cidade\" disabled><br>\r\n            <input type=\"text\" id=\"uf\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 1609, "\"", 1649, 1);
#nullable restore
#line 20 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 1617, ViewBag.usuario.Endereco.Estado, 1617, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Estado\" disabled><br>\r\n            <input type=\"button\" value=\"Enviar\" disabled>\r\n\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 10 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
AddHtmlAttributeValue("", 246, ViewBag.usuario.Id, 246, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 24 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
    }
    else if (ViewBag.usuario != null && ViewBag.editar == true)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"display-4\">");
#nullable restore
#line 27 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
                         Write(ViewBag.usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571531979c8280010338c738725dc4782fa04a6b14105", async() => {
                WriteLiteral("\r\n            <input type=\"text\" id=\"nome\" name=\"fname\"");
                BeginWriteAttribute("value", " value=\"", 2075, "\"", 2104, 1);
#nullable restore
#line 30 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 2083, ViewBag.usuario.Nome, 2083, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Nome\"><br>\r\n            <input type=\"text\" id=\"email\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 2185, "\"", 2215, 1);
#nullable restore
#line 31 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 2193, ViewBag.usuario.Email, 2193, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Email\"><br>\r\n            <input type=\"text\" id=\"dataNascimento\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 2306, "\"", 2368, 1);
#nullable restore
#line 32 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 2314, ViewBag.usuario.DataNascimento.ToString("dd/MM/yyyy"), 2314, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Data de nascimento\"><br>\r\n            <input type=\"text\" id=\"cpf\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 2461, "\"", 2489, 1);
#nullable restore
#line 33 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 2469, ViewBag.usuario.CPF, 2469, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"CPF\" maxlength=\"11\"><br>\r\n            <input type=\"text\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 2573, "\"", 2610, 1);
#nullable restore
#line 34 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 2581, ViewBag.usuario.Endereco.Cep, 2581, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"CEP\" id=\"cep\" maxlength=\"9\" onblur=\"pesquisacep(this.value);\"><br>\r\n            <input type=\"text\" id=\"rua\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 2745, "\"", 2789, 1);
#nullable restore
#line 35 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 2753, ViewBag.usuario.Endereco.Logradouro, 2753, 36, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Logradouro\"><br>\r\n            <input type=\"text\" id=\"complemento\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 2882, "\"", 2927, 1);
#nullable restore
#line 36 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 2890, ViewBag.usuario.Endereco.Complemento, 2890, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Complemento\"><br>\r\n            <input type=\"text\" id=\"bairro\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 3016, "\"", 3056, 1);
#nullable restore
#line 37 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 3024, ViewBag.usuario.Endereco.Bairro, 3024, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Bairro\"><br>\r\n            <input type=\"text\" id=\"cidade\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 3140, "\"", 3180, 1);
#nullable restore
#line 38 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 3148, ViewBag.usuario.Endereco.Cidade, 3148, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Cidade\"><br>\r\n            <input type=\"text\" id=\"uf\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 3260, "\"", 3300, 1);
#nullable restore
#line 39 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
WriteAttributeValue("", 3268, ViewBag.usuario.Endereco.Estado, 3268, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Estado\"><br>\r\n            <input type=\"button\" value=\"Enviar\" onclick=\"CadastrarUsuario()\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
AddHtmlAttributeValue("", 1936, ViewBag.usuario.Id, 1936, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "enderecoId", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 29 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
AddHtmlAttributeValue("", 1990, ViewBag.usuario.Endereco.Id, 1990, 28, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"display-4\">Cadastro de usu??rios</h1>\r\n        <br />\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571531979c8280010338c738725dc4782fa04a6b22180", async() => {
                WriteLiteral("\r\n            <input type=\"text\" id=\"nome\" name=\"fname\"");
                BeginWriteAttribute("value", " value=\"", 3634, "\"", 3642, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Nome\"><br>\r\n            <input type=\"text\" id=\"email\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 3723, "\"", 3731, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Email\"><br>\r\n            <input type=\"text\" id=\"dataNascimento\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 3822, "\"", 3830, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Data de nascimento\"><br>\r\n            <input type=\"text\" id=\"cpf\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 3923, "\"", 3931, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"CPF\" maxlength=\"11\"><br>\r\n            <input type=\"text\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 4015, "\"", 4023, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"CEP\" id=\"cep\" maxlength=\"9\" onblur=\"pesquisacep(this.value);\"><br>\r\n            <input type=\"text\" id=\"rua\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 4158, "\"", 4166, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Logradouro\"><br>\r\n            <input type=\"text\" id=\"complemento\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 4259, "\"", 4267, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Complemento\"><br>\r\n            <input type=\"text\" id=\"bairro\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 4356, "\"", 4364, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Bairro\"><br>\r\n            <input type=\"text\" id=\"cidade\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 4448, "\"", 4456, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Cidade\"><br>\r\n            <input type=\"text\" id=\"uf\" name=\"lname\"");
                BeginWriteAttribute("value", " value=\"", 4536, "\"", 4544, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Estado\"><br>\r\n            <input type=\"button\" value=\"Enviar\" onclick=\"CadastrarUsuario()\">\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 60 "C:\Users\luisb\Desktop\Cadastro de Usuarios\CadastroUsuarios\CadastroUsuarios\Views\CadastroUsuarios\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"modal-container\">\r\n        <div class=\"modal-mensagem\">\r\n            <p class=\"mensagem\"></p>\r\n            <button id=\"btnFechar\" onclick=\"FecharModal()\">Fechar</button>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571531979c8280010338c738725dc4782fa04a6b26800", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "571531979c8280010338c738725dc4782fa04a6b27840", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
