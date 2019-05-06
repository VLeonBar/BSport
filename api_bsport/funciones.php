<?php

function printVar($var, $color = "black")
{
    echo "<pre style='color: $color;'>";
    print_r($var);
    echo "</pre>";
}

function stdQuery($conn, $sql, $style = PDO::FETCH_BOTH)
{
    $stm = $conn->query($sql);
    $res = array();
    while ($row = $stm->fetch($style)) {
        array_push($res, $row);
    }
    return $res;
}

function oneRowQuery($conn, $sql, $style = PDO::FETCH_BOTH)
{
    $stm = $conn->query($sql);
    $res = array();
    $row = $stm->fetch($style);
    return $res;
}

function oneResultQuery($conn, $sql)
{
    $stm = $conn->query($sql);
    $tmp = $stm->fetch();
    return $tmp[0];
}

function exists($conn, $table, $column, $value)
{
    $sql = $conn->prepare("SELECT count($column) FROM $table WHERE $column = :value GROUP BY $column");
    if ($sql->execute(array("value" => $value))) {
        $res = $sql->fetch(PDO::FETCH_ASSOC);
    }
    return $res;
}

function loadUserID($conn, $id)
{
    $sql = "SELECT * FROM usuarios WHERE id_usuario = :id";
    $stmt = $conn->prepare($sql);
    $stmt->bindValue("id", $id);
    $stmt->execute();
    return $stmt->fetch(PDO::FETCH_ASSOC);
}

function loadUser($conn, $login)
{
    $sql = "SELECT * FROM usuarios WHERE `login` = :login";
    $stmt = $conn->prepare($sql);
    $stmt->bindValue("login", $login);
    $stmt->execute();
    return $stmt->fetch(PDO::FETCH_ASSOC);
}

function loginUser($conn, $login, $pass)
{
    $sql = $conn->prepare("SELECT COUNT(login) FROM usuarios WHERE `login`= :login AND `pass`=:pass GROUP BY login");
    if ($sql->execute(array("login" => $login, "pass" => $pass))) {
        $res = $sql->fetch();
    }
    return $res;
}

function loadProducto($conn, $id)
{
    $sql = "SELECT * FROM productos WHERE id_producto = :id";
    $stmt = $conn->prepare($sql);
    $stmt->bindValue("id", $id);
    $stmt->execute();
    return $stmt->fetch();
}

function validaEmail($email)
{
    return (filter_var($email, FILTER_VALIDATE_EMAIL)) ? 1 : 0;
}
function validaCadenas($cadenas)
{
    // Comprueba que es un array
    if (!is_array($cadenas)) {
        return false;
    }

    foreach ($cadenas as $cadena) {
        // Comprueba que es una cadena y no está vacía
        if (!is_string($cadena) || empty($cadena)) {
            return false;
        }

        // Comprueba que no tiene espacios
        if (strpos($cadena, " ") !== false) {
            return false;
        }
    }

    return true;
}
function cadenasNoVacias($cadenas)
{
    // Comprueba que es un array
    if (!is_array($cadenas)) {
        return false;
    }

    foreach ($cadenas as $cadena) {
        // Comprueba que es una cadena y no está vacía
        if (!is_string($cadena) || empty($cadena)) {
            return false;
        }
        if (trim($cadena) == "") {
            return false;
        }
    }

    return true;
}
