function IsBrowserMozilla() {
	'use strict';

	var browserName = window.navigator.appCodeName; // Don't actually work
	var IsMozilla = browserName === 'Mozilla';
	var message = { true: 'Yes', false: 'No' };

	alert(browserName);
	alert(message[IsMozilla]);
}