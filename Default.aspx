<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Movie.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

    <script type="text/javascript">
        window.onload = function () {
            window.location.replace("frmFilms.aspx");
        }
    </script>

<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center; margin-top: 100px;">
            <img src="images/loading-anim.gif" />
            <h2 class="text-center fw-semibold" style="color:forestgreen;">Loading</h2>
        </div>
    </form>
</body>
</html>
