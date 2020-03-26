function toggle(){
    let toggleBtn = event.target;
    console.log($.trim($(toggleBtn).text()));
    $(toggleBtn).text($.trim($(toggleBtn).text()) === "Less" ? "More" : "Less");
}