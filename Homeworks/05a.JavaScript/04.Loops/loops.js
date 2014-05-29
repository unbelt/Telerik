function onEnter(id) {
	'use strict';

    if (window.event.keyCode == 13) {
        document.getElementById(id).click();
    }
}

// 1. Write a script that prints all the numbers from 1 to N
function fromTo () {
	'use strict';

	var input = parseInt(document.getElementById('ft-input').value);
	var output = [];

	for (var i = 0; i < input; i++) {
		output[i] = i + 1;
	}

	document.getElementById('ft-output').innerHTML = output.join();
}


// 2. Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
function notDivisible () {
	'use strict';

	var input = parseInt(document.getElementById('nd-input').value);
	var output = [];
	var index = 0;

	for (var i = 0; i <= input; i++) {

		if (i % 35 !== 0) {
			output[index] = i;
			index++;
		}
	}

	document.getElementById('nd-output').innerHTML = output.join();
}


// 3. Write a script that finds the max and min number from a sequence of numbers
function minAndMax () {
	'use strict';

	var input = document.getElementById('mm-input').value.split(',');
	var max = Math.max.apply(Math, input);
	var min = Math.min.apply(Math, input);

	document.getElementById('mm-output').innerHTML = 'Min: ' + min + '; ' + 'Max: ' + max;

}


// 4. Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects
function propertyInfo() {
	'use strict';

	(function() { document.getElementById('pi-output').innerHTML = ''; })();
	var selProp = document.getElementById('properties');
	
	var prop = [ document, window, navigator ];

	for (var i = 0; i < selProp.options.length; i++) {

		if (selProp.options[i].selected) {

			getPropInfo(prop[i]);
		}
	}
}

function getPropInfo () {
	'use strict';

	var properties = [];

	for (var i = 0; i < arguments.length; i++) {

		properties[i] = 'z';
		properties[i + 1] = 'a';

		for (var prop in arguments[i]) {

			if (prop < properties[i]) {
				properties[i] = prop;
			}
			if (prop > properties[i + 1]) {
				properties[i + 1] = prop;
			}
		}

		document.getElementById('pi-output').innerHTML += arguments[i] + ' Smallest: ' + properties[i] + '<br>' +
											 			  arguments[i] + ' Largest: ' + properties[i + 1] + '<br>';
	}
}