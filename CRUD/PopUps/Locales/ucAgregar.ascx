<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucAgregar.ascx.cs" Inherits="CRUD.PopUps.Locales.ucAgregar" %>
<div class="fondo">
    <div class="form-container">
        <div class="form-group">
            <h2 class="titulo">Agregar</h2>
        </div>        
        <div class="form-row">            
            <div class="col">
                <label for="txtNombre">Nombre</label>
                <input runat="server" id="txtNombre" type="text" class="form-control" placeholder="Central">
            </div>
            <div class="col">
                <label for="txtTelefono">Telefono</label>
                <input runat="server" id="txtTelefono" type="text" class="form-control" placeholder="5510392834">
            </div>
        </div>        
        <div class="form-group">
            <label for="txtDireccion">Direccion</label>
            <asp:TextBox runat="server" TextMode="MultiLine" rows="3" CssClass="form-control" ID="txtDireccion" ></asp:TextBox>
        </div>
        <div class="form-row">
            <div class="col">
                <label for="txtEncargado">Encargado</label>
                <input runat="server" id="txtEncargado" type="text" class="form-control" placeholder="">
            </div>
        </div>
        <div class="form-group">
            <label for="txtDescripcion">Descripcion</label>
            <asp:TextBox runat="server" TextMode="MultiLine" rows="3" CssClass="form-control" ID="txtDescripcion" ></asp:TextBox>
        </div>
        <asp:Button runat="server" CssClass="btn btn-danger" ID="btnCancelar" Text="Cancelar" OnClick="btnCancelar_Click" />
        <asp:Button runat="server" CssClass="btn btn-primary" ID="btnAceptar" Text="Aceptar" OnClick="btnAceptar_Click" />
    </div>
    <div class="Errores">
        <asp:Label runat="server" ID="lblError" CssClass="center-align"></asp:Label>
    </div>
</div>

<asp:HiddenField runat="server" ID="hidIdLocal" Value="0" />
