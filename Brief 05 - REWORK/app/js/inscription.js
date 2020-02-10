document.getElementById('form-btn-main').addEventListener('click', () => {
    const _VALUES = document.getElementsByClassName('form-row-input');
    // FIELDS ARE VALIDE BY DEFAULT
    let valide = true;
    // 
    for (let i = 0; i < _VALUES.length; i++) {
        // if (!_VALUES[i].value) {
        // if (_VALUES[i].value.length == 0) {
        if (_VALUES[i].value == '') {
            showErrMsg("empty");
            valide = false;
            break;
        }
    }
    // 
    // if(valide){
    if (valide == true) {

    }
});
// 
function showErrMsg(msg) {
    alert(msg);
}