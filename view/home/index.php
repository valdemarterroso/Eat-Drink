<div id="home">

</div>
<script>
function Page(page) {
    $.ajax({
        type: "POST",
        url: "view/home/" + page + ".php"
    }).done(function(data) {
        $("#home").html(data);

    });
}
Page("home")
</script>