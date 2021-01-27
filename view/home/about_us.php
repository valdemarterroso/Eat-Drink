<div class="row">
    <div id="info_restaurante" class="col-3">
        <img src="img/logo.png" alt="KFC">
        <h2>Eat & Drink</h2>
    </div>
    <div class="page_info sobre_section col-9">
        <div class="img_info" style="background-image: url(../../../../img/restaurante.jpg);">

        </div>
        <div class="informacao">
            <p>Eat & Drink é uma plataforma de entrega de refeições e alimentos online, está encontra-se em
                funcionamento em Portugal, mas futuramente pretendemos expandir para o resto do globo.</p>
            <p>O objetivo do serviço é fazer parceria com restaurantes locais em todo Portugal e permitir que os
                clientes encomendem comida usando um website tanto para computador ou smartphones.</p>
            <p>Na nossa aplicação vai existir um serviço de parte de motorista, onde esse vão puder retirar um pouco de
                comissão de entrega e são estes quais iram entregar as encomendas.</p>
            <p>Esta empresa surgiu devido a um projeto de que nos foi proposto no âmbito das disciplinas de Computação
                Distribuída e Desenvolvimento Colaborativo de Software, onde nas quais tratamos do que cada uma das
                disciplinas nos lesionou.</p>
            <p>Para mais informações contacte-nos via email: geral@eat-drink.com</p>
        </div>
    </div>
</div>

<script>
$("#menus").click(function() {
    $(".menu_section").attr("style", "display:block !important");
    $(".sobre_section").attr("style", "display:none !important");
})
$("#sobre").click(function() {
    $(".sobre_section").attr("style", "display:block !important");
    $(".menu_section").attr("style", "display:none !important");
})
</script>