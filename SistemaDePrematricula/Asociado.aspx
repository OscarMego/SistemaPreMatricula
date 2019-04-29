<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Asociado.aspx.cs" Inherits="SistemaDePrematricula.Asociado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div id="dvAsociado">
            <h1>Registrarse para acceder al Api SITECE</h1>
            <h3>Datos del asociado</h3>
            <div class="container">
                <div class="panel panel-primary">
                    <div class="panel-body">
                        <div class="form-group col-md-6">
                            <label for="txtCodigoModular">Código modular</label>
                            <input type="text" id="txtCodigoModular" placeholder="Código" class="form-control" maxlength="50" />
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtNombreColegio">Nombre de colegio</label>
                            <input id="txtNombreColegio" type="text" class="form-control" placeholder="Nombre de colegio" maxlength="150" />
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtEmail">Email</label>
                            <input type="text" class="form-control" id="txtEmail" placeholder="Email" maxlength="150">
                        </div>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4"></div>
                <div class="col-md-8">
                    <a class="col-md-4 btn btn-primary" style="margin-right: 10px" href="/">Cancelar</a>
                    <div id="btnRegistro" class="col-md-4 btn btn-primary" style="margin-right: 10px" onclick="registrarAsociado()">Registrar</div>
                </div>
            </div>
        </div>
        <div id="dvCondirmacion">
        </div>
    </div>
    <script>
        function registrarAsociado() {
            var objAsociado = new Object();
            objAsociado.CodigoModular = $('#txtCodigoModular').val();
            objAsociado.NombreColegio = $('#txtNombreColegio').val();
            objAsociado.Email = $('#txtEmail').val();
            if (objAsociado.CodigoModular === undefined || objAsociado.CodigoModular == '') {
                alert('El campo codigo modular es obligatorio');
                $('#txtCodigoModular').focus();
                return
            }
            if (objAsociado.NombreColegio === undefined || objAsociado.NombreColegio == '') {
                alert('El campo codigo modular es obligatorio');
                $('#txtNombreColegio').focus();
                return
            }
            if (objAsociado.Email === undefined || objAsociado.Email == '') {
                alert('El campo codigo modular es obligatorio');
                $('#txtEmail').focus();
                return
            }
            $.ajax({
                type: 'POST',
                url: 'Asociado.aspx/CrearAsociado',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                cache: false,
                data: JSON.stringify({ asociado: objAsociado }),
                success: function (data) {
                    var asociado = data.d.split('|');
                    if (asociado[0]==='OK') {
                        $('#dvAsociado').hide();
                        $('#dvCondirmacion').html('<h3>Tu registro fue exitoso éxitoso, revise su correo donde se envió el token<h3><br><h1>Token: ' + asociado[1]+'</h1>');                       
                    } else {
                        alert(asociado[0]);
                    }
                }, error: function (XMLHttpRequest, textStatus, errorThrown) {
                    alert("Ocurrió un error al intentar registrar");
                }
            });
        }
    </script>
</asp:Content>
