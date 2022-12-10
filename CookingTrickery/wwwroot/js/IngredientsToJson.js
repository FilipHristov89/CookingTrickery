$(document).ready(function () {
    document.getElementById('CreateRecipetBtn').addEventListener('click', function () {
        //event.preventDefault();

        var container = document.getElementById('ingrContainer');
        var children = container.getElementsByClassName('ingredientsDiv');
        console.log(children)
        var data = new Object();
        for (var ingr of children) {

            var ingreds = ingr.getElementsByTagName('div');
            var quantity = Number(ingreds[0].innerText);
            var measurement = ingreds[1].id;
            var ingredient = ingreds[2].id;

            data.quantity = JSON.stringify(quantity);
            data.measurement = JSON.stringify(measurement);
            data.ingredient = JSON.stringify(ingredient);
        }
        console.log(data);
        $.ajax(
            {
                type: "POST",
                url: "/Recipe/GetRecipeIngredients",
                data: JSON.stringify(data),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function () {
                    console.log('Data sended')
                },
                failure: function () {
                    console.log('failed')
                },
                Error: console.log(Error.name)
            }
        )
    })
})