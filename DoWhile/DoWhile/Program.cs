//string entrada = "OK";
//int menorValor = int.MinValue;
//int maiorValor = int.MaxValue;

//do
//{
//    Console.WriteLine("Informe um número ou Ok para sair");
//    entrada = Console.ReadLine();

//    if (int.TryParse(entrada, out int numero)) {

//    } else
//    {
//        Console.WriteLine("O valor informado não é um número");
//    }
//} while (entrada != "OK");

//const string senha = "monster";

//do
//{
//    Console.WriteLine("Informe sua senha, por favor");
//    string senhaDigitada = Console.ReadLine();

//    if (senhaDigitada != senha )
//    {
//        Console.WriteLine("\nSenha informada não é valida, tente novamente");
//    }

//    Console.WriteLine("\nDigite a senha");
//    senhaDigitada = Console.ReadLine();

//} while (senha != "monster");

List<string> usuarios = new List<string>();
List<string> senhas = new List<string>(); 

do
{
    Console.WriteLine("Informe o nome de usuário");
    if (usuarios.Contains(Console.ReadLine()))
    {
        Console.WriteLine("Informe a senha");
        if (senhas.Contains(Console.ReadLine()))
        {
            Console.WriteLine("Login realizado com sucesso!");
        }
    } 

    Console.WriteLine("\nDigite a senha");
    senhaDigitada = Console.ReadLine();

} while (senha != "monster");