(function () {

    function getLocation() {
        return new Promise((resolve, reject) => {
            navigator.geolocation.getCurrentPosition(
                (position) => { resolve(position) },
                (error) => { reject(error) }
            )
        })
    }

    function generateMapImage(position) {
        let imageElement = document.getElementById('map'),
            imageSrc = `http://maps.googleapis.com/maps/api/staticmap?center=${position.coords.latitude},${position.coords.longitude}&zoom=18&size=1000x1000&sensor=false`;

        imageElement.setAttribute('src', imageSrc);
    }

    getLocation()
        .then(generateMapImage);
} ());
