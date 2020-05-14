$(document).ready(function () {

});

function pressEnterIfNeeded(event) {
    // Number 13 is the "Enter" key on the keyboard
    if (event.keyCode === 13) {
        // Cancel the default action, if needed
        event.preventDefault();
        // Trigger the button element with a click
        document.getElementById("searchBtn").click();
    }
}

function toggle() {
    let toggleBtn = event.currentTarget;
    $(toggleBtn).toggleClass("rotated");
}