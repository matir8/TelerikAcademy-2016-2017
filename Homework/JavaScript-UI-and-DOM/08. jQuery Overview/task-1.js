function solve() {
    return function (selector, count) {
        count = +count;
        if (isNaN(count)) {
            throw new Error('Invalid number!');
        }
        if (typeof (count) !== 'number') {
            throw new Error('Invalid number!');
        }
        if (count < 1) {
            throw new Error('Invalid number!');
        }

        

        if (typeof (selector) !== 'string') {
            throw new Error('Invalid selector!');
        }
        var $selector = $(selector);
        const listClass = 'items-list';
        const listItemsClass = 'list-item';
        $selector.append('<ul class="' + listClass + '">' + '</ul>');
        var $list = $('.' + listClass);
        for (var i = 0; i < +count; i += 1) {
            var listItem = '<li class="' + listItemsClass + '">List item #' + i + '</li>';
            $list.append(listItem);
        }
    };
}