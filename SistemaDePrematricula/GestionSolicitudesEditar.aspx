<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GestionSolicitudesEditar.aspx.cs" Inherits="SistemaDePrematricula.GestionSolicitudesEditar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edición de la Solicitud - Sistema de Pre Matrícula</title>
    
    <webopt:bundlereference runat="server" path="~/Content/css" />
</head>
<body>
    <form id="form1" runat="server">
        
        <asp:ScriptManager runat="server">
            <Scripts>
                <%--To learn more about bundling scripts in ScriptManager see https://go.microsoft.com/fwlink/?LinkID=301884 --%>
                <%--Framework Scripts--%>
                <asp:ScriptReference Name="MsAjaxBundle" />
                <asp:ScriptReference Name="jquery" />
                <asp:ScriptReference Name="bootstrap" />
                <asp:ScriptReference Name="WebForms.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebForms.js" />
                <asp:ScriptReference Name="WebUIValidation.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebUIValidation.js" />
                <asp:ScriptReference Name="MenuStandards.js" Assembly="System.Web" Path="~/Scripts/WebForms/MenuStandards.js" />
                <asp:ScriptReference Name="GridView.js" Assembly="System.Web" Path="~/Scripts/WebForms/GridView.js" />
                <asp:ScriptReference Name="DetailsView.js" Assembly="System.Web" Path="~/Scripts/WebForms/DetailsView.js" />
                <asp:ScriptReference Name="TreeView.js" Assembly="System.Web" Path="~/Scripts/WebForms/TreeView.js" />
                <asp:ScriptReference Name="WebParts.js" Assembly="System.Web" Path="~/Scripts/WebForms/WebParts.js" />
                <asp:ScriptReference Name="Focus.js" Assembly="System.Web" Path="~/Scripts/WebForms/Focus.js" />
                <asp:ScriptReference Name="WebFormsBundle" />
                <%--Site Scripts--%>
            </Scripts>
        </asp:ScriptManager>
        
        <input id="txtIdPreMatricula" type="hidden" runat="server" />
        <input id="txtCertificado" type="hidden" runat="server" />
        <input id="txtIdNivel" type="hidden" runat="server" />
        <input id="txtDNIApoderado" type="hidden" runat="server" />
        <input id="txtNombreApoderado" type="hidden" runat="server" />
        <input id="txtCorreoApoderado" type="hidden" runat="server" />

        <div class="container body-content">
            <h2>Edición de la Solicitud</h2>
            <div class="container">
                <div class="panel panel-primary">
                    <div class="panel-body">
                        <div class="form-group col-md-6">
                            <label for="txtDNI">DNI</label>
                            <input type="text" class="form-control" id="txtDNI" placeholder="DNI" runat="server" disabled="disabled" />
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtNombres">Nombres</label>
                            <input type="text" class="form-control" id="txtNombres" placeholder="Nombres" runat="server" disabled="disabled" />
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtNivel">Nivel</label>
                            <input type="text" class="form-control" id="txtNivel" placeholder="Nivel" runat="server" disabled="disabled" />
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtGrado">Grado</label>
                            <input type="text" class="form-control" id="txtGrado" placeholder="Grado" runat="server" disabled="disabled" />
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtTipo">Tipo</label>
                            <input type="text" class="form-control" id="txtTipo" placeholder="Tipo" runat="server" disabled="disabled" />
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtSolicitud">F. Solicitud</label>
                            <input type="text" class="form-control" id="txtSolicitud" runat="server" disabled="disabled" />
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtEstado">Estado</label>
                            <select class="form-control" id="txtEstado" runat="server">
                                <option value="Aceptado">Aceptado</option>
                                <option value="Citado">Citado</option>
                                <option value="Pendiente">Pendiente</option>
                                <option value="Rechazado">Rechazado</option>
                            </select>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtCita">F. Cita</label>
                            <input type="text" class="form-control" id="txtCita" runat="server" />
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtAlertas">Alertas</label>
                            <textarea id="txtAlertas" class="form-control" cols="20" rows="4" runat="server" disabled="disabled"></textarea>
                        </div>
                        <div class="form-group col-md-6">
                            <label for="txtObservaciones">Observaciones</label>
                            <textarea id="txtObservaciones" class="form-control" cols="20" rows="4" runat="server"></textarea>
                        </div>
                        <div class="row">
                            <div class="col-md-6"></div>
                            <div class="col-md-6">
                                <a class="col-md-5 btn btn-primary" style="margin-right: 10px" href="javascript:window.close();">Cancelar</a>
                                <div class="col-md-6 btn btn-primary" onclick="Grabar()">Grabar</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>

        <script type="text/javascript">

            function Grabar() {
                var ls_solicitud = $("#txtSolicitud").val();
                var ls_cita = $("#txtCita").val();
                ls_solicitud = ls_solicitud.substr(3, 2) + "/" + ls_solicitud.substr(0, 2) + "/" + ls_solicitud.substr(6, 4); //25/04/2019

                var objSolicitud = new Object();
                objSolicitud.NroDniAlumno = $("#txtDNI").val();
                objSolicitud.NroDniApoderado = $("#txtDNIApoderado").val();
                objSolicitud.Certificado = $("#txtCertificado").val();
                objSolicitud.IdNivel = parseInt($("#txtIdNivel").val());
                objSolicitud.Tipo = $("#txtTipo").val();
                objSolicitud.Estado = $("#txtEstado").val();
                objSolicitud.Observaciones = $("#txtObservaciones").val();
                objSolicitud.FechaSolicitud = new Date(Date.parse(ls_solicitud));
                objSolicitud.FechaRespuesta = new Date(Date.now());
                objSolicitud.IdPreMatricula = parseInt($("#txtIdPreMatricula").val());

                var objApoderado = new Object();
                objApoderado.Nombres = $("#txtNombreApoderado").val();
                objApoderado.Correo = $("#txtCorreoApoderado").val();

                if (objSolicitud.Estado == "Citado")
                {
                    if (ls_cita == "") {
                        alert('Ingrese la Fecha de la Cita');
                        $("#txtCita").focus();
                        return;
                    }
                    ls_cita = ls_cita.substr(3, 2) + "/" + ls_cita.substr(0, 2) + "/" + ls_cita.substr(6, 4);
                    objSolicitud.FechaCita = new Date(Date.parse(ls_cita));
                }
                
                $.ajax({
                    type: 'POST',
                    url: 'GestionSolicitudesEditar.aspx/Grabar',
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    async: true,
                    cache: false,
                    data: JSON.stringify({ solicitud: objSolicitud, apoderado: objApoderado }),
                    success: function (data) {
                        var solicitud = data.d;
                        if (data.d == "OK") {
                            alert("El registro fué grabado satisfactoriamente");
                            window.opener.actualizarLista();
                            window.close();
                        } else {
                            alert("datos incorrectos");
                        }
                    },
                    error: function (xhr, status, error) {
                        alert(xhr.responseJSON.Message);
                    }
                });
            }

        </script>
    </form>
</body>
</html>
