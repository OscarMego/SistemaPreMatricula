 <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConsultarCursos.aspx.cs" Inherits="SistemaDePrematricula.ConsultarCursos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row " style="text-align: center;" id="dvSeleccionGrado">
        <div class="col-sm-4 col-sm-offset-4" style="padding-top: 50px">
            <div class="login-panel panel  panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Consultar de Cursos</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <select name="nivel" id="nivel">
                            <option value="">Seleccione un nivel</option>
                            <option value="primaria">Primaria</option>
                            <option value="secundaria">Secundaria</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <select name="grado" id="grado">
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
                    <div class="btn btn-primary btn-lg btn-block" onclick="mostrar()">Mostrar</div>

                </div>
            </div>
        </div>
    </div>
    <div id="dvCursos" style="display: none">
        <h1>Consulta de cursos</h1>
        <div class="container">
            <div class="panel panel-primary">
                <div class="panel-body">
                    <label>Consulta de Cursos</label>
                    <div class="panel panel-primary">
                        <div class="panel-body">
                            <table>
                                <tbody>
                                    <tr>
                                        <td>
                                            <table border="1">
                                                <tbody>
                                                    <tr>
                                                        <td>Cursos Normales</td>
                                                        <td>Descripcion</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Matematica 1</td>
                                                        <td>Curso de matematica 1</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Fisica 1</td>
                                                        <td>Curso de fisica 1</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Historia del Peru</td>
                                                        <td>Curso de Historia del Peru</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Quimica</td>
                                                        <td>Curso de Quimica</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                        <td>
                                            <table border="1">
                                                <tbody>
                                                    <tr>
                                                        <td>Cursos Extracurriculares</td>
                                                        <td>Descripcion</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Teatro</td>
                                                        <td>Curso de teatro</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Carpinteria</td>
                                                        <td>Curso de carpinteria</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Cocina</td>
                                                        <td>Curso de cocina</td>
                                                    </tr>
                                                </tbody>
                                            </table>
                                        </td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6"></div>
                        <div class="col-md-6">
                            <a class="col-md-5 btn btn-primary" style="margin-right: 10px" href="/">Aceptar</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $('#nivel').on("change", function () {
                var grado = 5;
                if ($(this).val() === 'primaria') {
                    grado = 6;
                }
                var grados = [ "Primero", "Segundo", "Tercero", "Cuarto", "Quinto", "Sexto" ];
                $('#grado').find('option').remove();
                $('#grado').append('<option selected>Seleccione un grado</option>');
                for (var i = 0; i < grado; i++) {
                    $('#grado').append('<option value="' + i + '">' + grados[i] + '</option>');
                }

            });
        });
        function mostrar() {
            $.ajax({
                type: 'POST',
                url: 'ConsultarCursos.aspx/Login',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                cache: false,
                data: JSON.stringify({ login: $('#nivel').find('option:selected').text(), clave: $('#grado').find('option:selected').text() }),
                success: function (data) {
                    var alumno = data.d;
                    if (alumno != null && alumno != undefined) {
                        alert("Bienvenido a la consulta de cursos");
                        $('#dvSeleccionGrado').hide();
                        $('#dvCursos').show();

                    } else {
                        //alert("Nivel/Grado no seleccionados");
                        $('#dvSeleccionGrado').hide();
                        $('#dvCursos').show();
                    }
                },
                error: function (xhr, status, error) {
                    alert("No se pudo consultar cursos");
                }
            });
        }
    </script>

</asp:Content>