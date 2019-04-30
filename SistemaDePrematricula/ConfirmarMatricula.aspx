<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ConfirmarMatricula.aspx.cs" Inherits="SistemaDePrematricula.ConfirmarMatricula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row " style="text-align: center;" id="dvLogin">
        <div class="col-sm-4 col-sm-offset-4" style="padding-top: 50px">
            <div class="login-panel panel  panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Login</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <input class="form-control" placeholder="Usuario" name="userID" id="userID" type="text"
                            value="">
                    </div>
                    <div class="form-group">
                        <input class="form-control" placeholder="Password" name="password" id="password"
                            type="password" value="">
                    </div>
                    <div class="form-group hide" id="idLoginFailded">
                        <p class="text text-danger">* Usuario/Password incorrecto</p>
                    </div>
                    <div class="form-group hide" id="idDataEmpy">
                        <p class="text text-danger">* Ingresa todos los datos</p>
                    </div>
                    <div class="btn btn-primary btn-lg btn-block" onclick="login()">Ingresar</div>

                </div>
            </div>
        </div>
    </div>
    <div id="dvConfirmacion" style="display: none">
        <div class="row">
            <div class="col-md-11">  <h1>Confirmación de matrícula</h1></div>
             <div class="col-md-1"><a href="/">Salir</a></div>
        </div>
      
        <div class="container">
            <div class="panel panel-primary">
                <div class="panel-body">
                    <div class="form-group col-md-6">
                        <label for="txtDNI">DNI</label>
                        <input type="email" class="form-control" id="txtDNI" placeholder="DNI" disabled="disabled">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtNombres">Nombres</label>
                        <input type="email" class="form-control" id="txtNombres" placeholder="Nombres" disabled="disabled">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoPaterno">Apellido paterno</label>
                        <input type="email" class="form-control" id="txtApellidoPaterno" placeholder="Apellido paterno" disabled="disabled">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoMaterno">Apellido materno</label>
                        <input type="email" class="form-control" id="txtApellidoMaterno" placeholder="Apellido materno" disabled="disabled">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtNivel">Nivel</label>
                        <input type="email" class="form-control" id="txtNivel" placeholder="Nivel" disabled="disabled">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtGrado">Grado</label>
                        <input type="email" class="form-control" id="txtGrado" placeholder="Grado" disabled="disabled">
                    </div>
                    <label>Reglamento de la institución</label>
                    <div class="panel panel-primary">
                        <div class="panel-body">
                            Artículo 1°.      Colegio S.A. es un centro educativo privado, mixto, bilingüe y laico, autorizado por el Ministerio de Educación. Tiene como finalidad brindar servicios educativos en los niveles de inicial, primaria y secundaria de la educación básica regular.

 

Artículo 2°.      El presente Reglamento norma los aspectos pedagógicos y administrativos del Colegio, obliga a todo el personal que labora en él, a sus alumnos y a los padres de familia, apoderados o tutores. Es complementado por las normas y disposiciones del Directorio del Colegio, respetando las normas legales que rigen la educación privada en el Perú.

 

CAPÍTULO II

LÍNEA AXIOLÓGICA Y OBJETIVOS
 

Artículo 3°.      Dentro de un ambiente de exigencia académica y de respeto y práctica de los valores que emanan de la dignidad de la persona humana, el Colegio brinda una educación de calidad. Para ello, orienta su currículo de acuerdo con la ciencia más moderna y aplica técnicas pedagógicas que potencian la reflexión, la curiosidad y los intereses de sus alumnos.

En un ambiente de orden y trabajo, reconoce la individualidad de cada alumno por lo que busca la adaptación personal de los programas y promueve el dinamismo, la creatividad y la confianza de cada uno de ellos.
La educación es bilingüe y busca que sus alumnos dominen la lengua inglesa. Prepara a sus alumnos para el acceso a la educación superior.

CAPÍTULO III

