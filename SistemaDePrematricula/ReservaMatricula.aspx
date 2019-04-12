<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservaMatricula.aspx.cs" Inherits="SistemaDePrematricula.ConfirmarMatricula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row " style="text-align: center;" id="dvLogin">
        <div class="col-sm-4 col-sm-offset-4" style="padding-top: 50px">
            <div class="login-panel panel  panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Reserva de Matricula - Alumnos Nuevos</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <select name="nivel">
                            <option value="">Seleccione un nivel</option>
                            <option value="primaria">Primaria</option>
                            <option value="secundaria">Secundaria</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <select name="grado">
                            <option value="">Seleccione un grado</option>
                            <option value="primero">Primero</option>
                            <option value="segundo">Segundo</option>
                            <option value="tercero">Tercero</option>
                            <option value="cuarto">Cuarto</option>
                            <option value="quinto">Quinto</option>
                        </select>
                    </div>
                    <div class="form-group hide" id="idOptionsFailed">
                        <p class="text text-danger">* Nivel/Grado no seleccionados</p>
                    </div>
                    <div class="form-group hide" id="idOptionsEmpty">
                        <p class="text text-danger">* Seleccione todas las opciones</p>
                    </div>
                    <div class="btn btn-primary btn-lg btn-block" onclick="reservar()">Reservar</div>

                </div>
            </div>
        </div>
    </div>
    <div id="dvConfirmacion" style="display: none">
        <h2>Reserva de matrícula - Alumnos nuevos</h2>
        <div class="container">
            <div class="panel panel-primary">
                <div class="panel-body">
                    <div class="form-group col-md-6">
                        <label for="txtDNI">DNI</label>
                        <input type="email" class="form-control" id="txtDNI" placeholder="DNI">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtNombres">Nombres</label>
                        <input type="email" class="form-control" id="txtNombres" placeholder="Nombres">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoPaterno">Apellido paterno</label>
                        <input type="email" class="form-control" id="txtApellidoPaterno" placeholder="Apellido paterno">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoMaterno">Apellido materno</label>
                        <input type="email" class="form-control" id="txtApellidoMaterno" placeholder="Apellido materno">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtNivel">Colegio de procedencia</label>
                        <input type="email" class="form-control" id="txtColegioProcedencia" placeholder="Colegio procedencia">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtGrado">Telefono</label>
                        <input type="email" class="form-control" id="txtTelefono" placeholder="Telefono">
                    </div>
                    <label>Datos del Padre/Apoderado</label>
                    <div class="panel panel-primary">
                        <div class="panel-body">
                            <div class="form-group col-md-6">
                        <label for="txtDNIPadre">DNI del padre/apoderado</label>
                        <input type="email" class="form-control" id="txtDNIPadre" placeholder="DNIPadre">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtNombresPadre">Nombres del padre/apoderado</label>
                        <input type="email" class="form-control" id="txtNombresPadre" placeholder="NombresPadre">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoPaternoPadre">Apellido paterno del padre/apoderado</label>
                        <input type="email" class="form-control" id="txtApellidoPaternoPadre" placeholder="Apellido paterno padre">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoMaternoPadre">Apellido materno del padre/apoderado</label>
                        <input type="email" class="form-control" id="txtApellidoMaternoPadre" placeholder="Apellido materno padre">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtDireccionPadre">Direccion del padre/apoderado</label>
                        <input type="email" class="form-control" id="txtDireccionPadre" placeholder="Direccion padre">
                    </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6"></div>
                        <div class="col-md-6">
                            <a class="col-md-5 btn btn-primary" style="margin-right: 10px" href="/">Cancelar</a>
                            <a class="col-md-5 btn btn-primary" style="margin-right: 10px" href="/">Reservar matricula</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {


        });
        function reservar() {
            $.ajax({
                type: 'POST',
                url: 'ConfirmarMatricula.aspx/Login',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                cache: false,
                data: JSON.stringify({ login: $('#nivel').find('option:selected').text(), clave: $('#grado').find('option:selected').text() }),
                success: function (data) {
                    var alumno = data.d;
                    if (alumno != null && alumno != undefined) {
                        alert("Bienvenido al sistema");
                        $('#dvLogin').hide();
                        $('#dvConfirmacion').show();

                    } else {
                        //alert("Grado/Nivel no seleccionado(s)");
                        $('#dvLogin').hide();
                        $('#dvConfirmacion').show();
                    }
                },
                error: function (xhr, status, error) {
                    alert("No se pudo proceder a la reserva de matricula");
                }
            });
        }
        function ReservarMat() {
            if ($("#txtDNIPadre").value.lenght != 0) {
                $.ajax({
                    type: 'POST',
                    url: 'ConfirmarMatricula.aspx/Reservar',
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    async: true,
                    cache: false,
                    success: function (data) {
                        var alumno = data.d;
                        if (data.d == "OK") {
                            alert("Su solicitud fue registrada satisfactoriamente");
                            document.location.href = "/";
                        } else {
                            alert("Datos incorrectos");
                        }
                    },
                    error: function (xhr, status, error) {
                        alert(xhr.responseJSON.Message);
                    }
                });
            } else {
                alert("Para poder reservar tiene que llenar todos los datos.");
            }
        }
    </script>
</asp:Content>
