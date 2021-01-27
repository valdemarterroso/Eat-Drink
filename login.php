<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Eat & Drink</title>
    <link rel="shortcut icon" href="img/logo_fav.png" type="image/png">
    <link href="css/components/material-components-web.min.css" rel="stylesheet">
    <link rel="stylesheet"
        href="https://fonts.googleapis.com/css?family=Roboto:300,400,500|Material+Icons|Material+Icons+Outlined|Material+Icons+Two+Tone|Material+Icons+Round|Material+Icons+Sharp">
    <link rel="stylesheet" href="css/components/bootstrap.min.css">
    <link rel="stylesheet" href="css/style.min.css">
    <link rel="stylesheet" href="css/login.min.css">
</head>

<body>
    <div id="content_login" class="row col-12">
        <div class="login_card col-lg-6 col-md-8 col-sm-10 col-12">
            <div id="nav_login">
                <ul>
                    <li id="cliente" data-selector="Cliente" class="active">
                        <div class="icon material-icons-round">person</div>
                    </li>
                    <li id="empresa" data-selector="Empresa">
                        <div class="icon material-icons-round">restaurant</div>
                    </li>
                    <li id="condutor" data-selector="Condutor">
                        <div class="icon material-icons-round">moped</div>
                    </li>
                </ul>
            </div>
            <img src="img/logo.png" alt="Eat & Drink">
            <div id="login_content"></div>
        </div>
    </div>

    <script defer src="js/components/all.js"></script>
    <script src="js/components/jquery-3.2.1.slim.min.js"></script>
    <script src="js/components/popper.min.js"></script>
    <script src="js/components/bootstrap.min.js"></script>
    <script src="js/components/material-components-web.min.js"></script>
    <script src="js/components/jquery-3.5.1.js"></script>
    <script src="js/login.js"></script>
</body>

</html>