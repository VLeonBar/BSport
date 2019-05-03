<?php

require_once "../conexion.php";
require_once "../funciones.php";

$datos = $_POST;

try {
    //Comprueba que los datos lleguen correctamente
    if ( validaCadenas($datos) ) {
        $login = $datos['Login'];
        $pass = $datos['Pass'];
    } else {
        throw new InvalidArgumentException();
    }

    //Compruebo si los datos login y pass existen y si concuerdan, mediante la funcion loginUser
    if (loginUser($pdo, $login, $pass)) {
        if ($datosUser = loadUser($pdo, $login)) {
            //Devuelve los datos del usuario
            echo json_encode(array("Codigo" => 1, "Usuario" => $datosUser), JSON_FORCE_OBJECT);
        }
    } else {
        echo json_encode(array("Codigo" => 103, "Mensaje" => "Error: nombre de cuenta o contraseña incorrectos."));
    }
} catch (InvalidArgumentException $e) {
    echo json_encode(array("Codigo" => 102, "Mensaje" => "Error: datos introducidos no válidos."));
} catch (Exception $e) {
    echo json_encode(array("Codigo" => 191, "Mensaje" => "Error desconocido."));
}
