<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservaNuevo.aspx.cs" Inherits="SistemaDePrematricula.ReservaNuevo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row " style="text-align: center;" id="dvVerificarVacante">
        <div class="col-sm-6 col-sm-offset-4" style="padding-top: 50px">
            <div class="login-panel panel  panel-primary">
                <div class="panel-heading">
                    <h3 class="panel-title">Consulta de vacantes</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group col-md-6">
                        <label for="cboNivelVerificacion">Nivel</label>
                        <select class="form-control" id="cboNivelVerificacion">
                            <option selected>Seleccionar...</option>
                            <option value="Primario">Primaria</option>
                            <option value="Secundario">Secundaria</option>
                        </select>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="cboGradoVericacion">Grado</label>
                        <select class="form-control" id="cboGradoVerificacion">
                        </select>
                    </div>
                </div>
                <div class="panel-footer">
                    <div class="btn btn-primary btn-lg btn-block" onclick="verificarVacante()">Verificar</div>
                </div>
            </div>
        </div>
    </div>


    <div id="dvReserva" style="display: none">
        <h1>Reserva de matrícula para alumnos nuevos</h1>
        <h3>Datos del estudiante</h3>
        <div class="container">
            <div class="panel panel-primary">
                <div class="panel-body">
                    <div class="form-group col-md-6">
                        <label for="txtDNI">DNI</label>
                        <input type="text" id="txtDNI" placeholder="DNI Alumno" class="form-control" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtNombres">Nombres</label>
                        <input id="txtNombres" type="text" class="form-control" placeholder="Nombres" />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoPaterno">Apellido paterno</label>
                        <input type="text" class="form-control" id="txtApellidoPaterno" placeholder="Apellido paterno">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoMaterno">Apellido materno</label>
                        <input type="text" class="form-control" id="txtApellidoMaterno" placeholder="Apellido materno">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtSexo">Sexo</label>
                        <select class="form-control" id="txtSexo">
                            <option selected>Selecciona...</option>
                            <option value="Masculino">Masculino</option>
                            <option value="Femenino">Femenino</option>
                        </select>

                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtFechaNacimiento">Fecha de Nacimiento</label>
                        <select id="year"></select>
                        <select id="month"></select>
                        <select id="day"></select>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="cboNivel">Nivel</label>
                        <select class="form-control" id="cboNivel">
                            <option selected>Seleccionar...</option>
                            <option value="Primario">Primaria</option>
                            <option value="Secundario">Secundaria</option>
                        </select>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="cboGrado">Grado</label>
                        <select class="form-control" id="cboGrado">
                        </select>
                    </div>
                </div>
            </div>
        </div>

        <h3>Datos del padre o apoderado</h3>
        <div class="container">
            <div class="panel panel-primary">
                <div class="panel-body">
                    <div class="form-group col-md-6">
                        <label for="txtDniApoderado">DNI</label>
                        <input id="txtDniApoderado" type="text" onfocusout="verificarApoderado(this)" class="form-control" placeholder="DNI">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TextNombreApoderado">Nombres</label>
                        <input id="TextNombreApoderado" type="text" class="form-control" placeholder="Nombres">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TextApellidoPaternoApoderado">Apellido paterno</label>
                        <input type="text" class="form-control" id="TextApellidoPaternoApoderado" placeholder="Apellido paterno">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TextApellidoMeternoApoderado">Apellido materno</label>
                        <input type="text" class="form-control" id="TextApellidoMeternoApoderado" placeholder="Apellido materno">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TextDireccionApoderado">Dirección</label>
                        <input type="text" class="form-control" id="TextDireccionApoderado" placeholder="Direccion">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TextCelularApoderado">Celular</label>
                        <input type="text" class="form-control" id="TextCelularApoderado" placeholder="Celular">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TextCorreoApoderado">Correo</label>
                        <input type="email" class="form-control" id="TextCorreoApoderado" placeholder="Correo">
                    </div>
                    <div class="form-group col-md-6">
                        <label for="TextParentezco">Parentezco</label>
                        <input type="text" class="form-control" id="TextParentezco" placeholder="Parentezco">
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-8">
                <a class="col-md-4 btn btn-primary" style="margin-right: 10px" href="/">Cancelar</a>
                <button id="btnRRegistro" class="col-md-4 btn btn-primary" style="margin-right: 10px" onclick="registrarSolicitud()">Registrar</button>
            </div>
        </div>
    </div>
    <script>


        $(document).ready(function () {
            const monthNames = ["January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December"
            ];
            var qntYears = 20;
            var selectYear = $("#year");
            var selectMonth = $("#month");
            var selectDay = $("#day");
            var currentYear = new Date().getFullYear();

            for (var y = 0; y < qntYears; y++) {
                let date = new Date(currentYear);
                var yearElem = document.createElement("option");
                yearElem.value = currentYear
                yearElem.textContent = currentYear;
                selectYear.append(yearElem);
                currentYear--;
            }

            for (var m = 0; m < 12; m++) {
                let monthNum = new Date(2018, m).getMonth()
                let month = monthNames[monthNum];
                var monthElem = document.createElement("option");
                monthElem.value = monthNum;
                monthElem.textContent = month;
                selectMonth.append(monthElem);
            }

            var d = new Date();
            var month = d.getMonth();
            var year = d.getFullYear();
            var day = d.getDate();

            selectYear.val(year);
            selectYear.on("change", AdjustDays);
            selectMonth.val(month);
            selectMonth.on("change", AdjustDays);

            AdjustDays();
            selectDay.val(day)

            function AdjustDays() {
                var year = selectYear.val();
                var month = parseInt(selectMonth.val()) + 1;
                selectDay.empty();

                //get the last day, so the number of days in that month
                var days = new Date(year, month, 0).getDate();

                //lets create the days of that month
                for (var d = 1; d <= days; d++) {
                    var dayElem = document.createElement("option");
                    dayElem.value = d;
                    dayElem.textContent = d;
                    selectDay.append(dayElem);
                }
            }

            $('#cboNivel').on("change", function () {
                var grado = 5;
                if ($(this).val() === 'Primario') {
                    grado = 6;
                }
                $('#cboGrado').find('option').remove();
                $('#cboGrado').append('<option selected>Seleccionar..</option>');
                for (var i = 1; i <= grado; i++) {
                    $('#cboGrado').append('<option value="' + i + '">' + i + '</option>');
                }

            });
            $('#cboNivelVerificacion').on("change", function () {
                var grado = 5;
                if ($(this).val() === 'Primario') {
                    grado = 6;
                }
                $('#cboGradoVerificacion').find('option').remove();
                $('#cboGradoVerificacion').append('<option selected>Seleccionar..</option>');
                for (var i = 1; i <= grado; i++) {
                    $('#cboGradoVerificacion').append('<option value="' + i + '">' + i + '</option>');
                }

            });
        });
        function verificarApoderado(txtApdoerado) {
            $.ajax({
                type: 'POST',
                url: 'ReservaNuevo.aspx/ObtenerPoderado',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                cache: false,
                data: JSON.stringify({ dniApoderado: $(txtApdoerado).val() }),
                success: function (data) {
                    var apoderado = data.d;
                    if (apoderado != null && apoderado != undefined) {
                        if (confirm("El apoderado ya existe ¿Desea asignar a la misma persona?")) {
                            $('#txtDniApoderado').val(apoderado.NroDni);
                            $('#TextNombreApoderado').val(apoderado.Nombres);
                            $('#TextApellidoPaternoApoderado').val(apoderado.ApellidoPaterno);
                            $('#TextApellidoMeternoApoderado').val(apoderado.ApellidoMaterno);
                            $('#TextDireccionApoderado').val(apoderado.Direccion);
                            $('#TextCelularApoderado').val(apoderado.NroCelular);
                            $('#TextCorreoApoderado').val(apoderado.Correo);
                            $('#TextParentezco').val(apoderado.Parentesco);
                            $('#dvConfirmacion').show();
                        } else {
                            $('#txtDniApoderado').val('');
                        }


                    }
                },
            });
        }
        function registrarSolicitud() {
            var objAlumno = new Object();
            objAlumno.DNI = $("#txtDNI").val();
            objAlumno.Nombres = $("#txtNombres").val();
            objAlumno.ApellidoPaterno = $("#txtApellidoPaterno").val();
            objAlumno.ApellidoMaterno = $("#txtApellidoMaterno").val();
            objAlumno.Sexo = $("#txtSexo").val();
            objAlumno.FechaNacimiento = $("#day").val() + '/' + (parseInt($("#month").val()) + 1) + '/' + $('#year').val();
            objAlumno.Nivel = $("#cboNivel").val();
            objAlumno.Grado = $("#cboGrado").val();
            objAlumno.NroDniApoderado = $("#txtDniApoderado").val();

            var objApoderado = new Object();
            objApoderado.NroDni = $("#txtDniApoderado").val();
            objApoderado.Nombres = $("#TextNombreApoderado").val();
            objApoderado.ApellidoPaterno = $("#TextApellidoPaternoApoderado").val();
            objApoderado.ApellidoMaterno = $("#TextApellidoMeternoApoderado").val();
            objApoderado.Direccion = $("#TextDireccionApoderado").val();
            objApoderado.NroCelular = $("#TextCelularApoderado").val();
            objApoderado.Correo = $("#TextCorreoApoderado").val();
            objApoderado.Parentesco = $("#TextParentezco").val();

            //VALIDACIONES

            if (objAlumno.DNI == '') {
                alert('Ingrese el DNI del estudiante');
                $("#txtDNI").focus();
                return;
            }

            if (objAlumno.Nombres == '') {
                alert('Ingrese Nombres del estudiante');
                $("#txtNombres").focus();
                return;
            }

            if (objAlumno.ApellidoPaterno == '') {
                alert('Ingrese el apellido paterno del estudiante');
                $("#txtApellidoPaterno").focus();
                return;
            }

            if (objAlumno.ApellidoMaterno == '') {
                alert('Ingrese el apellido materno del estudiante');
                $("#txtApellidoMaterno").focus();
                return;
            }

            if (objAlumno.Sexo == '') {
                alert('Ingrese el sexo del estudiante');
                $("#txtSexo").focus();
                return;
            }

            if (objAlumno.FechaNacimiento == '') {
                alert('Ingrese la fecha de nacimiento del estudiante');
                $("#FechaNacimiento").focus();
                return;
            }

            if (objAlumno.Nivel == '') {
                alert('Ingrese el nivel de estudios del estudiante');
                $("#Nivel").focus();
                return;
            }

            if (objAlumno.Grado == '') {
                alert('Ingrese el grado del estudiante');
                $("#Grado").focus();
                return;
            }

            if (objApoderado.NroDni == '') {
                alert('Ingrese el DNI del padre o apoderado.');
                $("#txtDniApoderado").focus();
                return;
            }

            if (objApoderado.Nombres == '') {
                alert('Ingrese el nombre del padre o apoderado.');
                $("#TextNombreApoderado").focus();
                return;
            }

            if (objApoderado.ApellidoPaterno == '') {
                alert('Ingrese el apellido paterno del padre o apoderado.');
                $("#TextApellidoPaternoApoderado").focus();
                return;
            }

            if (objApoderado.ApellidoMaterno == '') {
                alert('Ingrese el apellido materno del padre o apoderado.');
                $("#TextApellidoMeternoApoderado").focus();
                return;
            }

            if (objApoderado.Direccion == '') {
                alert('Ingrese la dirección del padre o apoderado.');
                $("#TextDireccionApoderado").focus();
                return;
            }

            if (objApoderado.NroCelular == '') {
                alert('Ingrese el número de celular del padre o apoderado.');
                $("#TextCelularApoderado").focus();
                return;
            }

            if (objApoderado.Correo == '') {
                alert('Ingrese el coreo del padre o apoderado.');
                $("#TextCorreoApoderado").focus();
                return;
            }

            if (objApoderado.Parentesco == '') {
                alert('Ingrese el parentezo del padre o apoderado con el estudiante.');
                $("#TextParentezco").focus();
                return;
            }
            $.ajax({
                type: 'POST',
                url: 'ReservaNuevo.aspx/CrearSolicitud',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                cache: false,
                data: JSON.stringify({ alumno: objAlumno, apoderado: objApoderado }),
                success: function (data) {
                    var apoderado = data.d;
                    if (apoderado === 'OK') {
                        alert('Tu reserva se generó con éxito');
                        document.location.href = "/";
                    } else {
                        alert('No se pudo generar la reserva, intetalo más tarde.');
                    }
                },
            });
        }
        function verificarVacante() {
            $.ajax({
                type: 'POST',
                url: 'ReservaNuevo.aspx/ObtenerNivel',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                cache: false,
                data: JSON.stringify({ nivel: $('#cboNivelVerificacion').val(), grado: $('#cboGradoVerificacion').val() }),
                success: function (data) {
                    var nivel = data.d;
                    if (nivel !== null && nivel != undefined) {

                        if (nivel.DisponibleVacantes != 0) {
                            if (confirm("Si se encontraron vacantes disponibles ¿Desea realizar la reservas?")) {
                                $('#dvVerificarVacante').hide();
                                $('#dvReserva').show();
                            } else {
                                document.location.href = "/";
                            }
                        } else {

                            alert('No existe vacante para este nivel ni grado.');
                            document.location.href = "/";
                        }


                    } else {
                        alert('No se pudo verificar el nivel');
                    }
                }, error: function (XMLHttpRequest, textStatus, errorThrown) {
                    alert("some error");
                }
            });
        }
    </script>
</asp:Content>
