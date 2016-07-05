function solve(args) {
    var max = +args[0];
    var min = +args[0];
    var sum = 0;
    var avg = 0;

    for (var i = 0; i < args.length; i++) {
        var currNum = +args[i];
        max = Math.max(max, currNum);
        min = Math.min(min, currNum);
        sum += currNum;
    }

    avg = sum / i;

    console.log('min=' + min.toFixed(2));
    console.log('max=' + max.toFixed(2));
    console.log('sum=' + sum.toFixed(2));
    console.log('avg=' + avg.toFixed(2));
}