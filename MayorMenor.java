import java.util.Scanner;

public class MayorMenor{
    public static void main(String[] args){
        Scanner keyboard = new Scanner(System.in);

        System.out.println("Ingrese el primer numero");
        int num1 = keyboard.nextInt();

        System.out.println("Ingrese el segundo numero");
        int num2 = keyboard.nextInt();

        keyboard.close();

        if(num1 > num2){
            System.out.println("El numero mayor es: " + num1 + " y la diferencia entre ambos es: " + (num1 - num2));
        }else if(num1 == num2){
            System.out.println("Los numeros son iguales y la diferencia entre ambos es: 0");
        }else{
            System.out.println("El numero mayor es: " + num2 + " y la diferencia entre ambos es: " + (num2 - num1));
        }
    }
}