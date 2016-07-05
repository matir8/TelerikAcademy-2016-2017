function solve(args) {
    var input = args[0].split('\n'),
        n = +input[0],
        numbers = +input.slice(1),
        currNum,
        bestNum,
        bestCounter,
        counter = 1;
    
        numbers = selectionSort(numbers);

    for (var i = 0; i < n - 1; i += 1) {
        currNum = numbers[i];
        if (currNum == numbers[i + 1]) {
            counter += 1;
        } 
        else {
            if(counter > bestCounter) {
                bestCounter = counter;
                bestNum = currNum;
                counter = 1;
            }
        }
    }

    console.log(bestNum + '(' + bestCounter + 'times' + ')');
}

function selectionSort(numbers) {
    var min;
    for (var j = 0; j < n; j += 1) {
    min = numbers[j];
    for (var i = j; i < n; i += 1) {

        if (+numbers[i] < min) {
            min = +numbers[i];
            numbers[i] = +numbers[j];                
            numbers[j] = min;
            }
        }
    }
    return numbers;
}
