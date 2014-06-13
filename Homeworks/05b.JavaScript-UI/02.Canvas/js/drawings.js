(function() {
    var ctx = document.getElementById('draw-canvas').getContext('2d'),
        lightBlue = 'lightblue',
        darkBlue = '#366089',
        dark = '#262525',
        greenBlue = '#347e91',
        brown = '#975b5b',
        black = '#000000';

    /* ----------------- The Face ----------------- */
    ctx.lineWidth = 2;
    ctx.lineCap = 'round';
    ctx.strokeStyle = darkBlue;

    // the face
    ellipse(ctx, 130, 170, 60, 60, lightBlue);

    // left eye
    ellipse(ctx, 90, 155, 10, 7, lightBlue);
    ellipse(ctx, 86, 155, 2, 5, darkBlue);

    // right eye
    ellipse(ctx, 140, 155, 10, 7, lightBlue);
    ellipse(ctx, 136, 155, 2, 5, darkBlue);

    // nose
    line(ctx, 103, 182, 115, 155);
    line(ctx, 117, 182, 103, 182);

    // month
    ctx.rotate(getRadians(6));
    ellipse(ctx, 142, 190, 25, 8, lightBlue);
    ctx.rotate(getRadians(-6));

    // the hat
    ellipse(ctx, 125, 120, 68, 13, darkBlue, dark);
    rectangle(ctx, 90, 45, 75, 70, darkBlue, darkBlue);
    ellipse(ctx, 128, 40, 37, 13, darkBlue, dark);
    curve(ctx, 90, 110, 130, 128, 165, 110, darkBlue, dark);
    line(ctx, 90, 110, 90, 40);
    line(ctx, 165, 110, 165, 40);


    /* ----------------- The Bicycle ----------------- */

    ctx.strokeStyle = greenBlue;

    ellipse(ctx, 80, 400, 53, 53, lightBlue);
    ellipse(ctx, 280, 400, 53, 53, lightBlue);

    line(ctx, 75, 400, 140, 330);
    line(ctx, 140, 330, 260, 330);
    line(ctx, 260, 330, 160, 400);
    line(ctx, 160, 400, 75, 400);
    line(ctx, 160, 400, 130, 310);
    line(ctx, 105, 310, 150, 310);
    line(ctx, 280, 400, 250, 290);
    line(ctx, 250, 290, 210, 305);
    line(ctx, 250, 290, 275, 260);

    ctx.fillStyle = 'rgba(0, 0, 0, 0)';
    ellipse(ctx, 160, 400, 14, 14);

    line(ctx, 152, 388, 144, 375);
    line(ctx, 177, 425, 167, 412);


    /* ----------------- The House ----------------- */

    rectangle(ctx, 400, 151, 240, 195, brown, black);

    // roof
    ctx.beginPath();
    ctx.moveTo(400, 150);
    ctx.lineTo(515, 15);
    ctx.lineTo(640, 150);
    draw(ctx);

    // chimney
    rectangle(ctx, 565, 45, 27, 75);
    ctx.strokeStyle = brown;
    line(ctx, 565, 120, 595, 120, brown);
    ctx.strokeStyle = black;
    ellipse(ctx, 579, 45, 13, 4);

    // windows XP
    rectangle(ctx, 420, 170, 85, 60, black);
    rectangle(ctx, 535, 170, 85, 60, black);
    rectangle(ctx, 535, 260, 85, 60, black);

    // windows bars
    ctx.strokeStyle = brown;
    line(ctx, 462, 160, 462, 270);
    line(ctx, 415, 200, 630, 200);
    line(ctx, 577, 169, 577, 325);
    line(ctx, 530, 290, 635, 290);

    // door
    ctx.beginPath();
    ctx.strokeStyle = black;
    ctx.moveTo(430, 345);
    ctx.lineTo(430, 290);
    ctx.moveTo(462, 345);
    ctx.lineTo(462, 265);
    ctx.moveTo(430, 290);
    ctx.bezierCurveTo(425, 255, 500, 255, 495, 290);
    ctx.moveTo(495, 290);
    ctx.lineTo(495, 345);
    ctx.stroke();
    ellipse(ctx, 450, 320, 4, 4, brown, black);
    ellipse(ctx, 473, 320, 4, 4, brown, black);
})();
