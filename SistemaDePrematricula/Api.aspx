<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Api.aspx.cs" Inherits="SistemaDePrematricula.Api" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h1>Api SITECE</h1>
        Este servicio brinda acceso a la base de datos de alumnos con deudas a los colegios anteriores.<br />
        para poder acceder al servicio registrese en el siguiente link <a href="Asociado.aspx">Registrarse para obtener token</a> y le llegará un correo con un token y podrá usar el api.
        <br />
        <h1>Uso del API</h1>
        El api cuenta con metodos de carga de alumnos, consulta de alumno por dni y eliminación de alumno por dni.
        <h2>Consulta de alumno</h2>
        <h2>GET</h2>
        URL: http://localhost:50925/EstudianteService.svc/Estudiante/{token}/{dnialumno}
        <br />
        <h3>Response:</h3>
        <pre style="font-family: Andale Mono, Lucida Console, Monaco, fixed, monospace; color: #000000; background-color: #eee; font-size: 12px; border: 1px dashed #999999; line-height: 14px; padding: 5px; overflow: auto; width: 100%">
            <code style="color:#000000;word-wrap:normal;">
    [
        {
            "Anho": 1991,
            "Apellidos": "Perez",
            "Deuda": 56.45,    
            "Dni": "87654321",
            "FechaRegistro": "/Date(665384400000-0500)/",
            "IdAsociado": 1,
            "IdEstudiante": 1,
            "Nombres": "Juan"
        }
    ]
            </code>
        </pre>
        <h2>Insertado de alumno</h2>
        <h2>POST</h2>
        URL: http://localhost:52661/EstudianteService.svc/Estudiante/{token}
        <br />
        <h3>Request</h3>
        <pre style="font-family: Andale Mono, Lucida Console, Monaco, fixed, monospace; color: #000000; background-color: #eee; font-size: 12px; border: 1px dashed #999999; line-height: 14px; padding: 5px; overflow: auto; width: 100%">
            <pre style="font-family: Andale Mono, Lucida Console, Monaco, fixed, monospace; color: #000000; background-color: #eee; font-size: 12px; border: 1px dashed #999999; line-height: 14px; padding: 5px; overflow: auto; width: 100%">body: Application/json</pre>
            <code style="color:#000000;word-wrap:normal;">
    {
        "Anho": 2010,
        "Apellidos": "Perez",
        "Deuda": 56,
        "Dni": "87654321",
        "FechaRegistro": "/Date(665384400000-0500)/",
        "IdAsociado": 1,
        "IdEstudiante": 1,
        "Nombres": "Juan"
    }
            </code>
        </pre>
        <br />
        <h3>Respose</h3>
        <pre style="font-family: Andale Mono, Lucida Console, Monaco, fixed, monospace; color: #000000; background-color: #eee; font-size: 12px; border: 1px dashed #999999; line-height: 14px; padding: 5px; overflow: auto; width: 100%">
            <code style="color:#000000;word-wrap:normal;">
    {
        "Anho": 2010,
        "Apellidos": "Perez",
        "Deuda": 56,
        "Dni": "87654321",
        "FechaRegistro": "/Date(665384400000-0500)/",
        "IdAsociado": 1,
        "IdEstudiante": 2,
        "Nombres": "Juan"
    }
            </code>
        </pre>
        <h2>Eliminado de alumno</h2>
        <h2>DELETE</h2>
        URL:http://localhost:52728/EstudianteService.svc/Estudiante/{token}/{dniAlumno}/{año}
        <br />
        <br />
        <h3>Respose</h3>
        <pre style="font-family: Andale Mono, Lucida Console, Monaco, fixed, monospace; color: #000000; background-color: #eee; font-size: 12px; border: 1px dashed #999999; line-height: 14px; padding: 5px; overflow: auto; width: 100%">
            <code style="color:#000000;word-wrap:normal;">
    "Alumno eliminado"
            </code>
        </pre>
    </div>
</asp:Content>
