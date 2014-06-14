(function() {

    var stage = new Kinetic.Stage({
        container: 'container',
        width: 800,
        height: 600
    }),

        layer = new Kinetic.Layer();
        mario = new Image();

    mario.onload = function() {
        var marioSprite = new Kinetic.Sprite({
            x: 200,
            y: 500,
            image: mario,
            animation: 'idle',
            animations: {
                idle: [
                    5, 0, 40, 60,
                ],
                move: [
                    45, 0, 40, 60,
                    90, 0, 40, 60,
                    135, 0, 40, 60,
                    175, 0, 40, 60,
                    225, 0, 40, 60,
                    265, 0, 40, 60,
                    305, 0, 40, 60,
                    350, 0, 40, 60,
                    395, 0, 40, 60
                ]
            },

            frameRate: 8,
            frameIndex: 0
        });

        layer.add(marioSprite);
        stage.add(layer);
        marioSprite.start();

        setInterval(function() {
            marioSprite.setX(marioSprite.attrs.x += 30);

            if (marioSprite.attrs.x > 800) {
                marioSprite.attrs.x = 0;
            }

            marioSprite.attrs.animation = 'move';
        }, 100)
    };

    mario.src = 'img/mario.png';

})();