$(document).ready(function () {
    document.getElementById('CreateRecipetBtn').addEventListener('click', function () {
        //event.preventDefault();

        var container = document.getElementById('ingrContainer');
        var children = container.getElementsByClassName('ingredientsDiv');
        console.log(children)
        var ingredients = {};
        var data = [];
        for (var ingr of children) {

            var ingreds = ingr.getElementsByTagName('div');
            var quantity = Number(ingreds[0].innerText);
            var measurement = ingreds[1].id;
            var ingredient = ingreds[2].id;

            ingredients.quantity = JSON.stringify(quantity);
            ingredients.measurement = JSON.stringify(measurement);
            ingredients.ingredient = JSON.stringify(ingredient);

            data.push(ingredients)
        }
        SendData(data);
    })
    function SendData(data)
    {
        $.ajax(
            {
                type: "POST",
                contentType: "application/json; charset=utf-8",
                url: "https://localhost:7295/Recipe/CreateRecipe",
                data: JSON.stringify(data),
                dataType: "json",
                success: function () {
                    console.log('Data sended')
                }
            }
        )
    }
})