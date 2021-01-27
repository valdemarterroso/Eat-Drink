<form id="login_form" class="mt-2 col-6 mx-auto">
    <div class="mb-3">
        <label for="exampleInputEmail1" class="form-label">Email</label>
        <input type="email" class="form-control col-10" placeholder="Insira aqui o seu email" id="exampleInputEmail1"
            aria-describedby="emailHelp">

    </div>
    <div class="mb-3">
        <label for="exampleInputPassword1" class="form-label">Password</label>
        <input type="password" class="form-control col-10" placeholder="Insira aqui a sua Password"
            id="exampleInputPassword1">
    </div>
    <div class="mx-auto">
        <button type="submit" class="btn btn-primary btn-lg btn-block">Login</button>
        <div class="mt-3">
            <p>Se te queres registar: <span id="registar" class="span_click">Regista-te aqui</span>!</p>
        </div>
    </div>
</form>

<script>
$("#registar").click(function() {
    loginPage("registar");
    $("#nav_login").attr("style", "display: block !important;").animate({
        opacity: 1
    }, 1000);
})
$("#login_form").submit(function(e) {
    e.preventDefault();
    window.location = "index.php";
})
</script>