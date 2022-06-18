let popup = document.getElementById('userMenuBlock'),
    popupToggle = document.getElementById('userMenuButtonHeader');
popupToggle.onclick = function () {
    if (popup.style.display == "none") {
        popup.style.display = "block";
    }
    else {
        popup.style.display = "none";
    }
}