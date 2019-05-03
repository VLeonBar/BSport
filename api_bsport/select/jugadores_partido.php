<?php

require_once "../conexion.php";
require_once "../funciones.php";

$datos = $_POST;

try {
    if (validaCadenas($datos)) {
        $IdPartido = (int)$datos['Id_partido'];
    } else {
        throw new InvalidArgumentException();
    }
    //Compruebo si los datos login y pass existen y si concuerdan, mediante la funcion loginUser
    if ($usuario = stdQuery($pdo, "SELECT usuarios.`Nombre`
    FROM usuarios
    JOIN `partidos_usuarios`
    ON usuarios.`Id_usuario` = `partidos_usuarios`.`Id_usuario`
    WHERE `Id_partido`=$IdPartido", PDO::FETCH_ASSOC)) {
        //Devuelve los datos del usuario
        echo json_encode(array("Codigo" => 1, "Usuarios" => $usuario));
    } else {
        echo json_encode(array("Codigo" => 103, "Mensaje" => "Error: no hay partidos disponibles."));
    }
} catch (Exception $e) {
    echo json_encode(array("Codigo" => 191, "Mensaje" => "Error desconocido." . $e));
}
