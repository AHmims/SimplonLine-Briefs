const _EXPRESS = require('express');
// const _SESSION = require('express-session');
const _APP = _EXPRESS();
const _BODY_PARSER = require('body-parser')
const _PATH = require('path');
const _PORT = 8080;
// 
_APP.use('/app', _EXPRESS.static(_PATH.join(__dirname, 'app')));
// 
_APP.get('/', (req, res) => {
    res.sendFile(_PATH.join(__dirname, 'index.html'));
});
// START THE SERVER
_APP.listen(_PORT, () => {
    console.log(`Listening on port ${_PORT}\nPlease refere to : localhost:${_PORT}`);
});