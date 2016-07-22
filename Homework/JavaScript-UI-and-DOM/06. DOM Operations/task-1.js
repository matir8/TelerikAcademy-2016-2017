function solve() {
    return function (element, content) {
        var length,
            div = document.createElement('div'),
            fragment = document.createDocumentFragment(),
            i;
            
        if (typeof element === 'string') {
            element = document.getElementById(element);
        }

        if (!element) {
            throw new Error("The first parameter is not a valid id or DOM element!");
        }

        if (content === null || content === undefined) {
            throw new Error("Content cannot be null!");
        }

        content.forEach(function(cont) {
            if (typeof (cont) !== 'string' && typeof (cont) !== 'number') {
                throw new Error("Content should be string or number");
            }
        });

        element.innerHTML = '';
        length = content.length;

        for (i = 0; i < length; i += 1) {
            var newDiv = div.cloneNode(true);
            newDiv.innerHTML = content[i];
            fragment.appendChild(newDiv);
        }
        element.appendChild(fragment);
    };
}