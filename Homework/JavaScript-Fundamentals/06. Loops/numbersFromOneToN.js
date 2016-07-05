function solve(args) {
    var n = +args[0];
    var result = '';
    for (let i = 1; i <= n; i++) {
        result += i.toString() + ' ';
    }

    return result;
}
