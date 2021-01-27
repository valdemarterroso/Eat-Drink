<div class="row">
    <div id="info_restaurante" class="col-3">
        <img src="img/KFC.png" alt="KFC">
        <h2>KFC</h2>
        <div class="menu">
            <a id="sobre">Sobre</a>
            <a id="menus">Menu</a>
        </div>
    </div>
    <div class="page_info menu_section col-9" style="display: none;">
        <div class="row">
            <div class="col-11">
                <div class="card comida_card">
                    <img src="../../img/Comida.jpg" alt="">
                    <div class="comida_text">
                        <p>Chicken Wings</p>
                        <p>Asinhas de Frango empanadas</p>
                        <button class="btn-primary">Adicionar ao Carrinho</button>
                    </div>
                </div>
                <div class="card comida_card">
                    <img src="../../img/Comida.jpg" alt="">
                    <div class="comida_text">
                        <p>Chicken Wings</p>
                        <p>Asinhas de Frango empanadas</p>
                        <button class="btn-primary">Adicionar ao Carrinho</button>
                    </div>
                </div>
                <div class="card comida_card">
                    <img src="../../img/Comida.jpg" alt="">
                    <div class="comida_text">
                        <p>Chicken Wings</p>
                        <p>Asinhas de Frango empanadas</p>
                        <button class="btn-primary">Adicionar ao Carrinho</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="page_info sobre_section col-9">
        <div class="img_info">

        </div>
        <div class="informacao">
            <p>Kentucky Fried Chicken é uma rede de restaurantes de fast-food dos Estados Unidos da America, que explora
                a
                antiga receita de frango frito de Kentucky, criada pelo Coronel Harland Sanders, fundador do KFC, em
                1939,
                na cidade de Corbin, no estado do Kentucky, nos Estados Unidos. Actualmente, tem a sua sede em
                Louisville,
                no estado do Kentucky e pertence à empresa Yum! Brands, da PepsiCo. </p>
            <span>Rua: Avenida Francelos 83 </span><br>
            <span>Cidade: Guifões </span><br>
            <span>Codigo de Postal: 4460-115 </span><br>
            <span>Telemovel: 21 228 593 5001</span><br>
            <span>Email: zsybb6o35x@temporary-mail.net</span>
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