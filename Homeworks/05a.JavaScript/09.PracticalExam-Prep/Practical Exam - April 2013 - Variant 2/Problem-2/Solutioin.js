function Solve(args) {
	'use strict';

    var input, N, M, R, C, matrix,
    directions = { d: [1, 0], r: [0, 1], u: [-1, 0], l: [0, -1] };

    input = args.shift().split(' ');
    N = +input[0];
    M = +input[1];

    input = args.shift().split(' ');
    R = +input[0];
    C = +input[1];

    matrix = args.map(function(row) {
    	return row.split('');
    });

	function getValue(row, col) {
		return row * M + col + 1;
	}

	function isInside(row, col) {
		return 0 <= row && row < N && 0 <= col && col < M;
	}

	function visit(row, col) {
		matrix[row][col] = 'X';
	}

	function isVisited(row, col) {
		return matrix[row][col] === 'X';
	}

	function traverse() {
		var row = R, col = C, sum = 0, length = 0, direction;

		while (true) {

            if (!isInside(row, col))  {
            	return 'out ' + sum;
            }

            if (isVisited(row, col)) {
            	return 'lost ' + length;
            }

            length++;
            sum += getValue(row, col);

            direction = directions[matrix[row][col]];
            visit(row, col);

            row += direction[0];
            col += direction[1];
        }
    }

    return traverse();
}

//console.log(Solve([ '3 4', '1 3', 'lrrd', 'dlll', 'rddd' ]));