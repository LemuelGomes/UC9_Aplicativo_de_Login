string usuario = "";
string cadastro;
string senha = "";
string voltar = "S";
int i = 0;
int tentativas = 3;


while (voltar == "S" || voltar == "s")
{

    Console.WriteLine("****MENU****");
    Console.WriteLine("\nDigite [ 1 ] Para cadastrar seu Login");
    Console.WriteLine("\nDigite [ 2 ] para Testar ");
    Console.WriteLine("\nDigite [ 3 ] para Encerrar ");
    cadastro = Console.ReadLine();


    switch (cadastro)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Digite qualquer tecla para iniciar o cadastro! ");
            Console.ReadLine();

            Console.WriteLine("Crie seu Usuário: ");
            usuario = (Console.ReadLine());

            Console.WriteLine("Crie uma Senha para seu Login: ");
            senha = Console.ReadLine();
            break;


        case "2":
            Console.WriteLine("Digite 2 Para testar seu Login e Senha!. ");

            string usuario2 = "";
            string senha2 = "";
                     
                Console.WriteLine("Digite seu Usuário: ");
                usuario2 = Console.ReadLine();

                Console.WriteLine("Digite sua Senha");
                senha2 = Console.ReadLine();

            if (usuario2 == usuario && senha2 == senha)
            {
                Console.WriteLine("Login efetuado com Sucesso! ");
                tentativas = 0;
            }

            while (tentativas  > 0)
            {


                if (usuario2 != usuario && senha2 == senha)
                {
                    tentativas--;
                    Console.WriteLine("Usuário Incorreto! Tente novamente. Você possui  " + tentativas + " Tentativas");
                }

                if (usuario2 == usuario && senha2 != senha)
                {
                    tentativas--;
                    Console.WriteLine("Senha Incorreta! Tente novamente. Você possui  " + tentativas + " Tentativas");
                }

                if (usuario2 != usuario && senha2 != senha)
                {
                    tentativas--;
                    Console.WriteLine("Usuário e Senha Incorretos! Tente novamente. Você possui  " + tentativas + " Tentativas");
                }

            }
                break;

        case "3":           
            Console.WriteLine("Digite 3 para encerrar o Programa. ");
            Console.WriteLine("Obrigado por usar nosso programa de Login, :D ");
            break;

        default:
            Console.WriteLine("Opção Inválida!");
            break;
    }
        
        Console.Clear();
        Console.WriteLine("\nDeseja Voltar ao MENU inicial? 'S' ou 'N'? ");
        voltar = Console.ReadLine();
}