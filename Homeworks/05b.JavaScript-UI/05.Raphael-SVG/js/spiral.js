(function() {

    var scene = Raphael(innerWidth / 3, 150, 400, 300);

    function drawSpiral(cX, cY, a, b) {
        var center = 'M' + cX + ' ' + cY,
            spiral = [center];

        for (var i = 0; i < 600; i++) {

            var angle = -0.05 * i,
                x = cX + (a + b * angle) * Math.cos(angle),
                y = cY + (a + b * angle) * Math.sin(angle);

            spiral.push('L' + x + ' ' + y);
        }

        scene.path(spiral.join(' '));
    }

    drawSpiral(220, 100, 0, 4);
})();
