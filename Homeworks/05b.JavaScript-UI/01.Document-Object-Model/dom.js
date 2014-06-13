// Help functions
function onEnter(id) {
	'use strict';

	if (window.event.keyCode == 13) {
		document.getElementById(id).click();
	}
}

function clearOutput(id) {
	'use strict';

	document.getElementById(id).innerHTML = '';
}

/* 1. Write a script that selects all the div nodes that are directly inside other div elements
		Create a function using querySelectorAll()
		Create a function using getElementsByTagName()
*/
function getHeadings() {
	'use strict';

	var output = document.getElementById('gh-output');

	if (arguments[0]) {

		var queryHeadings = document.querySelectorAll('li > h3');

		for (var i = 0, len = queryHeadings.length; i < len; i++) {
			output.innerHTML += queryHeadings[i].innerHTML + '<br />';
		}

		return;
	}

	var listItems = document.getElementsByTagName('li'),
		currentItem = '';

	for (var i = 0, len = listItems.length; i < len; i++) {

		currentItem = listItems[i].getElementsByTagName('h3')[0];

		if (currentItem) {
			output.innerHTML += currentItem.innerHTML + '<br />';
		}
	}
}


// 2. Create a function that gets the value of <input type="text"> ands prints its value to the console
function getInputValue() {
	'use strict';

	document.getElementById('gi-output').innerHTML = document.getElementById('gi-input').value;
}


// 3. Crеate a function that gets the value of <input type="color"> and sets the background of the body to this value

function getInputColorValue() {
	'use strict';

	document.body.style.background = document.getElementById('gc-input').value;
}


// 4. *Write a script that shims querySelector and querySelectorAll in older browsers
function selectElements() {
	// TODO
}