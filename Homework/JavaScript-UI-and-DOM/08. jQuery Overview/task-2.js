function solve() {
    return function (selector) {
        var $element;
        if (typeof (selector) === 'string') {
            $element = $(selector);
        }

        if (!$element.length) {
            throw new Error('Invalid selector!');
        }

        var $buttons = $element.find('.button').html('hide').on('click', function () {
            var $this = $(this);

            var nextElement = $this.next();
            while (nextElement && !nextElement.hasClass('content')) {
                if (nextElement.hasClass('button')) {
                    break;
                }
                nextElement = nextElement.next();
            }
            if (nextElement.hasClass('content')) {
                if (nextElement.css('display') === 'none') {
                    nextElement.css('display', 'block');
                    $this.html('hide');
                }
                else {
                    nextElement.css('display', 'none');
                    $this.html('show');
                }
            }

        });

    };
}