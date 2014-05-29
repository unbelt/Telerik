// 01. Write an expression that checks if given integer is odd or even.
function oddOrEven () {
	'use strict';
	var number = document.getElementById('oddOrEvenInput').value;

	document.getElementById('oddOrEvenOutput').innerHTML = number % 2 === 0 ? 'Even' : 'Odd';
}


// 02. Write a boolean expression that checks for given integer
//     if it can be divided (without remainder) by 7 and 5 in the same time.
function canBeDivided () {
	'use strict';
	var number = document.getElementById('canBeDividedInput').value;

	document.getElementById('canBeDividedOutput').innerHTML = number % 35 === 0;
}


// 03. Write an expression that calculates rectangle’s area by given width and height.
function calcRectArea () {
	'use strict';
	var width = document.getElementById('rectWidth').value;
	var height = document.getElementById('rectHeight').value;

	document.getElementById('rectArea').innerHTML = width * height;
}


// 04. Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732 -> true.
function checkThirdDigit () {
	'use strict';
	var input = document.getElementById('checkDigitInput').value;
	var numberTocheck = input.length - 3;

	// !notice: This perform implicit cast toString, but will work with ==
	//document.getElementById('checkDigitOutput').innerHTML = input[numberTocheck] == 7;

	// the right way
	document.getElementById('checkDigitOutput').innerHTML = Number(input[numberTocheck]) === 7;
}


// 05. Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
function checkBit () {
	'use strict';
	var input = document.getElementById('checkBitInput').value;
	var binary = Number(input).toString(2);
	var output = document.getElementById('checkBitOutput');

	output.innerHTML = (Number(binary[binary.length - 4]) === 0 ||
						binary[binary.length - 4] === undefined) ? 0 : 1;
}


// 06. Write an expression that checks if given print (x,  y) is within a circle K(O, 5).
function checkPoint () {
	'use strict';
	var pointX = document.getElementById('pointX').value;
	var pointY = document.getElementById('pointY').value;

	document.getElementById('checkPointOutput').innerHTML = Math.pow(pointX, 2) + Math.pow(pointY, 2) <= Math.pow(5, 2);
}


// 07. Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
function isPrime () {
	'use strict';
	var number = document.getElementById('isPrimeInput').value;
	var counter = 0;

	if (number > 100) {
		alert('Out of range!');
		return;
	}

	for (var i = 1; i <= number; i++) {

		if (number % i === 0) {
			counter++;
		}
	}

	document.getElementById('isPrimeOutput').innerHTML = counter == 2 ? 'is prime.' : 'is NOT prime.';
}


// 08. Write an expression that calculates trapezoid's area by given sides a and b and height h.
function calcTrapArea () {
	'use strict';
	var sideA = document.getElementById('sideA').value;
	var sideB = document.getElementById('sideB').value;
	var trapHeight = document.getElementById('trapHeight').value;

	// !notice: The numbers will concatenate without explicit cast to Number()
	document.getElementById('trapArea').innerHTML = ((Number(sideA) + Number(sideB)) / 2) * trapHeight;
}


// 09. Write an expression that checks for given point (x, y) if it is within the
//     circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).
function checkPointLocation () {
	'use strict';
	var pX = document.getElementById('pX').value;
	var pY = document.getElementById('pY').value;

	var isInCircle = Math.pow(pX - 1, 2) + Math.pow(pY - 1, 2) <= Math.pow(3, 2);
	var isOutOfRectangle = (pX > 4 || pX < -1) || (pY > 1 || pY < -1);

	document.getElementById('checkPointLocationOutput').innerHTML = isInCircle && isOutOfRectangle ? 'Yes.' : 'No.';
}