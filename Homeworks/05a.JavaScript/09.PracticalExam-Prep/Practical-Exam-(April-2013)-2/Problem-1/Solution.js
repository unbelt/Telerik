function Solve(input) {
	'use strict';

	var numbers = input.slice(1).map(Number);
	var bestSum = numbers[0];

	for (var i = 0; i < numbers.length; i++) {
		var currentSum = 0;

		for (var j = i; j < numbers.length; j++) {
			currentSum += numbers[j];
			
			if (currentSum > bestSum) {
				bestSum = currentSum;
			}
		}
	}

	return bestSum;
}

//console.log(Solve(['8', '1', '6', '-9', '4', '4', '-2', '10', '-1']));