function solve(args) {
    var n = +args[0],
        currNum = 0;

    for (var i = 0; i < n; i += 1) {
        console.log(currNum);
        currNum += 5;
    }
}