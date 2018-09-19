<%@ Page Title="" Language="C#" MasterPageFile="~/BaseAdmin2.Master" AutoEventWireup="true" CodeBehind="Editar_categoria.aspx.cs" Inherits="CarroVirtual.Editar_categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="wrap-login100 p-l-55 p-r-55 p-t-65 p-b-54">
					<span class="login100-form-title p-b-49">Editar Categoria</span>

					<div class="wrap-input100 validate-input m-b-23" data-validate = "Se requiere un nombre">
						<span class="label-input100">Nombre de la Categoria</span>
						<asp:TextBox class="input100" runat="server" id="txt_nombre"></asp:TextBox>
						<span class="focus-input100" data-symbol="&#xf206;"></span>
					</div>

                    <br>
					<div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<asp:Button id="btn_editar_cat" OnClick="editar_categoria" runat="server" class="login100-form-btn" Text="Editar Categoria"></asp:Button>
						</div>
					</div>
                    
                    <br>
                    <div class="container-login100-form-btn">
						<div class="wrap-login100-form-btn">
							<div class="login100-form-bgbtn"></div>
							<a runat="server" href="indexAdmin.aspx" class="login100-form-btn">Regresar/Cancelar</a>
						</div>
					</div>
        </div>

</asp:Content>
