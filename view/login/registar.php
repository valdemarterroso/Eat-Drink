<form class="mt-2">
    <div id="form_register" class="row col-12">
        <div class="col-6">
            <!-- Nome -->
            <div class="mb-3">
                <label for="nome" class="form-label">Nome</label>
                <input type="text" class="form-control col-10" placeholder="Insira aqui o seu nome" id="nome">
            </div>
            <!-- Email -->
            <div class="mb-3">
                <label for="email" class="form-label">Email</label>
                <input type="email" class="form-control col-10" placeholder="Insira aqui o seu email" id="email"
                    aria-describedby="emailHelp">
            </div>
            <!-- Password -->
            <div class="mb-3">
                <label for="password" class="form-label">Password</label>
                <input type="password" class="form-control col-10" placeholder="Insira aqui a sua password"
                    id="password">
            </div>
            <!-- Telemovel -->
            <div class="mb-3">
                <label for="telemovel" class="form-label">Telemóvel</label>
                <input type="number" class="form-control col-10" placeholder="Insira aqui o seu telemóvel"
                    id="telemovel">
            </div>
            <!-- Nacionalidade -->
            <div class="mb-3">
                <label for="nacionalidade" class="form-label">Nacionalidade</label>
                <input type="text" class="form-control col-10" placeholder="Insira aqui a sua localidade"
                    id="nacionalidade">
            </div>
        </div>
        <div class="col-6">
            <!-- Rua -->
            <div class="mb-3">
                <label for="rua" class="form-label">Rua</label>
                <input type="text" class="form-control col-10" placeholder="Insira aqui a sua rua" id="rua">
            </div>
            <!-- Nº Porta -->
            <div class="mb-3">
                <label for="porta" class="form-label">Nº Porta</label>
                <input type="number" class="form-control col-10" placeholder="Insira aqui o nº da casa" id="porta">
            </div>
            <!-- Freguesia -->
            <div class="mb-3">
                <label for="freguesia" class="form-label">Freguesia</label>
                <input type="text" class="form-control col-10" placeholder="Insira aqui a sua freguesia" id="freguesia">
            </div>
            <!-- Cod Postal -->
            <div class="mb-3">
                <label for="cod_postal" class="form-label">Código Postal</label>
                <input type="string" class="form-control col-10" placeholder="Insira aqui o seu código postal"
                    id="cod_postal">
            </div>
            <!-- Localidade -->
            <div class="mb-3">
                <label for="localidade" class="form-label">Localidade</label>
                <input type="text" class="form-control col-10" placeholder="Insira aqui a sua localidade"
                    id="localidade">
            </div>
        </div>

    </div>
    <div class="mx-auto">
        <button type="submit" class="btn btn-primary btn-lg btn-block">Registar</button>
        <div class="mt-3">
            <p>Se já tens conta: <span id="login" class="span_click">Voltar atrás</span>!</p>
        </div>
    </div>
</form>

<script>
$("#login").click(function() {
    loginPage("login");
    $("#nav_login").attr("style", "display: none !important;").animate({
        opacity: 0
    }, 500);
})
</script>