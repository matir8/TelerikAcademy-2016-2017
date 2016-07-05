function solve(args) {

    var max = +args[0];
    for (var i = 0; i < 5; i++) {
        if(args[i] > max)
            max = +args[i];
    }

    return max;
}