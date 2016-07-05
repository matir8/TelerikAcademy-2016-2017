function solve(args) {
    var input = args[0].split('\n');
    var maxSeq = 1, currSeq = 1;
    var currNum, nextNum;
    var n = +input[0];
    input = input.slice(1);

    for (var i = 0; i < n; i += 1) {
        currNum = +input[i];
        nextNum = +input[i + 1];
        if(currNum == nextNum) {
            currSeq += 1;
        }
        else {
            maxSeq = Math.max(maxSeq, currSeq);
            currSeq = 1;
        }
    }

    if(n === 0)
        maxSeq = 0;
    
    return maxSeq;
}
