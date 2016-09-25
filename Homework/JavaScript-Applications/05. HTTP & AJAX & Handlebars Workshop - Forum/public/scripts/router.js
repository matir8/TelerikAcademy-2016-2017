import { templateLoader } from './tepmlate-loader.js';
import { data } from './data.js';

let router = (() => {
    let navigo;

    function showMsg(msg, type, cssClass, delay) {
        templateLoader.get('alert')
            .then((alertTemplate) => {
                let container = $(alertTemplate).clone(true)
                    .addClass(cssClass).text(`${type}: ${msg}`)
                    .appendTo('#root');

                setTimeout(() => {
                    container.remove();
                }, delay || 3000)
            });
    }

    function init() {
        navigo = new Navigo(null, false);

        navigo.on('/gallery', () => {
            Promise.all([data.gallery.get(), templateLoader.get('gallery')])
                .then(([data, template]) => {
                    $('#content').html(template(data));
                })
                .catch((err) => showMsg(err, 'Error', 'alert-danger'));
        });

        navigo.on('/threads/:id', (params) => {
            Promise.all([data.threads.getById(params.id), templateLoader.get('messages')])
                .then(([data, template]) => {
                    $('#content').append(template(data));
                })
                .catch((err) => showMsg(err, 'Error', 'alert-danger'));
        })

        navigo.on('/threads', () => {
            Promise.all([data.threads.get(), templateLoader.get('threads')])
                .then(([data, template]) => {
                    $('#content').append(template(data));
                })
                .catch((err) => showMsg(err, 'Error', 'alert-danger'));
        });
    }

    return {
        init,
        showMsg
    };
})();

export { router };