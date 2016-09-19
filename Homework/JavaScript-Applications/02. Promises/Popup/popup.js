(function(){
    let divElement = document.getElementById('container');
    
    function popupPromise() {
        return new Promise((resolve, reject) => {
            resolve('https://telerikacademy.com/');
        });
    }

    function popup(link) {
        let popupWindow = window.open("", "popupWindow", "width=700", "height=700");
        popupWindow.document.write('<div>You are going to be redirected after 2 seconds</div>');

        setTimeout(() => {
            popupWindow.window.location = link;
        }, 2000);
    }

    popupPromise()
        .then(popup);
}());