function Solve(input) {
	'use strict';

	var numbers = input.map(Number).slice(1),
		count = 1;

	for (var i = 0; i < numbers.length; i++) {
		if (numbers[i] > numbers[i + 1]) {
			count++;
		}
	}

	return count;
}

console.log(Solve(['7', '1', '2', '-3', '4', '4', '0', '1']));
console.log(Solve(['6', '1', '3', '-5', '8', '7', '-6']));
console.log(Solve(['9', '1', '8', '8', '7', '6', '5', '7', '7', '6']));