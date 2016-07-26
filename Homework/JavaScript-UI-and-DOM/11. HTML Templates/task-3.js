function solve() {
    return function () {
        $.fn.listview = function (collection) {
            var $this = $(this),
                selector = '#' + $this.attr('data-template'),
                templateHTML = $(selector).html(),
                template = handlebars.compile(templateHTML);

            for (var i = 0; i < collection.length; i += 1) {
                $this.append(template(collection[i]));
            }

            return this;
        };
    };
}