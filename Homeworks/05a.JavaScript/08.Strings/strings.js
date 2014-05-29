// 1. Write a JavaScript function reverses string and returns it Example: "sample" -> "elpmas".

var testingText = 'We are living in an yellow submarine. We don\'t have anything else.'; // Random text for tests

function reverse(value) {
	'use strict';
	return value.split('').reverse().join('');
}
// TEST
//console.log(reverse('sample'));


// 2. Write a JavaScript function to check if in a given expression the brackets are put correctly.
//		- Example of correct expression: ((a+b)/5-d).
// 		- Example of incorrect expression: )(a+b)).
function checkBracket (expression) {
	'use strict';

	var chars = expression.split('');
	var open = 0;

	for(var c in chars) {
		if (chars[c] == '(') {
			open++;
		}
		if (chars[c] == ')') {
			open--;
		}
		if (open < 0) {
			return false;
		}
	}

	if (open > 0) {
		return false;
	}

	return true;
}
// TEST
//console.log(checkBracket(")(a+b))"));

// 3. Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).
function findSubstring (text) {
	'use strict';

	var chars = text.split('');
	var count = 0;

	for (var i = 0; i < text.length - 1; i++) {
		if (chars[i].toLowerCase() == 'i' && chars[i + 1].toLowerCase() == 'n') {
			count++;
		}
	}

	return count;
}
// TEST
//console.log(findSubstring(testingText));


// 4. You are given a text. Write a function that changes the text in all regions:
//		<upcase>text</upcase> to uppercase.
//		<lowcase>text</lowcase> to lowercase
//		<mixcase>text</mixcase> to mix casing(random)
function changeCasing(match) {
	'use strict';

	var tag = match.split('>');
	var matches = match.replace(/<(.*?)>(.*?)<\/(.*?)>/g, '$2');

	switch(tag[0]) {
		case '<upcase': return matches.toUpperCase();
		case '<lowcase': return matches.toLowerCase();
		case '<mixcase': return mix(matches);
		default: return ''; // tag is not allowed
	}

	function mix(value) {

		var chars = value.split('');
		var result = '';
		var random = 0;

		for(var c in chars) {

			random = Math.floor((Math.random() * 2) + 1);

			if (random == 1) {
				result += chars[c].toLowerCase();
			}
			else {
				result += chars[c].toUpperCase();
			}
		}

		return result;
	}
}

function formatText(text) {
	'use strict';

	return text.replace(/<(.*?)>(.*?)<\/(.*?)>/g, changeCasing);
}
// TEST
//console.log(formatText('We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.'));


// 5. Write a function that replaces non breaking white-spaces in a text with &nbsp;
function replaceSpace (text) {
	'use strict';

	var chars = text.split('');

	for (var c in chars) {
		if (chars[c] == ' ')  {
			chars[c] = '&nbsp';
		}
	}

	return chars.join('');
}
// TEST
//console.log(replaceSpace(testingText));


// 6. Write a function that extracts the content of a html page given as text.
// 	  The function should return anything that is in a tag, without the tags
function parseHtml (html) {
	'use strict';

	return html.replace(/<(.*?)>/g, '');
}
// TEST
//console.log(parseHtml('<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>'));


// 7. Write a script that parses an URL address given in the format: [protocol]://[server]/[resource]
//    and extracts from it the [protocol], [server] and [resource] elements.
//    Return the elements in a JSON object. For example from the URL http://www.devbg.org/forum/index.php
function parseUrl (url) {
	'use strict';

	var portocol = url.split(':')[0];
	var server = url.split('/')[2];
	var resurce = url.split(server)[1];

	return { protocol: portocol, server: server, resource: resurce };
}
// TEST
//console.log(parseUrl('http://www.devbg.org/forum/index.php'));


// 8. Write a JavaScript function that replaces in a HTML document given as string
//    all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
function parseHtmlTags (html) {
	'use strict';

	return html.replace(/(<a href=)/g, '[URL=').replace(/(<\/a>)/g, '[/URL]').replace(/">/g, ']');
}
// TEST
//console.log(parseHtmlTags('<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>'));


// 9. Write a function for extracting all email addresses from given text.
//    All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
//    Return the emails as array of strings.
function getEmail (text) {
	'use strict';

	return text.match(/\S+@\S+\.\S+/g);
}
// TEST
//console.log(getEmail('My email address was pesho@abv.bg, but I try to change to worstmailever@abv, because of the spam. Now I use bestmail@gmail.com'));


// 10. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".
function getPalindromes (text) {
	'use strict';

	var words = text.split(/[\s,.!?]+/);
	var currentWord;
	var result = [];
	var index = 0;

	for (var i in words) {
		
		currentWord = words[i].split('').reverse().join('').toLowerCase();

		if (words[i].toLowerCase() == currentWord && currentWord.length > 2) {
			
			result[index] = words[i];
			index++;
		}
	}

	return result.join();
}
// TEST
//console.log(getPalindromes('My favorite group is ABBA, coz I have an eye for details.'));


// 11. Write a function that formats a string using placeholders.
//     		Example: var str = stringFormat("Hello {0}!","Peter");
//	   The function should work with up to 30 placeholders and all types.
function stringFormat (text) {
	'use strict';
	
	var words = text.split(/(\{[0-30]\})/g);
	var index = 1;

	for (var i = 1; i < words.length; i+=2) {
		words[i] = arguments[index];
		index++;
	}

	return words.join('');
}
// TEST
//console.log(stringFormat('Hello {0}! Do you have {1}$ ? - {2}','Peter', 20.5 * 2, false));


// 12. Write a function that creates a HTML UL using a template for every HTML LI.
//     The source of the list should an array of elements. Replace all placeholders marked with –{…}–
//     with the value of the corresponding property of the object.

var people = [ { name: 'Peter', age: 14 }, { name: 'Gosho', age: 24 } ];
var template = '<div data-type="template" id="list-item"><strong>-{name}-</strong> <span>-{age}-</span></div>';

function generateList (people, template) {
	'use strict';

	var info = '[empty]';
	var result = '<ul>';

	for(var key in people) {
		info = template.replace(/(-\{(name)\}-)/, people[key].name).replace(/(-\{(age)\}-)/, people[key].age);
		result += '<li>' + info + '</li>';
	}

	result += '</ul>';
	return result;
}
// TEST
// Result in browser
//document.write(generateList(people, template));

// Result in console
//console.log(generateList(people, template));
