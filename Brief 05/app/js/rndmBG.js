window.onload = () => {
    let nbC = 5,
        nbS = 5,
        nbT = 3;
    // 
    for (let i = 0; i < nbC; i++) {
        makeShape('shape-circle');
    }
    for (let i = 0; i < nbS; i++) {
        makeShape('shape-square');
    }
    for (let i = 0; i < nbT; i++) {
        makeShape('shape-triangle');
    }
    // 
    // 
    setInterval(() => {
        // alert_Error(document.getElementById('alerts'), "slm");
    }, 500);
}
// 
function makeShape(className) {
    const _SHAPE = document.createElement('div');
    _SHAPE.setAttribute('class', className);
    let size = Math.floor(Math.random() * 200) + 50;
    _SHAPE.style.width = `${size}px`;
    _SHAPE.style.height = `${size}px`;
    // let posX = Math.floor(Math.random() * window.screen.availWidth - 78);
    // let posY = Math.floor(Math.random() * window.screen.availHeight);
    let posX = Math.floor(Math.random() * 1840);
    let posY = Math.floor(Math.random() * 1050);
    _SHAPE.style.top = `${posY}px`;
    _SHAPE.style.left = `${posX}px`;
    // 
    if (className == 'shape-triangle') {
        _SHAPE.style.borderWidth = `${size/2}px`;
    }
    // 
    document.getElementById('shapes').appendChild(_SHAPE);
}
// 