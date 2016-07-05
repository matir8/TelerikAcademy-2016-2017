function solve(args) {
    var n = +args[0];
    var currResult;

    for (var col = 1; col <= n; col++) {
        currResult = '';
        for (var row = col; row < col + n; row++) {
            currResult += row.toString() + ' ';
        }
        console.log(currResult);
    }
}