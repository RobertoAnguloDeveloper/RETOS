num1 = int(input("Ingrese el primer numero: "))
num2 = int(input("Ingrese el segundo numero: "))

if(num1 > num2):
    print("El mayor es: ", num1)
    print("La diferencia entre el numero 1 y numero 2 es: ", num1 - num2)
elif(num1 == num2):
    print("Los numeros son iguales: ")
    print("La diferencia entre el numero 1 y numero 2 es: ", num1 - num2)
else:
    print("El mayor es: ", num2)
    print("La diferencia entre el numero 1 y numero 2 es: ", num2 - num1)