<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReservaNuevo.aspx.cs" Inherits="SistemaDePrematricula.ReservaNuevo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<h1>Reserva de matrícula para alumnos nuevos</h1>
<h3>Datos del estudiante</h3>
     <div class="container">
            <div class="panel panel-primary">
                <div class="panel-body">
                    <div class="form-group col-md-6">
                        <label for="txtDNI">DNI</label>
                        <asp:TextBox ID="txtDNI" type="email" CssClass="form-control" placeholder="DNI" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtNombres">Nombres</label>
                        <asp:TextBox ID="txtNombres" runat="server" type="email" CssClass="form-control" placeholder="Nombres"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoPaterno">Apellido paterno</label>
                        <asp:TextBox type="email" CssClass="form-control" id="txtApellidoPaterno" placeholder="Apellido paterno" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoMaterno">Apellido materno</label>
                        <asp:TextBox type="email" CssClass="form-control" id="txtApellidoMaterno" placeholder="Apellido materno" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtSexo">Sexo</label>
                        <asp:DropDownList type="email" CssClass="form-control" ID="cboSexo" runat="server">
                            <asp:ListItem>Ingrese Genero</asp:ListItem>
                            <asp:ListItem>Masculino</asp:ListItem>
                            <asp:ListItem>Femenino</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtFechaNacimiento">Fecha de Nacimiento</label>
                        <td>Fecha Nacimiento :<div><asp:Calendar ID="datepicker" runat="server" Visible="False"  BackColor="White" BorderColor="Black" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px" BorderStyle="Double" CellSpacing="1" OnSelectionChanged="datepicker_SelectionChanged">
                            <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                            <DayStyle BackColor="#CCFFFF" BorderColor="#006699" BorderStyle="Dotted" BorderWidth="1px" />
                            <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                            <OtherMonthDayStyle ForeColor="#FFFFFF" />
                            <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                            <TitleStyle BackColor="#333399" Font-Bold="True" Font-Size="12pt" ForeColor="White" BorderStyle="Solid" Height="12pt" />
                            <TodayDayStyle BackColor="#FFFFFF" ForeColor="White" />
                            </asp:Calendar></div>
                            <asp:TextBox ID="txtdtp" runat="server"></asp:TextBox><asp:LinkButton ID="lnkpickdate" runat="server" OnClick="lnkpickdate_Click" >Fecha</asp:LinkButton>
                        </td>

                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtNivel">Nivel</label>
                        <asp:TextBox type="email" class="form-control" id="txtNivel" placeholder="Nivel" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtGrado">Grado</label>
                        <asp:TextBox type="email" class="form-control" id="txtGrado" placeholder="Grado" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
     </div>

    <h3>Datos del padre o apoderado</h3>
    <div class="container">
            <div class="panel panel-primary">
                <div class="panel-body">
                    <div class="form-group col-md-6">
                        <label for="txtDNI">DNI</label>
                        <asp:TextBox ID="TextBox8" type="email" CssClass="form-control" placeholder="DNI" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtNombres">Nombres</label>
                        <asp:TextBox ID="TextBox9" runat="server" type="email" CssClass="form-control" placeholder="Nombres"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoPaterno">Apellido paterno</label>
                        <asp:TextBox type="email" CssClass="form-control" id="TextBox10" placeholder="Apellido paterno" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtApellidoMaterno">Apellido materno</label>
                        <asp:TextBox type="email" CssClass="form-control" id="TextBox11" placeholder="Apellido materno" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtDireccion">Dirección</label>
                        <asp:TextBox type="email" CssClass="form-control" id="TextBox12" placeholder="Direccion" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtCelular">Celular</label>
                        <asp:TextBox type="email" CssClass="form-control" id="TextBox13" placeholder="Celular" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtCorreo">Correo</label>
                        <asp:TextBox type="email" class="form-control" id="TextBox14" placeholder="Correo" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-6">
                        <label for="txtParentezco">Parentezco</label>
                        <asp:TextBox type="email" class="form-control" id="TextBox15" placeholder="Parentezco" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>
        </div>

              <div class="row">
              <div class="col-md-4"></div>
              <div class="col-md-8">
                   <a class="col-md-4 btn btn-primary" style="margin-right: 10px" href="/">Cancelar</a>
                  <asp:Button ID="btnRRegistro" class="col-md-4 btn btn-primary" style="margin-right: 10px" runat="server" Text="Button" OnClick="btnRRegistro_Click" />
              </div>
              </div>


</asp:Content>
