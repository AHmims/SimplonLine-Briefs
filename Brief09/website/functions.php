<?php
function getAllDataFromTable($table)
{
    console_log($table);
    include 'dbConnection.php';
    $req = "SELECT * FROM $table";
    $res = $cnx->query($req);
    // 
    return $res;

    // $array = [];
    // while ($row = $res->fetch_assoc()) {
    //     array_push($array, $row["table_name"]);
    // }
    // // 
    // return $array; 
}
// 
function getColumns($table)
{
    include 'dbConnection.php';
    $req = "DESCRIBE $table";
    $res = $cnx->query($req);
    // 
    $array = [];
    while ($row = $res->fetch_assoc()) {
        // array_push($array, json_encode($row));
        array_push($array, $row["Field"]);
    }
    // 
    return $array;
}
// 
function getRows($table)
{
    include 'dbConnection.php';
    $req = "SELECT * FROM $table";
    $res = $cnx->query($req);
    // 
    $array = [];
    while ($row = $res->fetch_assoc()) {
        array_push($array, json_encode($row));
        // array_push($array, $row["table_name"]);
    }
    // 
    return $array;
}
// 
function removeRow($table, $params)
{
    $key = $params["key"];
    // echo $params["value"];
    include 'dbConnection.php';
    $req = $cnx->prepare("DELETE FROM $table WHERE $key = ?");
    $req->bind_param("s", $params["value"]);
    return $req->execute();
}
// 
if (isset($_POST['table'])) {
    // echo $_POST['data']["key"];
    echo removeRow($_POST['table'], $_POST['data']);
}
// 
function console_log($data)
{
    echo '<script>console.log(' . json_encode($data) . ')</script>';
}
