<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GestionSolicitudes.aspx.cs" Inherits="SistemaDePrematricula.GestionSolicitudes" %>

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
             <div class="col-md-offset-11 col-md-1"><a href="/">Salir</a></div>
        </div>
        <h1>Lista de Solicitudes</h1>
        <div class="container">
            <div class="panel panel-primary">
                <div class="panel-body">
                    <div id="dvTabla"></div>
                </div>
            </div>
        </div>
    </div>

    <script>
        function login() {
            $.ajax({
                type: 'POST',
                url: 'GestionSolicitudes.aspx/Login',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                cache: false,
                data: JSON.stringify({ login: $('#userID').val(), clave: $('#password').val() }),
                success: function (data) {
                    var solicitudes = data.d;
                    if (solicitudes != null && solicitudes != undefined) {
                        alert("Bienvenido al sistema");
                        $('#dvLogin').hide();
                        cargarTabla(solicitudes);
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

        function actualizarLista() {
            $.ajax({
                type: 'POST',
                url: 'GestionSolicitudes.aspx/ActualizarLista',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                cache: false,
                success: function (data) {
                    var solicitudes = data.d;
                    if (solicitudes != null && solicitudes != undefined) {
                        cargarTabla(solicitudes);
                    }
                },
                error: function (xhr, status, error) {
                    alert("No se pudo actualizar la lista");
                }
            });
        }

        function cargarTabla(solicitudes) {
            var tabla = '<table class="table table-hover"><thead><tr><th scope="col">DNI</th> <th scope="col">Alumno</th><th scope="col">Nivel</th><th scope="col">Grado</th><th scope="col">Tipo</th><th scope="col">Estado</th><th scope="col">Fecha Solicitud</th><th scope="col"></th></tr></thead><tbody>'
            for (var i = 0; i < solicitudes.length; i++) {
                solicitudes[i].FechaSolicitud = solicitudes[i].FechaSolicitud.replace('/Date(', '');
                solicitudes[i].FechaSolicitud = solicitudes[i].FechaSolicitud.replace(')/', '');
                var expDate = new Date(parseInt(solicitudes[i].FechaSolicitud));
                tabla = tabla + '<tr><td>' + solicitudes[i].NroDniAlumno + '</td><td>' + solicitudes[i].NombreApellidoAlumno + '</td><td>' +
                    solicitudes[i].Nivel + '</td><td>' + solicitudes[i].Grado + '</td><td>' + solicitudes[i].Tipo + '</td><td>' + solicitudes[i].Estado +
                    '</td><td>' + ("0" + expDate.getDate()).slice(-2) + "-" + ("0" + (expDate.getMonth() + 1)).slice(-2) + "-" + expDate.getFullYear() + '</td><td><a title="Editar la solicitud" href="javascript:openWindow(&quot;GestionSolicitudesEditar.aspx?a=M&id=' + solicitudes[i].IdPreMatricula + '&dni=' + solicitudes[i].NroDniAlumno + '&quot;,1000,600);">Editar</a></td></tr>';
            }
            tabla = tabla + '<tbody></table>';
            $('#dvTabla').html(tabla);
        }

        var w_id = null;

        function openWindow(aUrl,aWidth,aHeight,x,y) {
	        var ls_BarFeatures = "location=no, menubar=no, resizable=no,scrollbars=no, titlebar=no, toolbar=no"

	        if (!x) {
		        x = (window.screen.availWidth - 10 - aWidth) /2;
		        y = (window.screen.availHeight -30 - aHeight) /2;
	        }
	        if (w_id) w_id.close()
	
	        var aW, aH, ls_aw_ah="";
            if (aUrl.indexOf("AW")<=0) {
	            aW = aWidth + 10;
	            aH = aHeight + 10;
	            ls_aw_ah = "&AW=" + aW + "&AH=" + aH
	        }
	
            w_id = window.open (aUrl + ls_aw_ah,"","height="+ aHeight +", width=" + aWidth +", left=" + x +", top=" + y +"," + ls_BarFeatures) 
        }
    </script>
</asp:Content>
