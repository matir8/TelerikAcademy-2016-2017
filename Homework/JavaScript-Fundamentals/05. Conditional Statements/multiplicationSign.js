function solve(args) {
    var a = +args[0];
    var b = +args[1];
    var c = +args[2];
    
    if(a == 0 || b == 0 || c == 0)
        console.log('0');
    else if(a < 0 && b > 0 && c > 0)
        console.log('-');
    else if(a > 0 && b < 0 && c > 0)
        console.log('-');
    else if(a > 0 && b > 0 && c < 0)
        console.log('-');    
    else if(a < 0 && b < 0 && c < 0)
        console.log('-');
    else if(a > 0 && b > 0 && c > 0)
        console.log('+');
    else if(a < 0 && b < 0 && c > 0)
        console.log('+');
    else if(a < 0 && b > 0 && c < 0)
        console.log('+');
    else if(a > 0 && b < 0 && c < 0)
        console.log('+');
}

solve(['-1','-0.5','-5.1'])