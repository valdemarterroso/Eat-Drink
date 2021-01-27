"use strict";

function homePage(page) {
  $.ajax({
    type: "POST",
    url: "view/home/" + page + ".php"
  }).done(function (data) {
    $("#content_index").append(data);
  });
}

homePage("navbar");
homePage("index");