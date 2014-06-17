(function() {
    'use strict';

    var move = (function() {
        var angle = 0;

        return function(circles, radius) {
            var step = 2 * Math.PI / circles.length;

            for (var i = 0; i < circles.length; i++) {
                circles[i].style.left = Math.cos(angle + (i * step)) * radius + 'px';
                circles[i].style.top = Math.sin(angle + (i * step)) * radius + 'px';
            }

            angle += 0.05;
            angle %= (2 * Math.PI);
        };
    }());

    (function() {
        var circles = document.querySelectorAll('.circle');

        (function animLoop() {
            move(circles, 100);
            window.requestAnimationFrame(animLoop);
        }());
    }());
}());