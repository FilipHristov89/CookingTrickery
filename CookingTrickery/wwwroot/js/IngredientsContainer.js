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
        /*var ingrValidSpan = document.createElement('span');*/

        var ingredientText = ingredient.options[ingredient.selectedIndex].text;
        var quantityValue = quantity.value.trim();
        var measurementText = measurement.options[measurement.selectedIndex].text;

        deleteButton.innerText = 'X';

        deleteButton.addEventListener('click', function () {
            event.preventDefault();

            container.removeChild(ingredientContainer);
        });

        ingredientDiv.textContent = ingredientText;
        quantityDiv.textContent = quantityValue;
        measurementDiv.textContent = measurementText;

        ingredientDiv.id = ingredient.value;
        measurementDiv.id = measurement.value;
        ingredientContainer.className = 'ingredientsDiv';

        //ingredientDiv.setAttribute('asp-for', '@Model.Test');
        //ingrValidSpan.setAttribute('asp-validation-for', 'Test');

        ingredientContainer.append(quantityDiv);
        ingredientContainer.append(measurementDiv);
        ingredientContainer.append(ingredientDiv);
        //ingredientContainer.append(ingrValidSpan);
        ingredientContainer.append(deleteButton);
        
        container.appendChild(ingredientContainer);

    })
})



