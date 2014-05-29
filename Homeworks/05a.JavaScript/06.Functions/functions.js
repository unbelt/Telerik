/* exported onEnter */
function onEnter(id) {
	'use strict';

    if (window.event.keyCode == 13) {
        document.getElementById(id).click();
    }
}

// 1. Write a function that returns the last digit of given integer as an English word.
//    	Examples: 512 -> "two", 1024 -> "four", 12309 -> "nine"
function numToWord () {
	'use strict';

	var input = parseInt(document.getElementById('tw-input').value % 10);
	var numbersAsWord  = ['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine' ];
	document.getElementById('tw-output').innerHTML = numbersAsWord[input];
}


// 2. Write a function that reverses the digits of given decimal number.
//    	Example: 256 -> 652
function reverseDigits () {
	'use strict';

	document.getElementById('rd-output').innerHTML = document.getElementById('rd-input').value.split('').reverse().join('');
}


// 3. Write a function that finds all the occurrences of word in a text
//    	- The search can case sensitive or case insensitive
function countWords () {
	'use strict';

	var input = document.getElementById('cw-input').value.split(/[\s,.!?]+/);
	var searchFor = document.getElementById('cw-search').value;
	var count = 0;

	if (document.getElementById('cw-sensitive').checked) {
		input.forEach(function(word) {
			if (word == searchFor && searchFor != ' ' && searchFor !== '') {
				count++;
			}
		});
	}
	else {
		input.forEach(function(word) {
			if (word.toLowerCase() === searchFor.toLowerCase() && searchFor != ' ' && searchFor !== '') {
				count++;
			}
		});
	}

	var output = count === 0 ? 'Word not found!' : searchFor + ' - ' + count;
	document.getElementById('cw-output').innerHTML = output;
}


// 4. Write a function to count the number of divs (spans) on the web page
function countDivs () {
	'use strict';

	// I don't use div's
	document.getElementById('cd-output').innerHTML = '&lt;span&gt; - ' + document.getElementsByTagName('span').length;
}


// 5. Write a function that counts how many times given number appears in given array.
function cuntNumber () {
	'use strict';

	var input = document.getElementById('cn-input').value.split(/[\s,]+/);
	var searchFor = parseInt(document.getElementById('cn-search').value);
	var count = 0;

	switch (arguments.length) {
		case 2: input = arguments[0];
			document.getElementById('cn-input').value = arguments[0];
			searchFor = arguments[1];
			document.getElementById('cn-search').value = arguments[1]; break;
	}

	input.forEach(function(number) {
		if (number == searchFor) {
			count++;
		}
	});

	document.getElementById('cn-output').innerHTML = count === 0 ? 'Number not found!' : searchFor + ': ' + count + ' times.';
}

// 5a. Write a test function to check if the function is working correctly.
function cuntNumberTest () {
	'use strict';

	var array = [2, 3, 5, 2, 3, 1, 2];
	cuntNumber(array, 2);
}


// 6. Write a function that checks if the element at given position in given array
//    of integers is bigger than its two neighbors (when such exist).
function checkForNumber () {
	'use strict';

	var input = document.getElementById('cf-input').value.split(/[\s,]+/);
	var searchFor = parseInt(document.getElementById('cf-search').value);
	var output = document.getElementById('cf-output');

	if (searchFor > input.length || searchFor < 0) {
		output.innerHTML = 'Out of range!';
		return;
	}

	if ((searchFor === 0 && input[searchFor] > input[searchFor + 1]) ||
		(searchFor == input.length - 1 && input[searchFor] > input[searchFor - 1])) {
		output.innerHTML = true;
		return;
	}

	if (input[searchFor] > input[searchFor + 1] && input[searchFor] > input[searchFor - 1]) {
		output.innerHTML = true;
	}
	else {
		output.innerHTML = false;
	}
}


// 7. Write a function that returns the index of the first element in array
//    that is bigger than its neighbors, or -1, if there’s no such element.
function getElement () {
	'use strict';
	// I suppose that 'bigger' means with bigger length

	var input = document.getElementById('ge-input').value.split(/[\s,.!?]+/);
	var output = document.getElementById('ge-output');

	if (input[0] === '') {
		output.innerHTML = -1;
		return;
	}

	if (input[0].length > input[1].length) {
		output.innerHTML = input[0];
		return;
	}

	for (var i = 1; i < input.length - 1; i++) {

		if (input[i].length > input[i + 1].length && input[i].length > input[i - 1].length) {
			output.innerHTML = input[i];
			return;
		}
	}

	if (input[input.length - 1].length > input[input.length - 2].length) {
		output.innerHTML = input[0];
		return;
	}

	output.innerHTML = -1;
}