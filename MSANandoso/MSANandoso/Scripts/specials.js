document.addEventListener("DOMContentLoaded", function () {
    console.log("DOM loaded and ready to go!");
    loadSpecials();
});

function loadSpecials() {
    SpecialModule.getSpecials(setupSpecialsList);
}

function setupSpecialsList(specialsList) {
    var specialGrid = document.getElementById("specialList");

    for (var i = 0; i < specialsList.length; i ++) {
        var rowdiv = document.createElement("div");
        rowdiv.setAttribute("class", "row");

        var div5Col = document.createElement("div");
        div5Col.setAttribute("class", "col-md-5");

        var image = document.createElement("img");
        image.class = "img-responsive";
        image.src = "http://placehold.it/400x300";
        div5Col.appendChild(image);


        var div7Col = document.createElement("div");
        div7Col.setAttribute("class", "col-md-7");

        var title = document.createElement("h3");
        title.innerHTML = specialsList[i].Title;
        div7Col.appendChild(title);

        var price = document.createElement("h4");
        price.innerHTML = "$" + specialsList[i].Price;
        div7Col.appendChild(price);

        var desc = document.createElement("p");
        desc.innerHTML = specialsList[i].Description;
        div7Col.appendChild(desc);

        var listbreak = document.createElement("hr");

        rowdiv.appendChild(div5Col);
        rowdiv.appendChild(div7Col);
        specialGrid.appendChild(rowdiv);
        specialGrid.appendChild(listbreak);
    }
}