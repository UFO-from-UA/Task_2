setTimeout(function () {
    $('div.navbar').ready(function (event) {
        CultureSelected();
    });
}, 200);

function CultureSelected() {
    //console.dir(getCookie("lang"));
    var elements = document.getElementsByClassName("localizationButtons");
    //console.dir(elements);
    if (getCookie("lang") === "ru") {
        //console.dir("ru");
        elements[1].classList.remove("selectedLang");
        elements[0].classList.add("selectedLang");
    }
    else {
        //console.dir("en");
        elements[0].classList.remove("selectedLang");
        elements[1].classList.add("selectedLang");
    }
}

function getCookie(name) {
    let matches = document.cookie.match(new RegExp(
        "(?:^|; )" + name.replace(/([\.$?*|{}\(\)\[\]\\\/\+^])/g, '\\$1') + "=([^;]*)"
    ));
    return matches ? decodeURIComponent(matches[1]) : undefined;
}