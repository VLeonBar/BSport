<?php

require_once "../conexion.php";
require_once "../funciones.php";

$datos = $_POST;

try {
    //Compruebo que los datos que me llegan son strings y no vienen vacíos
    if (cadenasNoVacias($datos)) {
        $IdUsuario = $datos['Id_usuario'];
        $Lugar = $datos['Lugar'];
        $Fecha = $datos['Fecha'];
        $HoraI = $datos['HoraI'];
        $HoraF = $datos['HoraF'];
        $Precio = $datos['Precio'];
        $Nivel = $datos['Nivel'];
        $Pista = $datos['Pista'];
    } else {
        throw new InvalidArgumentException();
    }

    //Inserto el Partido en la base de datos
    $stmt = $pdo->prepare("INSERT INTO partidos(Lugar,Fecha,HoraI,HoraF,Precio,Nivel,Pista) VALUES(:Lugar,:Fecha,:HoraI,:HoraF,:Precio,:Nivel,:Pista)");
    $stmt->execute(array("Lugar" => $Lugar, "Fecha" => $Fecha, "HoraI" => $HoraI, "HoraF" => $HoraF, "Precio" => $Precio, "Nivel" => $Nivel, "Pista" => $Pista));
    $IdPartido = $pdo->lastInsertId();
    echo $IdPartido;
    //Inserto el jugador al partido en la tabla relacional entre jugadores y partidos, como administrador siempre, ya que es el creador del partido.
    $stmt = $pdo->prepare("INSERT INTO partidos_usuarios(Id_partido,Id_usuario,Admin) VALUES(:IdPartido,:IdUsuario,1)");
    $stmt->execute(array("IdPartido" => $IdPartido, "IdUsuario" => $IdUsuario));
    //Envío código de validacion
    echo json_encode(array("Codigo" => 1, "Mensaje" => "Partido creado correctamente."));
} catch (PDOException $e) {
    echo json_encode(array("Codigo" => 107, "Mensaje" => "Error en la BASEDEDAT de datos." . $e));
} catch (InvalidArgumentException $e) {
    echo json_encode(array("Codigo" => 102, "Mensaje" => "Error en la obtención de datos."));
} catch (Exception $e) {
    echo json_encode(array("Codigo" => 191, "Mensaje" => "Error desconocido" . $e));
}
