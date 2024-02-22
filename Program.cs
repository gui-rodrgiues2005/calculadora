
float num1, num2, result;
 
Console.WriteLine(".......Primeiro projeto C#......\n\n");

    Console.Write("Digite o primeiro Número:");
    num1 = int.Parse(Console.ReadLine());
    Console.Write("Digite o Segundo Número:");
    num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Escolha sua opção..\n\n");
    Console.WriteLine("1- Soma");
    Console.WriteLine("2-Subtração");
    Console.WriteLine("3-Multipliacação");
    Console.WriteLine("4-Divisão");

    int operador = int.Parse(Console.ReadLine());

    switch(operador)
    {
        case 1:
            result = num1 + num2;
            Console.WriteLine("A soma é:" + result);
            break;
        
        case 2:
            result = num1 - num2;
            Console.WriteLine("A subtração é:" + result);
            break;
        
        case 3:
            result = num1 * num2;
            Console.WriteLine("A Multiplicação é:" + result);
            break;

        case 4:
            result = num1/num2;
            Console.WriteLine("A divisão é:" + result);
            break;

        default: 
            Console.Write("Opção Inválida!");
            break;          
    }

return; 





