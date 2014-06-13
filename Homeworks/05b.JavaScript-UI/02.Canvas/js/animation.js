(function() {
    var canvas = document.getElementById('animate-canvas'),
        ctx = canvas.getContext('2d'),
        circle = {
            x: 50,
            y: 50,
            r: 30,
            vx: 5,
            vy: 10
        };

    ctx.fillStyle = 'lightblue';

    function executeFrame() {
        'use strict';

        // Increment location by velocity
        circle.x += circle.vx;
        circle.y += circle.vy;

        // Check for collisions with borders
        if (circle.x + circle.r > canvas.width || circle.x - circle.r < 0) {
            circle.vx *= -1;
        }

        if (circle.y + circle.r > canvas.height || circle.y - circle.r < 0) {
            circle.vy *= -1;
        }

        ctx.clearRect(0, 0, canvas.width, canvas.height);
        ctx.beginPath();
        ctx.arc(circle.x, circle.y, circle.r, 0, 2 * Math.PI);
        ctx.closePath();
        ctx.fill();

        window.requestAnimationFrame(executeFrame);
    }

    // Start the animation
    executeFrame();

})();