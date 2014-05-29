function onEnter(id) {
	'use strict';

    if (window.event.keyCode == 13) {
        document.getElementById(id).click();
    }
}

// 1. Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//    Print the obtained array on the console.
function multiplyArray () {
	'use strict';

	var intArray = [];

	for (var i = 0; i < 20; i++) {
		intArray[i] = i * 5;
	}

	//document.getElementById('ma-output').innerHTML = intArray.join();
	return intArray;
}

console.log(multiplyArray());


// 2. Write a script that compares two char arrays lexicographically (letter by letter).
function compareChars () {
	'use strict';

	var firstArray = document.getElementById('cc-first').value.split(/[\s,]+/);
	var secondArray = document.getElementById('cc-second').value.split(/[\s,]+/);
	var output = [];
	var count = firstArray.length > secondArray.length ? firstArray.length : secondArray.length;

	for (var i = 0; i < count; i++) {
		if (firstArray[i] !== undefined) {
			firstArray[i].trim();
		}
		if (secondArray[i] !== undefined) {
			secondArray[i].trim();
		}

		if (firstArray[i] == secondArray[i]) {
			output[i] = firstArray[i] + ' == ' + secondArray[i];
		}
		else {
			output[i] = firstArray[i] + ' != ' + secondArray[i];
		}
	}
	
	document.getElementById('cc-output').innerHTML = output.join('<br>');
}


// 3. Write a script that finds the maximal sequence of equal elements in an array.
//		Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} -> {2, 2, 2}.
function maxSequence() {
	'use strict';

	var input = document.getElementById('ms-input').value.split(/[\s,]+/);
	var len = 1;
	var bestLen = 0;
	var bestEnd = 0;

	for (var i = 0; i < input.length - 1; i++) {

		if (input[i] == input[i + 1]) {
			len++;
		}
		else {
			len = 1;
		}

		if (len >= bestLen) {
			bestLen = len;
			bestEnd = input[i];
		}
	}

	var output = new Array(bestLen + 1).join(bestEnd + ',');
	document.getElementById('ms-output').innerHTML = '{' + output.slice(0, output.length - 1)  + '}';
}


// 4. Write a script that finds the maximal increasing sequence in an array.
//    	Example: {3, 2, 3, 4, 2, 2, 4} -> {2, 3, 4}.
function maxIncSequence () {
	'use strict';

	var input = document.getElementById('is-input').value.split(/[\s,]+/);
	var len = 1;
	var bestLen = 0;
	var bestEnd = 0;
	var index = 0;
	var output = [];

	for (var i = 0; i < input.length - 1; i++) {

		if (Number(input[i]) < Number(input[i + 1])) {
			len++;
		}
		else {
			len = 1;
		}

		if (len > bestLen) {
			bestLen = len;
			bestEnd = i;
		}
	}

	for (i = bestEnd - bestLen + 1; i <= bestEnd; i++) {

		output[index] = input[i + 1];
		index++;
	}

	document.getElementById('is-output').innerHTML = '{' + output.join() + '}';
}


// 5. Sorting an array means to arrange its elements in increasing order.
//    Write a script to sort an array. Use the "selection sort" algorithm:
//    Find the smallest element, move it at the first position,
//    find the smallest from the rest, move it at the second position, etc.
//    	Hint: Use a second array
function selectionSort () {
	'use strict';

	var input = document.getElementById('ss-input').value.split(/[\s,]+/);

	var temp = 0;
	var min = 0;

	for (var i = 0; i < input.length - 1; i++) {

		min = i;

		for (var j = i + 1; j < input.length; j++) {

			if (input[j] < input[min]) {
				min = j;
			}
		}

		temp = input[min];
		input[min] = input[i];
		input[i] = temp;
	}

	document.getElementById('ss-output').innerHTML = input.join();
}


// 6. Write a program that finds the most frequent number in an array.
//    	Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} -> 4 (5 times)
function mostFrequent () {
	'use strict';

	var store = document.getElementById('mf-input').value.split(/[\s,]+/);
	var frequency = {};
	var max = 0;  
	var result; 
	var output;

	for(var v in store) {

		frequency[store[v]] = (frequency[store[v]] || 0) + 1;

		if (frequency[store[v]] > max) { 

			max = frequency[store[v]];
			result = store[v];
		}
	}

	output = max == 1 ? result + ' (' + Number(max) + ' time)' : result + ' (' + Number(max) + ' times)';
	document.getElementById('mf-output').innerHTML = output;
}

// 7. Write a program that finds the index of given element in a sorted array of integers
//    by using the binary search algorithm (find it in Wikipedia).
function binarySearch () {
	'use strict';

	var input = document.getElementById('bs-input').value.split(/[\s,]+/).sort();
	var searchFor = document.getElementById('bs-search').value;

	var min = 0;
	var max = input.length - 1;
	var index = 0;

	while (min <= max) {

		var mid = (min + max) / 2 | 0;
		var currMid = input[mid];

		if (currMid == searchFor) {
			index = mid;
			document.getElementById('bs-output').innerHTML = index;
			return;
		}
		else if (currMid < searchFor) {
			min = mid + 1;
		}
		else {
			max = mid - 1;
		}
	}

	document.getElementById('bs-output').innerHTML = 'Not found!';
}