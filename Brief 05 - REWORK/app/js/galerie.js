let images = document.getElementsByClassName('galerie-images-img');
const _IMAGES_NAMES = [
    "earth",
    "moon",
    "404",
    "mars",
    "namek-flip"
]
let lorem = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Perspiciatis, amet! Quis eius consequatur, natus quam illum sunt ad. Eum placeat itaque enim distinctio? Suscipit neque ad atque blanditiis officia nemo omnis ratione eveniet cupiditate fugit voluptatum odit eius, fuga maiores.";

const _PLANETS = [{
        path: "earth",
        name: "The Earth",
        description: lorem,
        population: "3 bil",
        polution: "80%",
        price: "1000 dh"
    },
    {
        path: "moon",
        name: "The Moon",
        description: lorem,
        population: "0 Person",
        polution: "0%",
        price: "500000 dh"
    },
    {
        path: "404",
        name: "Unknown Planet",
        description: lorem,
        population: "???",
        polution: "???",
        price: "99 dh"
    },
    {
        path: "mars",
        name: "Mars",
        description: lorem,
        population: "0",
        polution: "??",
        price: "500000 dh"
    },
    {
        path: "namek-flip",
        name: "Namek Planet",
        description: lorem,
        population: "100 person",
        polution: "0%",
        price: "420000 dh"
    }
]
let pos = 0;


document.getElementById('navigation-next').addEventListener('click', () => {
    if (pos < images.length - 1)
        pos++;
    else if (pos == images.length - 1)
        pos = 0;
    switchData();
});
document.getElementById('navigation-back').addEventListener('click', () => {
    if (pos > 0)
        pos--;
    else if (pos == 0)
        pos = images.length - 1;
    switchData();
});
// 
// 
function switchData() {
    document.getElementById('galerie-preview-planet').style.backgroundImage = `url("./app/img/${_PLANETS[pos].path}.png")`;
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
    // 
    // CHANGE DISPLAYED TEXT
    document.getElementById('galerie-desc-title').innerText = _PLANETS[pos].name;
    document.getElementById('galerie-desc-txt').innerText = _PLANETS[pos].description;
    document.getElementsByClassName('galerie-desc-det')[0].lastElementChild.innerText = _PLANETS[pos].population;
    document.getElementsByClassName('galerie-desc-det')[1].lastElementChild.innerText = _PLANETS[pos].polution;
    document.getElementsByClassName('galerie-desc-det')[2].lastElementChild.innerText = _PLANETS[pos].price;
}