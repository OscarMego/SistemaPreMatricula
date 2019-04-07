<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SistemaDePrematricula._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-sm-12" style="cursor: pointer">
                <a runat="server" href="~/ConfirmarMatricula">
                    <img src="image/confirmar-matricula.png" style="width: 250px" />
                    <h2>Confirmar Matrícula</h2>
                </a>
            </div>
            <div class="col-lg-6 col-sm-12" style="cursor: pointer">
                <a runat="server" href="~/GestionSolicitudes">
                    <img src="image/gestionar-matricula.png" style="width: 250px" /><h2>Gestionar Matrícula</h2>
                </a>
            </div>

        </div>
        <div class="row">
            <div class="col-lg-6 col-sm-12" style="cursor: pointer">
                <a runat="server" href="~/ConsultarCursos">
                    <img src="image/consultar-cursos.png" style="width: 250px" /><h2>Consultar Cursos</h2>
                </a>
            </div>
            <div class="col-lg-6 col-sm-12" style="cursor: pointer">
                <a runat="server" href="~/ReservaMatricula">
                    <img src="image/reservar.svg" style="width: 250px" /><h2>Reservar Pre Matrícula</h2>
                </a>
            </div>

        </div>
    </div>
</asp:Content>
