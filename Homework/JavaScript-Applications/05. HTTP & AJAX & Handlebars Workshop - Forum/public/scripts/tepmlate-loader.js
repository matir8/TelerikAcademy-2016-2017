const templateLoader = (() => {
    const templatesCache = {};

    function get(templateName) {
        return new Promise((resolve, reject) => {
            if (templatesCache[templateName]) {
                resolve(Handlebars.compile(templatesCache[templateName]));
            }

            $.get(`./templates/${templateName}.html`, template => {
                templatesCache[templateName] = template;
                resolve(Handlebars.compile(template));
            })
        })
    }

    return { get };
})();

export { templateLoader };