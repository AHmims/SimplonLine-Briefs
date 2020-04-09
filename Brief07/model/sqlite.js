const Database = require('better-sqlite3');
const _DB = new Database('./db/brief07.db');
// 
const _CHALK = require('chalk');
const log = console.log;
// 
function createTables() {
    const string = `CREATE TABLE IF NOT EXISTS User(id STRING, nomPrenom STRING,email STRING,pass STRING); 
        CREATE TABLE IF NOT EXISTS Planet(id INTEGER PRIMARY KEY,name STRING,description TEXT,population STRING,polution STRING,price INTEGER); 
        CREATE TABLE IF NOT EXISTS Reservation(id INTEGER PRIMARY KEY,idUser STRING,idPlanet INTEGER,logement STRING,dateN DATE,dateD DATE,dateF DATE,nbPersones INTEGER,prix DOUBLE,carteB STRING,ccv INTEGER);`;
    // 
    _DB.exec(string);
    log(_CHALK.black.bgCyan.italic("Tables Check done !"));
}
// 
function insertData(table, data) {
    var str = 'INSERT INTO User (id,nomPrenom,email,pass) VALUES(@id,@nomPrenom,@email,@pass);';
    switch (table) {
        case "Planet":
            str = 'INSERT INTO Planet (name,description,population,polution,price) VALUES(@name,@description,@population,@polution,@price);';
            break;
        case "Reservation":
            str = 'INSERT INTO Reservation (idUser,idPlanet,logement,dateN,dateD,dateF,nbPersones,prix,carteB,ccv) values(@idUser,@idPlanet,@logement,@dateN,@dateD,@dateF,@nbPersones,@prix,@carteB,@ccv);';
            break;
    }
    try {
        var state = _DB.prepare(str).run(data);
        return Boolean(state.changes);
    } catch (err) {
        log(_CHALK.black.bgRed.italic("Error! [Function insertData()]"));
    }
}
// 
function getReservation(clientId) {
    return _DB.prepare(`SELECT * FROM Reservation WHERE idUser='${clientId}'`).all();
}
// 
function getUserCred(data) {
    return _DB.prepare(`SELECT id,COUNT(id) AS userExists FROM User WHERE email = '${data.email}' AND pass = '${data.pass}'`).get();
}
// 
function getUserData(userId) {
    return _DB.prepare(`SELECT * FROM User WHERE id = '${userId}'`).get();
}
// 
function deleteQuery(table, key) {
    let query = `DELETE FROM ${table} WHERE id='${key}'`;
    let res = _DB.prepare(query).run();
    // 
    return res.changes;
}
// 
// 
// getReservation("sdq");
// 
module.exports = {
    createTables,
    insertData
}
// 
// createTables();
/*insertData("ss", {
    id: "qqq",
    nomPrenom: "qdqsd",
    email: "qsdqsdq",
    pass: "qdqsdqs"
});*/