$(document).ready(function () {
    document.getElementById('CreateRecipetBtn').addEventListener('click', function () {
        //event.preventDefault();

        var container = document.getElementById('ingrContainer');
        var children = container.getElementsByClassName('ingredientsDiv');
        console.log(children)
        var data = new Array();
        for (var ingr of children) {
            var ingrObj = {};
            var ingreds = ingr.getElementsByTagName('div');
            var quantity = Number(ingreds[0].innerText);
            var measurement = ingreds[1].id;
            var ingredient = ingreds[2].id;

            ingrObj.quantity = JSON.stringify(quantity);
            ingrObj.measurement = JSON.stringify(measurement);
            ingrObj.ingredient = JSON.stringify(ingredient);

            data.push(ingrObj)
        }
        console.log(data);
        $.post('Recipe/GetRecipeIngredients', data, function(){
            console.log('sended')
        }); 
    })
})