    function solve(args) {
        let result = 0,
            str = args[0];
        
        for (let i = 0; i < str.length; i++) {
            let currSym = str[i];
            if(currSym == '(') {
                result += 1;
            }
            else if(currSym == ')') {
                result -= 1;
            }

            if(result < 0) {
                console.log('Incorrect');
                return;
            }
        }

        if(result == 0) {
            console.log('Correct');
        }
        else {
            console.log('Incorrect');
        }
    }