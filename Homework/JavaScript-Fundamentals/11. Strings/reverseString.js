function solve(args) {
    let str = args[0];

    function reverse(str) {
        let temp = '';
        for (let i = str.length - 1; i >= 0; i -= 1) {
            temp += str[i];
        }
        return temp;
    }

    console.log(reverse(str));
}
