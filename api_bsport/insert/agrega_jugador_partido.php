<?php

require_once "../conexion.php";
require_once "../funciones.php";

$datos = $_POST;

try {
    //Compruebo que los datos que me llegan son strings y no vienen vacíos
    if (cadenasNoVacias($datos)) {
        $IdUsuario = (int)$datos['Id_usuario'];
        $IdPartido = (int)$datos['Id_partido'];
    } else {
        throw new InvalidArgumentException();
    }
    // Compruebo que el usuario no esté inscrito al partido antes de añadirlo.
    $stmt = $pdo->prepare("SELECT COUNT(Id_partido) FROM partidos_usuarios WHERE (Id_partido=:IdPartido && Id_usuario=:IdUsuario) GROUP BY Id_usuario");
    $stmt->execute(array("IdPartido" => $IdPartido, "IdUsuario" => $IdUsuario));
    $res = $stmt->fetch();
    if ($res[0]) {
        echo json_encode(array("Codigo" => 111, "Mensaje" => "Ya está inscrito a este partido."));
    } else {

        //Inserto al jugador al partido en la tabla relacional entre jugadores y partidos como NO administrador
        $stmt = $pdo->prepare("INSERT INTO partidos_usuarios(Id_partido,Id_usuario,Admin) VALUES(:IdPartido,:IdUsuario,0)");
        $stmt->execute(array("IdPartido" => $IdPartido, "IdUsuario" => $IdUsuario));

        //Envío código de validacion
        echo json_encode(array("Codigo" => 1, "Mensaje" => "Jugador inscrito a partido."));
    }
} catch (PDOException $e) {
    echo json_encode(array("Codigo" => 107, "Mensaje" => "Error en la BASEDEDAT de datos." . $e));
} catch (InvalidArgumentException $e) {
    echo json_encode(array("Codigo" => 102, "Mensaje" => "Error en la obtención de datos."));
} catch (Exception $e) {
    echo json_encode(array("Codigo" => 191, "Mensaje" => "Error desconocido" . $e));
}
