$(document).ready(function () {

	// общ брой редове
	var rowIdx = 0;

	// добавяне на ред
	$('#AddIngB').on('click', function () {
		event.preventDefault();
		//нов ред
		var newRow = "<tr id='row" + rowIdx + "'>";
		//съставка
		newRow += "<td id='ingredient" + rowIdx + "'>";
		newRow += $("#ingredients").val();
		newRow += "</td>";
		//количество
		newRow += "<td id='amount" + rowIdx + "'>";
		newRow += $("#quantity").val();
		newRow += "</td>";
		//мерна единица
		newRow += "<td id='unit" + rowIdx + "'>";
		newRow += $("#measurements").val();
		newRow += "</td>";
		//край на реда
		newRow += "</tr>";
		//вкарвай в ХТМЛ-а
		$('#tableList').append(newRow);
		//увеличаваме брояча с 1
		rowIdx++;
	});
});