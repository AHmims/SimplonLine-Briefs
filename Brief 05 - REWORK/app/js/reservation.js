document.getElementById('form-btn-res-order').addEventListener('click', () => {
    const _RES_INPUTS = document.getElementsByClassName('form-res-row-data');
    let valide = true;
    // check for changes compared to session
    if (_RES_INPUTS[0].value != sessionStorage.getItem("user-auth-np")) {
        showErrMsg("don't change default values");
        valide = false;
    }
    if (_RES_INPUTS[1].value != sessionStorage.getItem("user-auth-email")) {
        showErrMsg("don't change default values");
        valide = false;
    }
    // Date check
    if (_RES_INPUTS[2].value.length > 0 && _RES_INPUTS[3].value.length > 0) {
        let resrevDate1 = new Date(_RES_INPUTS[2].value);
        let resrevDate2 = new Date(_RES_INPUTS[3].value);
        // Check with current Date
        let currentDate = new Date(Date.now());
        if (currentDate - resrevDate1 > 0) {
            showErrMsg("Date error");
        } else {
            // If ordering date is bigger than staying date value
            if (resrevDate1 - resrevDate2 > 0) {
                showErrMsg("Date error");
                valide = false;
            }
        }
    } else {
        showErrMsg("Fill in a Date");
        valide = false;
    }
    // credit card number
    let regexCCN = /^\d{19}$/;
    if (regexCCN.test(_RES_INPUTS[4].value) == false) {
        showErrMsg("Credit card number errror");
        valide = false;
    }
    //CCV check 
    let regexCCv = /^\d{4}$/;
    if (regexCCv.test(_RES_INPUTS[5].value) == false) {
        showErrMsg("CCV erreur");
        valide = false;
    }
    // 
    // Check Validity
    if (valide) {
        console.log("%cIS GOOD", "background:green;color:white;padding:5px;border-radius:5px;");
    }
});