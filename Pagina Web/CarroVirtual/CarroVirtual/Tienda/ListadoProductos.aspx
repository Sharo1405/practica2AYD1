<%@ Page Title="" Language="C#" MasterPageFile="~/Tienda/TiendaTemplate.Master" AutoEventWireup="true" CodeBehind="ListadoProductos.aspx.cs" Inherits="CarroVirtual.Tienda.Productos" %>

<%@ Register Src="~/Tienda/CardProducto.ascx" TagPrefix="uc1" TagName="CardProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <!--Main layout-->
  <main>
    <div class="container">

      <!--Navbar-->
      <nav class="navbar navbar-expand-lg navbar-dark mdb-color lighten-3 mt-3 mb-5">

        <!-- Navbar brand -->
        <span class="navbar-brand">Categories:</span>

        <!-- Collapse button -->
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#basicExampleNav" aria-controls="basicExampleNav"
          aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>

        <!-- Collapsible content -->
        <div class="collapse navbar-collapse" id="basicExampleNav">

          <!-- Links -->
          <ul class="navbar-nav mr-auto">
            <li class="nav-item active">
              <asp:LinkButton ID="LinkButtonAll" runat="server" class="nav-link" OnClick="LinkButtonAll_Click" >ALL</asp:LinkButton>
                <span class="sr-only">(current)</span>
              </a>
            </li>
            <li class="nav-item">
                
             <asp:LinkButton ID="LinkButtonPS" runat="server" class="nav-link" OnClick="LinkButtonPS_Click" >PS</asp:LinkButton>

            </li>
            <li class="nav-item">
              <asp:LinkButton ID="LinkButtonNINTENDO" runat="server" class="nav-link" OnClick="LinkButtonNINTENDO_Click" >NINTENDO</asp:LinkButton>
            </li>
            <li class="nav-item">
              <asp:LinkButton ID="LinkButtonPC" runat="server" class="nav-link" OnClick="LinkButtonPC_Click" >PC</asp:LinkButton>
            </li>
              <li class="nav-item">
              <asp:LinkButton ID="LinkButtonXBOX" runat="server" class="nav-link" OnClick="LinkButtonXBOX_Click"  >XBOX</asp:LinkButton>
            </li>

          </ul>
          <!-- Links -->

          <form class="form-inline">
            <div class="md-form my-2">
              <!--input class="form-control mr-sm-2" type="text" placeholder="Search" aria-label="Search"-->
              <asp:TextBox class="form-control mr-sm-2" ID="searchText" runat="server" ></asp:TextBox>
              <asp:Button ID="Button1" runat="server" Text="Buscar" lass="nav-link" OnClick="Button1_Click"/> 

            </div>
          </form>
        </div>
        <!-- Collapsible content -->

      </nav>
      <!--/.Navbar-->

      <!--Section: Products v.3-->
      <section class="text-center mb-4">
        
            <!--Grid row-->
            <div class="row wow fadeIn">
               
              <asp:ListView ID="ListViewCardProducts" runat="server">
                  <ItemTemplate>

                      <uc1:CardProducto runat="server" id="CardProducto" ProductoCarrito="<%# Container.DataItem %>"/>

                  </ItemTemplate>

              </asp:ListView>

              

            </div>
            <!--Grid row-->
        

      </section>
      <!--Section: Products v.3-->

      <!--Pagination-->
      <nav class="d-flex justify-content-center wow fadeIn">
        <ul class="pagination pg-blue">

          <!--Arrow left-->
          <li class="page-item disabled">
            <a class="page-link" href="#" aria-label="Previous">
              <span aria-hidden="true">&laquo;</span>
              <span class="sr-only">Previous</span>
            </a>
          </li>

          <li class="page-item active">
            <a class="page-link" href="#">1
              <span class="sr-only">(current)</span>
            </a>
          </li>
          <li class="page-item">
            <a class="page-link" href="#">2</a>
          </li>
          <li class="page-item">
            <a class="page-link" href="#">3</a>
          </li>
          <li class="page-item">
            <a class="page-link" href="#">4</a>
          </li>
          <li class="page-item">
            <a class="page-link" href="#">5</a>
          </li>

          <li class="page-item">
            <a class="page-link" href="#" aria-label="Next">
              <span aria-hidden="true">&raquo;</span>
              <span class="sr-only">Next</span>
            </a>
          </li>
        </ul>
      </nav>
      <!--Pagination-->

    </div>
  </main>
  <!--Main layout-->

</asp:Content>
