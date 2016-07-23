function solve() {
    return function (element) {
        if (typeof (element) === 'string') {
            element = document.getElementById(element);
        }

        if (!element) {
            throw new Error("The passed parameter is neither exsisting DOM element or valid id");
        }

        var cNode = element.children;
        len = cNode.length;

        for (var i = 0; i < len; i += 1) {

            if (cNode[i].className === 'button') {
                cNode[i].innerHTML = 'hide';

                cNode[i].addEventListener('click', function (ev) {
                    var clickedButton = ev.target;
                    var nextSibling = clickedButton.nextElementSibling;
                    while (nextSibling && nextSibling.className !== 'content') {
                        if (nextSibling.className === 'button') {
                            break;
                        }
                        nextSibling = nextSibling.nextElementSibling;
                    }

                    if (nextSibling.className === 'content') {
                        if (nextSibling.style.display === 'none') {
                            nextSibling.style.display = '';
                            clickedButton.innerHTML = 'hide';
                        }
                        else {
                            nextSibling.style.display = 'none';
                            clickedButton.innerHTML = 'show';
                        }

                    }

                });
            }
        }
    };
}
