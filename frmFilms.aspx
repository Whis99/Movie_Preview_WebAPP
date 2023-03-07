<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFilms.aspx.cs" Inherits="Movie.frmFilms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>MoviePreview</title>

    <!-- CSS only -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous"/>
</head>

<body>
    <div class="page-header text-bg-success bg-gradient">
        <div class="card text-bg-success">
            <h1 class="text-center fw-semibold">Movie Preview</h1>
        </div>
    </div>

    <form id="form1" runat="server">
        
        <br />
        
        <div class="card mb-7">
          <div class="row g-0">
            <div class="col-md-4">
                <a href="frmFilmDetail.aspx">
                    <asp:Image ID="mPoster" runat="server" width ="450px" height ="500px"/>
                </a>
            </div>

            <div class="col-md-5">
              <div class="card-body">
                <asp:Panel ID="Panel" class="rounded-circle" runat="server" BackColor="#CC0000" Height="20px" Width="20px">
                </asp:Panel>
                <h5 class="card-title fw-semibold">
                    <asp:Label ID="title" runat="server"></asp:Label>
                </h5>

                <ul class="list-group list-group-flush">

                <li class="list-group-item">
                    <p class="card-text">
                        <asp:Label ID="description" runat="server"></asp:Label>
                    </p>
                </li>

                <li class="list-group-item">
                      <p class="card-text">
                        <asp:Label ID="langage" runat="server"></asp:Label>
                    </p>
                </li>

                <li class="list-group-item">
                    <p class="card-text">
                    <asp:Label ID="voteAv" runat="server"></asp:Label>
                    </p>
                </li>
                <li class="list-group-item">
                    <p class="card-text">
                        <small class="text-muted">
                            <asp:Label ID="date" runat="server"></asp:Label>
                        </small>
                    </p>
                </li>

                    <br />

                <li class="list-group-item">
                    <asp:Button ID="previous" class="btn btn-outline-success btn-md" runat="server" Text="Précedent" Font-Bold="True" OnClick="previous_Click" Width="100px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="next" runat="server" class="btn btn-outline-success btn-md" Text="Suivant" Font-Bold="True" OnClick="next_Click" Width="100px" />
                </li>

                </ul>
              </div>
            </div>
          </div>
        </div>
        
    </form>

    <!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/js/bootstrap.bundle.min.js" integrity="sha384-OERcA2EqjJCMA+/3y+gxIOqMEjwtxJY7qPCqsdltbNJuaOe923+mo//f6V8Qbsw3" crossorigin="anonymous"></script>
</body>

    <div class="text-bg-success bg-gradient">
    <!-- Footer -->
    <footer class="page-footer font-small blue">

      <!-- Copyright -->
      <div class="footer-copyright text-center py-3">
          © 2022 Copyright: haugustin3
      </div>
      <!-- Copyright -->

    </footer>
    <!-- Footer -->
    </div>
</html>
