<?php
    $num1 = readline ("Digite el primer numero: ");
    $num2 = readline ("Digite el segundo numero: ");

    if($num1 > $num2){
        echo "El mayor es: $num1 \n";
        echo "La diferencia entre el numero 1 y el numero 2 es: " . ($num1 - $num2);
    }else if($num1 == $num2){
        echo "Los numeros son iguales";
    }else{
        echo "El mayor es: $num2 \n";
        echo "La diferencia entre el numero 1 y el numero 2 es: " . ($num2 - $num1);
    }
?>