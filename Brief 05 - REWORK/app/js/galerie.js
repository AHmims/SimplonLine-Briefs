let images = document.getElementsByClassName('galerie-images-img');
const _IMAGES_NAMES = [
    "earth",
    "moon",
    "404",
    "mars",
    "namek-flip"
]
let pos = 0;


document.getElementById('navigation-next').addEventListener('click', () => {
    if (pos < images.length - 1)
        pos++;
    else if (pos == images.length - 1)
        pos = 0;
    switchImage();
});
document.getElementById('navigation-back').addEventListener('click', () => {
    if (pos > 0)
        pos--;
    else if (pos == 0)
        pos = images.length - 1;
    switchImage();
});
// 
// 
function switchImage() {
    document.getElementById('galerie-preview-planet').style.backgroundImage = `url("./app/img/${_IMAGES_NAMES[pos]}.png")`;
    //Clear previous style 
    for (let i = 0; i < images.length; i++) {
        if (i != pos) {
            images[i].style.backgroundSize = "";
            images[i].style.filter = "";
        }
    }
    // Apply style
    images[pos].style.backgroundSize = "270%";
    images[pos].style.filter = "brightness(0.85)";
}
// background-size: 270%;
// filter: brightness(0.75);

// url('./app/img/earth.png');
// linear-gradient(#ffffff59, #ffffff59),url('../img/gallery/thumbs/bg2.jpg')