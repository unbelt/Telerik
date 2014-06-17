function createDivs(numberOfDivs) {

    var properties = {
        height: function() {
            return Math.floor(Math.random() * (100 - 20 + 1)) + 20 + 'px';
        },
        width: function() {
            return Math.floor(Math.random() * (100 - 20 + 1)) + 20 + 'px';
        },
        top: function() {
            return Math.random() * (500 - 1) + 1 + 'px';
        },
        left: function() {
            return Math.random() * (1000 - 10) + 1 + 'px';
        },
        color: function() {
            return '#' + Math.floor(Math.random() * 16777215).toString(16);
        },
        borderColor: function() {
            return '#' + Math.floor(Math.random() * 16777215).toString(16);
        },
        backgroundColor: function() {
            return '#' + Math.floor(Math.random() * 16777215).toString(16);
        },
        borderWidth: function() {
            return Math.floor(Math.random() * (20 - 1 + 1)) + 1 + 'px';
        },
        borderRadius: function() {
            return Math.floor(Math.random() * (50 - 1 + 1)) + 1 + 'px';
        }
    }

    var my_div = null;
    var newDiv = null;

    for (var i = 0; i < numberOfDivs; i++) {
        newDiv = document.createElement('div');

        newDiv.style.height = properties.height();
        newDiv.style.width = properties.width();
        newDiv.style.top = properties.top();
        newDiv.style.left = properties.left();
        newDiv.style.color = properties.color();
        newDiv.style.borderColor = properties.borderColor();
        newDiv.style.backgroundColor = properties.backgroundColor();
        newDiv.style.borderWidth = properties.borderWidth();
        newDiv.style.borderRadius = properties.borderRadius();
        newDiv.style.position = 'absolute';


        newDiv.appendChild(document.createTextNode('div'));
        document.body.insertBefore(newDiv, my_div);
    };
}