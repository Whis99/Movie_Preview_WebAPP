<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmFilmDetail.aspx.cs" Inherits="Movie.frmFilmDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    

<head runat="server">
    <!-- CSS only -->
    <title>MoviePreview</title>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-Zenh87qX5JnK2Jl0vWa8Ck2rdkQ2Bzep5IDxbcnCeuOxjzrPF/et3URy9Bv1WTRi" crossorigin="anonymous"/>  
</head>


<body>
    <div class="page-header text-bg-success bg-gradient"">
        <div class="card text-bg-success">
            <h1 class="text-center fw-semibold ">Details</h1>
        </div>
    </div>

    <form id="form1" runat="server">
    <br />

    <div class="card mb-7">
          <div class="row g-0">
            <div class="col-md-6">
                <iframe id="video" runat="server" width="670" height="500"
                    src='https://www.youtube.com/embed/{0}'>
                </iframe> 
                
            </div>
            <div class="col-md-5">
              <div class="card-body">
                <h5 class="card-title">
                    <asp:Label ID="title" runat="server"></asp:Label>
                </h5>

                <ul class="list-group list-group-flush">

                <li class="list-group-item">
                    <p class="card-text">
                        <asp:Label class="fw-semibold" ID="lblDcp" runat="server">Description: </asp:Label>
                        <asp:Label ID="description" runat="server"></asp:Label>
                    </p>
                </li>

                <li class="list-group-item">
                      <p class="card-text">
                          <asp:Label class="fw-semibold" ID="lblLangage" runat="server">Language: </asp:Label>
                        <asp:Label ID="langage" runat="server"></asp:Label>
                    </p>
                </li>

                <li class="list-group-item">
                    <p class="card-text">
                    <asp:Label class="fw-semibold" ID="lblAv" runat="server">Moyenne: </asp:Label>
                    <asp:Label ID="voteAv" runat="server"></asp:Label>
                    </p>
                </li>

                <li class="list-group-item">
                    <p class="card-text">
                    <asp:Label class="fw-semibold" ID="lblVote" runat="server">Votes: </asp:Label>
                    <asp:Label ID="vote" runat="server"></asp:Label>
                    </p>
                </li>

                <li class="list-group-item">
                    <p class="card-text">
                    <asp:Label class="fw-semibold" ID="Label1" runat="server"> Video: </asp:Label>
                    <asp:Label ID="youtube" runat="server"></asp:Label>
                    </p>
                </li>

                <li class="list-group-item">
                    <p class="card-text">
                        <small class="text-muted">
                            <asp:Label ID="date" runat="server"></asp:Label>
                        </small>
                    </p>
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
    <div class ="text-bg-success bg-gradient">
        <!-- Footer -->
        <footer class="page-footer font-small blue">

          <!-- Copyright -->
          <div class="footer-copyright text-center py-3">© 2022 Copyright: haugustin3
          </div>
          <!-- Copyright -->

        </footer>
        <!-- Footer -->
    </div>
</html>
