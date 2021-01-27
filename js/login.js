function loginPage(page) {
    $.ajax({
        type: "POST",
        url: "view/login/" + page + ".php"
    }).done(function(data) {
        $("#login_content").html(data);

    });
}
loginPage("login");


$("#cliente").click(function() {
    $("#nav_login ul li").each(function(index) {
        $(this).removeClass("active");
    });
    $(this).addClass("active");

    if ($("#n_carta").length == 1) {
        $("#n_carta").remove();
    }

    if ($("#nif").length == 1) {
        $("#nif").remove();
    }

});

$("#empresa").click(function() {
    $("#nav_login ul li").each(function(index) {
        $(this).removeClass("active");
    });
    $(this).addClass("active");

    if ($("#n_carta").length == 1) {
        $("#n_carta").remove();
    }

    if ($("#nif").length == 0) {
        input = `
                <div id="nif" class="mb-3">
                    <label for="rua" class="form-label">NIF</label>
                    <input type="text" class="form-control col-10" placeholder="Insira aqui a sua rua" id="rua">
                </div>`;
        $("#form_register").append(input);
    }

});

$("#condutor").click(function() {
    $("#nav_login ul li").each(function(index) {
        $(this).removeClass("active");
    });
    $(this).addClass("active");

    if ($("#nif").length == 1) {
        $("#nif").remove();
    }

    if ($("#n_carta").length == 0) {
        input = `
                <div id="n_carta" class="mb-3">
                    <label for="rua" class="form-label">Nº da Carta</label>
                    <input type="text" class="form-control col-10" placeholder="Insira aqui a sua rua" id="rua">
                </div>`;
        $("#form_register").append(input);
    }

});

//login_content