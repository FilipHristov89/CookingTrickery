/*Adding the chosen ingredients/quantity/measurement to the container*/
$(document).ready(function () {
    document.getElementById('AddIngr').addEventListener('click', function () {
        //console.log('hi');
        event.preventDefault();

        var container = document.getElementById('ingrContainer');
        var ingredient = document.getElementById('ingredients');
        var quantity = document.getElementById('quantity');
        var measurement = document.getElementById('measurement');

        var ingredientContainer = document.createElement('div');
        var ingredientDiv = document.createElement('div');
        var quantityDiv = document.createElement('div');
        var measurementDiv = document.createElement('div');
        var deleteButton = document.createElement('button')

        /*Taking values from selected forms*/
        var ingredientText = ingredient.options[ingredient.selectedIndex].text;
        var quantityValue = quantity.value.trim();
        var measurementText = measurement.options[measurement.selectedIndex].text;

        deleteButton.innerText = 'X';

        /*Deleting elements from the ingredinetContainer*/
        deleteButton.addEventListener('click', function () {
            event.preventDefault();

            container.removeChild(ingredientContainer);
        });

        /*Adding values to ingredient/quantity/measurement elements*/
        ingredientDiv.textContent = ingredientText;
        quantityDiv.textContent = quantityValue;
        measurementDiv.textContent = measurementText;

        /*Adding id's for ingredient/measurement elements*/
        ingredientDiv.id = ingredient.value;
        measurementDiv.id = measurement.value;
        ingredientContainer.className = 'ingredientsDiv';

        /*Appending elements to the container*/
        ingredientContainer.append(quantityDiv);
        ingredientContainer.append(measurementDiv);
        ingredientContainer.append(ingredientDiv);
        ingredientContainer.append(deleteButton);
        
        container.appendChild(ingredientContainer);

    })
})



