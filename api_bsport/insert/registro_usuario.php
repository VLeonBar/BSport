<?php

require_once "../conexion.php";
require_once "../funciones.php";


$datos = $_POST;

try {
    //Compruebo que los datos que me llegan son strings y no vienen vacíos
    if (
        validaCadenas($datos) &&
        validaEmail($datos['Email'])
    ) {
        $Login = $datos['Login'];
        $Pass = $datos['Pass'];
        $Email = $datos['Email'];
        $Nombre = $datos['Nombre'];
    } else {
        throw new InvalidArgumentException();
    }

    //Compruebo si existe el Login y el Email antes de insertar
    if (!(exists($pdo, "usuarios", "Login", $Login) || exists($pdo, "usuarios", "Email", $Email))) {
        
        //Creo sentencia e inserto datos en tabla usuarios
        $stmt = $pdo->prepare("INSERT INTO usuarios(Login,Pass,Email,Token,Nombre) VALUES(:Login,:Pass,:Email,:Token,:Nombre);");
        $stmt->execute(array("Login" => $Login, "Pass" => $Pass, "Email" => $Email, "Token" => null, "Nombre" => $Nombre));

        //Envío código de validacion
        echo json_encode(array("Codigo" => 1, "Mensaje" => "Usuario registrado correctamente."));
    } else {

        if (exists($pdo, "usuarios", "Login", $datos["Login"]) && (exists($pdo, "usuarios", "Email", $datos["Email"]))){
            echo json_encode(array("Codigo" => 103, "Mensaje" => "Error ya existe una cuenta con esas credenciales."));
        }      

        else if (exists($pdo, "usuarios", "Login", $datos["Login"])) {
            echo json_encode(array("Codigo" => 104, "Mensaje" => "Error ya existe una cuenta con ese nombre."));
        }

        else if (exists($pdo, "usuarios", "Email", $datos["Email"])) {
            echo json_encode(array("Codigo" => 105, "Mensaje" => "Error ya existe una cuenta con ese Email."));
        }

    }
} catch (InvalidArgumentException $e) {
    echo json_encode(array("Codigo" => 102, "Mensaje" => "Error en la obtención de datos."));
} catch (Exception $e) {
    echo json_encode(array("Codigo" => 191, "Mensaje" => "Error desconocido" . $e));
}
