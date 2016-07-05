function solve(args) {
    var input = args[0].split('\n');
    var firstStr = input[0];
    var secondStr = input[1];

    if (firstStr < secondStr) {
        return '<';
    }
        
    else if (firstStr > secondStr) {
        return '>';
    }

    else {
        return '=';
    }
}