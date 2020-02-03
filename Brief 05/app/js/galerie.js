const _DATA = [{
        description: "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Reiciendis illo necessitatibus nam odioesse quaerat, tempore, omnis laboriosam eius laudantium voluptates amet, hic veritatis. Sintreprehenderit sapiente accusantium ab accusamus.",
        details: [{
                title: "Model",
                value: "Yacht Model"
            },
            {
                title: "Knots",
                value: "Yacht knots"
            },
            {
                title: "Size",
                value: "Big"
            }
        ],
        price: "5000"
    },
    {
        description: "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Reiciendis.",
        details: [{
                title: "Model",
                value: "Yacht Model"
            },
            {
                title: "Knots",
                value: "Yacht knots VALUE"
            },
            {
                title: "Size",
                value: "Medium"
            }
        ],
        price: "6000"
    }
]
window.onload = () => {
    let pos = 0;
    const _LANDING = document.getElementById('landing');
    const imgs = document.getElementsByClassName('infos-img');
    _LANDING.style = `background-image: url('app/img/galerie/img${pos+1}.jpg')`;
    //  
    for (let i = 1; i <= imgs.length; i++) {
        imgs[i - 1].style = `background-image: url('app/img/galerie/thumbs/img${pos+i}.jpg')`;
    }
    for (let i = 1; i < imgs.length; i++) {
        imgs[i].style = `background-image: linear-gradient(#0000008a, #0000008a),${imgs[i].style.backgroundImage}`;
    }
    // 
    // 
    SliderNavigation(0, 1);
    // 
    let lastPos = 0;
    document.getElementById('nav-B').addEventListener('click', () => {
        if (pos > 0) {
            lastPos = pos;
            pos--;
            // 
            SliderNavigation(pos, lastPos);
        }
    });
    document.getElementById('nav-N').addEventListener('click', () => {
        if (pos < imgs.length - 1) {
            lastPos = pos;
            pos++;
            // 
            SliderNavigation(pos, lastPos);
        }
    });

}
let bool = true;

function SliderNavigation(index, lastIndex) {
    const _IMAGES = document.getElementsByClassName('infos-img');
    // 
    _IMAGES[lastIndex].style.backgroundImage = `linear-gradient(#0000008a, #0000008a),${_IMAGES[lastIndex].style.backgroundImage}`;
    // 
    _IMAGES[index].style.backgroundImage = `url('app/img/galerie/thumbs/img${index+1}.jpg')`;
    document.getElementById('landing').style = `background-image: linear-gradient(#04151f33, #04151f33), url('app/img/galerie/img${index+1}.jpg');`;
    // 
    let data = _DATA[+bool];
    document.getElementById('infos-desc-cont').innerText = data.description;
    // 
    let details_title = document.getElementsByClassName('infos-details-title');
    let details_data = document.getElementsByClassName('infos-details-det');

    for (let i = 0; i < details_title.length; i++) {
        details_title[i].innerText = data.details[i].title;
        details_data[i].innerText = data.details[i].value;
    }
    // 
    document.getElementById('infos-price-amount').innerText = data.price + "-DH";
    bool = !bool;
}