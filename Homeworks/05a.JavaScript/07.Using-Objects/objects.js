/* 1. Write functions for working with shapes in  standard Planar coordinate system
		- Points are represented by coordinates P(X, Y)
		- Lines are represented by two points, marking their beginning and ending
		- L(P1(X1,Y1), P2(X2,Y2))
		- Calculate the distance between two points
		- Check if three segment lines can form a triangle
*/
function point(x, y) {
	'use strict';

	if (!(this instanceof point)) {
		return new point(x, y);
	}

	this.x = x;
	this.y = y;
}

point.calcDistance = function(a, b) {
	return Math.sqrt(Math.pow(a.x - b.x, 2) + Math.pow(a.y - b.y, 2));
}

function line(start, end) {
	'use strict';

	if (!(this instanceof line)) {
		return new line(start, end);
	}

	this.start = start;
	this.end = end;
}

line.prototype.getLength = function() {
	return point.calcDistance(this.start, this.end);
}


function triangle(a, b, c) {
	'use strict';

	if (!(this instanceof triangle)) {
		return new triangle(a, b, c);
	}

	if (!(a.getLength() < b.getLength() + c.getLength() &&
		  b.getLength() < c.getLength() + a.getLength() &&
		  c.getLength() < a.getLength() + b.getLength())) {

		console.log('Triangle? ' + true);
	}
	else {
		console.log('Triangle? ' + false);
	}

	this.a = a;
	this.b = b;
	this.c = c;
}


// TESTS
var p1 = new point(3, 5);
var p2 = new point(12, 15);

var l1 = new line(p1, p2);
var l2 = new line(p1, p2);
var l3 = new line(p1, p2);
var t1 = new triangle(l1, l2, l3);

console.log(p1);
console.log(p2);
console.log(l1);
console.log(t1);

console.log(point.calcDistance(p1, p2));


/* 2. Write a function that removes all elements with a given value
		- Attach it to the array type
		- Read about prototype and how to attach methods
*/
Array.prototype.removeAll = function(value) {

	for (var i = 0; i < this.length; i++) {

		if (value == this[i]) {
			this.splice(i, 1);
		}
	}

	return this;
}

// TESTS
var animals = [ 'rabbit', 'horse', 'dog', 'cat', 'eagle', 'snake' ];
//console.log(animals.removeAll('rabbit'));


/* 3. Write a function that makes a deep copy of an object
		- The function should work for both primitive and reference types
*/
function clone(source) {
	'use strict';

	var copy;

	if (source instanceof Object) {

		copy = { };

		for (var prop in source) {

			if (source[prop] !== null && copy[prop]) {
				clone(copy[prop], source[prop]);
	        }
	        else {
				copy[prop] = source[prop];
			}
		}
	}
	else {
		copy = source;
	}

	return copy;
}

// TESTS
var url = 'google.com';
var website = { url: 'google.com' }

var copy = clone(website);

url = 'yahoo.com';
website = { url: 'yahoo.com' }
//console.log(copy);


// 4. Write a function that checks if a given object contains a given property
function hasProperty(source, searchProp) {
	'use strict';

	if (source instanceof Object) {
		return source.hasOwnProperty(searchProp);
	}

	return -1;
}

// TESTS
var animal = 'Rabbit';
var person = { name: 'Rabbit Killer', age: 23, normal: false }
//console.log(hasProperty(person, 'name'));


/* 5. Write a function that finds the youngest person in a given array of persons and prints his/hers full name
		- Each person have properties firstname, lastname and age
*/
function peoples() {
	'use strict';

	var container = [];
	var possibleChar = 'abcdefghijklmnopqrstuvwxyz';

	var firstName = '';
	var lastName = '';

	var age = 0;

	for (var i = 0; i < 10; i++) {

		for (var j = 0; j < 6; j++) {
			firstName += possibleChar.charAt(Math.floor(Math.random() * possibleChar.length));
			lastName += possibleChar.charAt(Math.floor(Math.random() * possibleChar.length));
		}

		age = Math.floor(Math.random() * 99) + 1;

		firstName = capitalise(firstName);
		lastName = capitalise(lastName);

		container.push( { first: firstName, last: lastName, age: age } );

		firstName = '';
		lastName = '';
	}

	function capitalise(string) {
    	return string.charAt(0).toUpperCase() + string.slice(1);
	}

	return container;
}

// TESTS
var persons = peoples();
var youngest = group(persons, 'age');
//console.log(persons[0]);


/* 6. Write a function that groups an array of persons by age, first or last name.
      The function must return an associative array, with keys - the groups, and values -arrays with persons in this groups
		- Use function overloading (i.e. just one function)
*/
function join(pers, prop) {
	'use strict';

	var result = { };

	pers.forEach(function(person) {
		var value = person[prop];
		result[value] = result[value] || [];
		result[value].push(person);
	});

    return result;
}

for (prop in persons[0]) {
	//console.log(join(persons, prop));
}


// Sort people by given criteria
function group(collection, sortBy) {
	'use strict';

	switch(sortBy) {
		case 'name': collection.sort(sortByName); break;
		case 'age': collection.sort(sortByAge); break;
		default: alert('Cannot sort this!'); return;
	}

	function sortByName(a, b) {
		var aName = a.first.toLowerCase();
		var bName = b.first.toLowerCase(); 

		return ((aName < bName) ? -1 : ((aName > bName) ? 1 : 0));
	}

	function sortByAge(a, b) {
		return ((a.age < b.age) ? -1 : ((a.age > b.age) ? 1 : 0));
	}
}

// TESTS
var sorted = group(persons, 'age');
//console.log(persons);
