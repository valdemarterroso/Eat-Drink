<div id="navbar">
    <div class="row col-12">
        <div class="col-1">
        </div>
        <div class="col-2">
            <div id="flag">
                <img src="img/logo.png" alt="Eat & Drink">
            </div>
        </div>
        <div class="col-4">
        </div>
        <div class="col-5 menu">
            <p id="home_page"> Home</p>
            <p id="restaurante"> Restaurantes </p>
            <p id="about_us"> Sobre nós</p>
            <p id="conta"> Conta</p>
        </div>
    </div>
</div>

<script>
$("#home_page").click(function() {
    Page("home");
})
$("#restaurante").click(function() {
    Page("restaurante");
})
$("#about_us").click(function() {
    Page("about_us");
})
$("#conta_page").click(function() {
    Page("conta");
})
</script>