DURACIÓN, CONTENIDO, METODOLOGÍA Y SISTEMA PEDAGÓGICO DEL PLAN CURRICULAR DE CADA AÑO O PERIODO DE ESTUDIOS
 

Artículo 4°.      La duración, el contenido, la metodología y el sistema pedagógico del plan curricular de cada grado son aprobados por el Directorio a propuesta del Director General. Toda la información del plan curricular estará a disposición de los padres de familia, apoderados o tutores.

 

Artículo 5°.      El calendario escolar y el horario de clases lo establece el Directorio al comienzo del año escolar, de acuerdo a cada nivel.

 

Artículo 6°.      La asistencia y puntualidad de los alumnos se controla de acuerdo con las disposiciones del Colegio. Las justificaciones de las inasistencias o tardanzas se realizan por escrito. Igualmente, las solicitudes de permisos de salida antes de hora, así como de inasistencias previsibles deberán ser solicitadas al Director de Nivel por escrito con la debida anticipación. Las inasistencias injustificadas, en el porcentaje que fija el Colegio en el Reglamento de Evaluación, impiden la aprobación de un área curricular o el año escolar.

 

Artículo 7°.      Las exoneraciones para las áreas curriculares de Educación Religiosa y Educación Física u otras que pudieran presentarse se autorizan de acuerdo con las disposiciones oficiales vigentes y se solicitan por escrito en el momento de la matrícula. En casos excepcionales podrá verse dicha solicitud en otro momento del año.

 

Artículo 8°.     Las excursiones y visitas de estudio son parte del currículo. El Colegio las coordina y los padres de familia deben autorizar por escrito la participación de sus hijos.

 

Artículo 9°.      Los idiomas empleados en la enseñanza son el castellano y el inglés, según sea el área curricular. Los alumnos deberán rendir la prueba de suficiencia de inglés para graduarse. Adicionalmente, en secundaria aprenderán como tercer idioma el francés.
                            <br />
                            <br />
                            <br />
                            <div class="form-group">
                                <div class="form-check">
                                    <input class="form-check-input" type="checkbox" id="chkReglamento">
                                    <label class="form-check-label" for="chkReglamento">
                                        Confirmo haber leido el reglamento y acepto.
                                    </label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-6"></div>
                        <div class="col-md-6">
                            <a class="col-md-5 btn btn-primary" style="margin-right: 10px" href="/">Cancelar</a>
                            <div class="col-md-6 btn btn-primary" onclick="Reservar()">Confirmar matrícula</div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {


        });
        function login() {
            $.ajax({
                type: 'POST',
                url: 'ConfirmarMatricula.aspx/Login',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                cache: false,
                data: JSON.stringify({ login: $('#userID').val(), clave: $('#password').val() }),
                success: function (data) {
                    var alumno = data.d;
                    if (alumno != null && alumno != undefined) {
                        alert("Bienvenido al sistema");
                        $('#dvLogin').hide();
                        $('#txtDNI').val(alumno.DNI);
                        $('#txtNombres').val(alumno.Nombres);
                        $('#txtApellidoPaterno').val(alumno.ApellidoPaterno);
                        $('#txtApellidoMaterno').val(alumno.ApellidoMaterno);
                        $('#txtNivel').val(alumno.Nivel);
                        $('#txtGrado').val(alumno.Grado);
                        $('#dvConfirmacion').show();

                    } else {
                        alert("Usuario/Contraseña incorrecto");
                    }
                },
                error: function (xhr, status, error) {
                    alert("No se pudo iniciar sesión");
                }
            });
        }
        function Reservar() {
            if ($("#chkReglamento").is(':checked')) {
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
                            alert("Usuario/Contraseña incorrecto");
                        }
                    },
                    error: function (xhr, status, error) {
                        alert(xhr.responseJSON.Message);
                    }
                });
            } else {
                alert("Para poder reservar tiene que aceptar los reglamentos.");
            }
        }
    </script>
</asp:Content>
