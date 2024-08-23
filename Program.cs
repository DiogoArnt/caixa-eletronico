//Crie um programa que simule um caixa eletrônico, permitindo que o usuário escolha entre opções como "Consultar Saldo", "Sacar" e "Depositar". Use um switch para as opções e estruturas condicionais para validar as operações.
String operacao = "";
double saldo;
bool aberto = true;


Console.WriteLine("Bem vindo!! \n Diga qual o saldo  que deseja comecar");
saldo = Convert.ToDouble(Console.ReadLine());
while (aberto){
Console.WriteLine("Qual operação deseja efetuar? \n 1-Consultar saldo \n 2-Sacar \n 3-Depositar \n 4-Sair do programa");
operacao = Console.ReadLine();

switch (operacao)
{
    case "1":
        Console.WriteLine($"O seu saldo atual é de: {saldo}");
        break;

    case "2":
        double saque;
        
        Console.WriteLine("Diga o valor que voce deseja sacar:");
        saque = Convert.ToInt32(Console.ReadLine());

        if(saldo >= saque){
            saldo = saldo - saque;
            Console.WriteLine($"Saque realizado, o valor restante na sua conta eh de {saldo}");        
        }else {
            Console.WriteLine("Saldo insuficiente");
        }
        break;
        
    case "3":
        double deposito;

        Console.WriteLine("Digite o valor que deseja depositar:");
        deposito = Convert.ToDouble(Console.ReadLine());
        saldo = saldo + deposito;
        Console.WriteLine($"O valor do seu saldo atual é de: {saldo}"); 
        break;

    case "4":
        aberto = false;
        break;
}
}