/*Gathers the values from the container and sending it to controller as stringified JSON*/
$(document).ready(function () {
    document.getElementById('CreateRecipetBtn').addEventListener('click', function () {
        //event.preventDefault();

        /*Getting the container and values*/
        var container = document.getElementById('ingrContainer');
        var children = container.getElementsByClassName('ingredientsDiv');
        console.log(children)

        /*Adding the values to Array of Objects*/
        var data = new Array();
        for (var ingr of children) {
            var ingrObj = {};
            var ingreds = ingr.getElementsByTagName('div');
            var quantity = Number(ingreds[0].innerText);
            var measurement = ingreds[1].id;
            var ingredient = ingreds[2].id;

            ingrObj.quantity = quantity;
            ingrObj.measurement = measurement;
            ingrObj.ingredientId = ingredient;

            data.push(ingrObj)
        } 

        console.log(typeof (data));
        console.log(JSON.stringify(data));

        /*Getting the form and appending the data*/
        var ingrSend = document.getElementById('ingrSend');

        ingrSend.append(JSON.stringify(data));
    })
})