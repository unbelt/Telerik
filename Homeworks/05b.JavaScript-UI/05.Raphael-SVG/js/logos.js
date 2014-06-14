(function() {

    // Telerik logo
    var scene = Raphael(20, 150, 350, 150),

        logo = scene.path('M10 30 L30 10 L70 50 L50 70 L30 50 L70 10 L90 30').attr({
            'stroke-width': 10,
            stroke: 'yellowgreen'
        }),

        telerik = scene.text(100, 50, 'Telerik').attr({
            'font-weight': 'bold',
            'font-size': 70,
            'font-family': 'Calibri, Arial',
            'text-anchor': 'start'
        }),

        r = scene.text(309, 50, 'R').attr({
            'font-size': 12,
            'font-weight': 'bold',
            'font-family': 'Calibri, Arial',
        }),

        circleR = scene.circle(309.5, 50, 6).attr({
            'stroke-width': 1.5
        }),

        slogan = scene.text(110, 90, 'Develop experiences').attr({
            'font-size': 25,
            'font-family': 'Calibri, Arial',
            'text-anchor': 'start'
        });


    // YouTube logo
    scene = Raphael(50, 350, 300, 100),

    you = scene.text(10, 40, 'You').attr({
        'font-size': 70,
        'font-family': 'Arial Narrow',
        'font-weight': 'bold',
        'text-anchor': 'start'
    }),

    rect = scene.rect(120, 0, 150, 80, 20).attr({
        fill: 'red',
        stroke: 'red'
    }),

    tube = scene.text(130, 40, 'Tube').attr({
        fill: 'white',
        'font-size': 70,
        'font-family': 'Arial Narrow',
        'font-weight': 'bold',
        'text-anchor': 'start'
    });
})();
