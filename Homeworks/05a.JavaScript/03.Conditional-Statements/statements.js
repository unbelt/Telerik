// 1. Write an if statement that examines two integer variables
//    and exchanges their values if the first one is greater than the second one.
function exchangeValues () {
	'use strict';
	var inputOne = document.getElementById('ex-input-one').value;
	var inputTwo = document.getElementById('ex-input-two').value;
	var temp;

	if (Number(inputOne) > Number(inputTwo)) {
		temp = inputOne;
		inputOne = inputTwo;
		inputTwo = temp;
	}

	document.getElementById('ex-output').innerHTML = inputOne + '; ' + inputTwo;
}


// 2. Write a script that shows the sign (+ or -) of the product of 
//    three real numbers without calculating it. Use a sequence of if statements.
function showSign () {
	'use strict';
	var input = document.getElementById('ss-input').value.split(',');
	var output = document.getElementById('ss-output');
	var counter = 0;

	for (var i = 0; i < input.length; i++) {

		if (Number(input[i]) === 0) {
			output.innerHTML = 'zero (0)';
			return;
		}

		if (Number(input[i]) < 0) {
			counter++;
		}
	}

	if (Number(counter) !== input.length && Number(counter) % 2 === 0) {
		output.innerHTML = 'Plus (+)';
	}
	else {
		output.innerHTML = 'Minus (-)';
	}
}


// 3. Write a script that finds the biggest of three integers using nested if statements.
function biggestInt () {
	'use strict';
	var input = document.getElementById('bi-input').value.split(',');
	var output = document.getElementById('bi-output');
	
	if (Number(input[0]) > Number(input[1])) {

		if (Number(input[0]) > Number(input[2])) {
			output.innerHTML = input[0];
		}
		else {
			output.innerHTML = input[2];
		}
	}
	else if (Number(input[1]) > Number(input[2])) {
		output.innerHTML = input[1];
	}
	else {
		output.innerHTML = input[2];
	}
}


// 4. Sort 3 real values in descending order using nested if statements.
function sortValues () {
	'use strict';
	var input = document.getElementById('sv-input').value.split(',');
	var output = document.getElementById('sv-output');

	if (Number(input[0]) > Number(input[1]) && Number(input[0]) > Number(input[2])) {

		if (Number(input[1]) > Number(input[2])) {
			output.innerHTML = input[0] + '; ' + input[1] + '; ' + input[2];
		}
		else {
			output.innerHTML = input[0] + '; ' + input[2] + '; ' + input[1];
		}
	}
	else if (Number(input[1]) > Number(input[0]) && Number(input[1]) > Number(input[2])) {

		if (Number(input[0]) > Number(input[2])) {
			output.innerHTML = input[1] + '; ' + input[0] + '; ' + input[2];
		}
		else {
			output.innerHTML = input[1] + '; ' + input[2] + '; ' + input[0];
		}
	}
	else if (Number(input[2]) > Number(input[0]) && Number(input[2]) > Number(input[1])) {

		if (Number(input[0]) > Number(input[1])) {
			output.innerHTML = input[2] + '; ' + input[0] + '; ' + input[1];
		}
		else {
			output.innerHTML = input[2] + '; ' + input[1] + '; ' + input[0];
		}
	}
	else {
		output.innerHTML = input[0] + ' = ' + input[1] + ' = ' + input[2];
	}
}


// 5. Write script that asks for a digit and depending on the input
//    shows the name of that digit (in English) using a switch statement.
function digitName () {
	'use strict';
	var input = document.getElementById('dn-input').value;
	var output = document.getElementById('dn-output');

	switch(Number(input)) {
		case 0: output.innerHTML = 'zero'; break;
		case 1: output.innerHTML = 'one'; break;
		case 2: output.innerHTML = 'two'; break;
		case 3: output.innerHTML = 'three'; break;
		case 4: output.innerHTML = 'four'; break;
		case 5: output.innerHTML = 'five'; break;
		case 6: output.innerHTML = 'six'; break;
		case 7: output.innerHTML = 'seven'; break;
		case 8: output.innerHTML = 'eight'; break;
		case 9: output.innerHTML = 'nine'; break;
		default: alert('Wrong input!');
	}
}


// 6. Write a script that enters the coefficients a, b and c of a quadratic equation
//    a*x2 + b*x + c = 0 and calculates and prints its real roots.
//    Note that quadratic equations may have 0, 1 or 2 real roots.
// a = 3; b = 33; c = 12 -> -0.37652461702020074; -10.6234753829798
// Place to check: http://www.math.com/students/calculators/source/quadratic.htm
function calcRealRoot () {
	'use strict';
	var a = document.getElementById('rr-input-a').value;
	var b = document.getElementById('rr-input-b').value;
	var c = document.getElementById('rr-input-c').value;
	var output = document.getElementById('rr-output');

	var d = (b * b) - (4 * a * c);

	if (d < 0) {
		output.innerHTML = 'No real roots';
	}
	else if (d === 0) {
		d = Math.sqrt(d);
		output.innerHTML = (Number(-b) + Number(d)) / (2 * a);
	}
	else {
		d = Math.sqrt(d);
		output.innerHTML = (Number(-b) + Number(d)) / (2 * a) + '; ' + 
		(Number(-b) + Number(-d)) / (2 * a);
	}
}


// 7. Write a script that finds the greatest of given 5 variables.
function greatestInt () {
	'use strict';
	var input = document.getElementById('gi-input').value.split(',');
	document.getElementById('gi-output').innerHTML = Math.max.apply(Math, input);
}


// 8. Write a script that converts a number in the range [0...999]
//	  to a text corresponding to its English pronunciation. Examples:
//		0 -> 'Zero'
//		273 -> 'Two hundred seventy three'
//		400 -> 'Four hundred'
//		501 -> 'Five hundred and one'
//		711 -> 'Seven hundred and eleven'

function intToWord () {
	'use strict';
	
	var number = document.getElementById('tw-input').value;
	var word = '';
	var digits = [ 'zero' ,'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight','nine' ];
	var special = [ 'ten', 'eleven', 'twelve', 'thirdtheen', 'fourthen', 'fiftheen', 'sixtheen', 'seventheen', 'eightheen', 'ninetheen' ];
	var dec = [ '', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety' ];

	if (number >= 0 && number < 1000) {
		var digit = number % 10;
		var tens = parseInt(number / 10) % 10;
		var hundred = parseInt(number / 100) % 10;

		if (hundred !== 0) {
			word += digits[hundred] + ' hundred ';

			if (tens !== 0 && tens !== 1 && number >= 20) {
				word += 'and ' + dec[tens] + ' ';

				if (digit !== 0) {
					word += digits[digit] + ' ';
				}
			}
			else if (tens === 1) {
				word += 'and ' + special[digit];
			}
			else {
				if (digit !== 0) {
					word += 'and ' + digits[digit] + ' ';
				}
			}
		}
		else {
			if (tens !== 0 && tens !== 1 && number >= 20) {
				word += dec[tens] + ' ';

				if (digit !== 0) {
					word += digits[digit] + ' ';
				} 

			}
			else if (tens === 1) {
				word += special[digit];
			}
			else {
				word += digits[digit] + ' ';
			}
		}
	}
	else {
		alert('Out of range!');
	}

	document.getElementById('tw-output').innerHTML = word.charAt(0).toUpperCase() + word.slice(1);
}