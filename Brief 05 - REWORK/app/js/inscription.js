// sessionStorage.getItem(_SESSION);
const _Regex_Identifiant = /^[a-zA-Z0-9._-]{5,20}$/;
const _Regex_NP = /^[a-zA-Z ]+$/;
const _Regex_Email = /^[a-zA-Z0-9._-]{5,20}\@[a-zA-Z0-9-]{3,15}\.[a-zA-Z]{2,4}$/;
// 
document.getElementById('form-btn-sec').addEventListener('click', () => {
    let inputs = document.getElementsByClassName('form-row-input');
    for (let i = 0; i < inputs.length; i++) {
        inputs[i].value = "";
    }
});
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
        const _Regex_Identifiant = /^[a-zA-Z0-9._-]{5,20}$/;
        const _Regex_NP = /^[a-zA-Z ]+$/;
        const _Regex_Email = /^[a-zA-Z0-9._-]{5,20}\@[a-zA-Z0-9-]{3,15}\.[a-zA-Z]{2,4}$/;
        // 
        if (_Regex_Identifiant.test(_VALUES[0].value) == false) {
            valide = false;
            showErrMsg("Identifiant non valide");
        }
        if (_Regex_NP.test(_VALUES[1].value) == false) {
            valide = false;
            showErrMsg("Nom & Prenom non valide");
        }
        if (_Regex_Email.test(_VALUES[2].value) == false) {
            valide = false;
            showErrMsg("Email non valide");
        }
        // 
        if (_VALUES[3].value.length >= 6) {
            if (_VALUES[3].value != _VALUES[4].value) {
                valide = false;
                showErrMsg("Password doesn't match");
            }
        } else {
            valide = false;
            showErrMsg("Password must be 6 characters and above");
        }
        // 
        // 
        if (valide == true) {
            alert('SHOW A SUCCES MESSAGE / POP UP HERE');
            sessionStorage.setItem("user-auth-np", _VALUES[1].value);
            sessionStorage.setItem("user-auth-email", _VALUES[2].value);
            // 
            document.getElementById('content').scrollTo(0, 0);
        }
    }
});
// 
function showErrMsg(msg) {
    alert(msg);
}