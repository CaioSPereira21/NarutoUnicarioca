//// search-box open close js code
//let navbar = document.querySelector(".navbar");

//// sidebar open close js code
//let navLinks = document.querySelector(".nav-links");
//let menuOpenBtn = document.querySelector(".navbar .bx-menu");
//let menuCloseBtn = document.querySelector(".nav-links .bx-x");
//menuOpenBtn.onclick = function () {
//    navLinks.style.left = "0";
//}
//menuCloseBtn.onclick = function () {
//    navLinks.style.left = "-100%";
//}


//// sidebar submenu open close js code
//let htmlcssArrow = document.querySelector(".htmlcss-arrow");
//htmlcssArrow.onclick = function () {
//    navLinks.classList.toggle("show1");
//}
//let moreArrow = document.querySelector(".more-arrow");
//moreArrow.onclick = function () {
//    navLinks.classList.toggle("show2");
//}
//let jsArrow = document.querySelector(".js-arrow");
//jsArrow.onclick = function () {
//    navLinks.classList.toggle("show3");
//}
$(document).ready(function () {
    // Adicione um evento de clique para o elemento com o ID "akatsuki-card"
    $("#akatsuki-card").click(function () {
        var url = $(this).data("url");
        window.location.href = url;
    });

    // Adicione um evento de clique para o elemento com o ID "bijuus-card"
    $("#bijuus-card").click(function () {
        var url = $(this).data("url");
        window.location.href = url;
    });
});