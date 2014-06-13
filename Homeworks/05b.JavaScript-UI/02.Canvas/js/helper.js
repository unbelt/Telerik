function ellipse(context, cx, cy, rx, ry, fillStyle, strokeStyle) {
	context.beginPath();
	context.save(); // save state

	context.translate(cx - rx, cy - ry);
	context.scale(rx, ry);
	context.arc(1, 1, 1, 0, 2 * Math.PI, false);

	context.restore(); // restore to original state

	draw(context, fillStyle, strokeStyle);
}

function line(context, x, y, from, to, strokeStyle) {
	context.beginPath();

	context.moveTo(from, to);
	context.lineTo(x, y);

	draw(context, strokeStyle);
}

function curve(context, startX, startY, cx, cy, endX, endY, fillStyle, strokeStyle) {
	context.moveTo(startX, startY);
	context.quadraticCurveTo(cx, cy, endX, endY);

	draw(context, fillStyle, strokeStyle);
}

function bezierCurve(context, startX, startY, cx1, cy1, cx2, cy2, endX, endY, fillStyle, strokeStyle) {
	context.moveTo(startX, startY);
	context.bezierCurveTo(cx1, cy1, cx2, cy2, endX, endY);

	draw(context, fillStyle, strokeStyle);
}

function rectangle(context, x, y, width, height, fillStyle, strokeStyle) {
	context.beginPath();
	context.rect(x, y, width, height);

	draw(context, fillStyle, strokeStyle);
}

function draw(context, fillStyle, strokeStyle) {
	context.fillStyle = fillStyle;
	context.strokeStyle = strokeStyle;

	context.fill();
	context.stroke();
	context.closePath();
}

function getRadians(deg) {
	return deg * Math.PI / 180;
}