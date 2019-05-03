<?php

require_once "../conexion.php";
require_once "../funciones.php";

$datos = $_POST;

try {

    //Compruebo si los datos login y pass existen y si concuerdan, mediante la funcion loginUser
    if ($partidos = stdQuery($pdo, "SELECT 	partidos.*,
	COUNT(partidos_usuarios.`Id_partido`) AS NJugadores
    FROM partidos
    LEFT JOIN partidos_usuarios
	ON partidos.`Id_partido` = partidos_usuarios.`Id_partido`
    GROUP BY partidos.Id_partido", PDO::FETCH_ASSOC)) {
        //Devuelve los datos del usuario
        echo json_encode(array("Codigo" => 1, "Partidos" => $partidos));
    } else {
        echo json_encode(array("Codigo" => 103, "Mensaje" => "Error: no hay partidos disponibles."));
    }
} catch (Exception $e) {
    echo json_encode(array("Codigo" => 191, "Mensaje" => "Error desconocido." . $e));
}
