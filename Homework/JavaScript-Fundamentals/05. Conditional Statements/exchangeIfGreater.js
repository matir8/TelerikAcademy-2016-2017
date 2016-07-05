function solve(args) {
    var a = +args[0];
    var b = +args[1];

    var c = a;
    if(c > b)
    {
        a = b;
        b = c;
    }

    console.log(a + ' ' + b);
}