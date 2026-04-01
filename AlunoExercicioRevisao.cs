namespace FundamentosAlgoritmia;
 
public class AlunoExercicioRevisao
{
 
  public void ExecutarExercicioRevisao()
  {
    Console.WriteLine("\n📘 EXERCÍCIOS GERAIS DE REVISÃO");
    Console.WriteLine("====================\n");
 
    // ===================================================
    // EXERCÍCIO 1: Verificar número positivo
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar uma variável número
    // Usar IF para verificar se é positivo ou negativo
    // Mostrar o resultado
 
    Console.WriteLine("📝 Exercício 1");
    Console.Write("Digite um número inteiro: ");
    // ler o numero introduzido e converter para inteiro
    string entrada = Console.ReadLine();
    int numero = Convert.ToInt32(entrada);

    // usar o IF...
    if (numero > 0)
        {
            // se for >o então é positivo
            Console.WriteLine("o numero é positivo");
        }
    else if (numero < 0)
        {
            // se for < 0 então é negativo
            Console.WriteLine("o numero é negativo");
        }
    else 
        {
           // se for zero
           Console.WriteLine("o numero é 0"); 
        }
    //SAIDA
 
             // Mantém o console aberto até uma tecla ser pressionada
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();

    /**� Exercício 1
     Número negativo ou zero*/
 
 
    // ===================================================
    // EXERCÍCIO 2: Maior de dois números
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar duas variáveis
    // Usar operador de comparação
    // Mostrar qual é maior
 
    Console.WriteLine("📝 Exercício 2");

   // solicitar os valores
    Console.WriteLine("introduza o primeiro numero");
    double numero1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("introduza o segundo numero");
    double numero2 = Convert.ToInt32(Console.ReadLine());

    if (numero1 > numero2)
    {
        Console.WriteLine($"o primeiro numero é maior {numero1} vs {numero2}");    
    }
    else if (numero1 < numero2)
    {
        Console.WriteLine($"o primeiro numero é menor {numero1} vs {numero2}");
    }
    else
        {
         Console.WriteLine($"os numeros são iguais");
        }
 
    //SAIDA
 
             // Mantém o console aberto até uma tecla ser pressionada
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();

    /**� Exercício 2
    10 é maior que 7*/
 
    // ===================================================
    // EXERCÍCIO 3: Sistema de desconto (operador ternário)
    // ===================================================
    // 👉 O QUE FAZER:
    // Se o valor da compra for maior que 100
    // aplicar desconto de 10%
    // Usar operador ternário
 
    Console.WriteLine("📝 Exercício 3");

    // solicitar o valor da compra
    Console.WriteLine("introduza o valor da compra");
    double valorcompra = Convert.ToInt32(Console.ReadLine());

    double valorfinal = (valorcompra >100) ? valorcompra*0.90: valorcompra ;

    Console.WriteLine($"Valor introduzido: {valorcompra}");
    Console.WriteLine($"Valor com desconto: {valorfinal}");


    //SAIDA

                // Mantém o console aberto até uma tecla ser pressionada
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();


    /**� Exercício 3
     Desconto: 12*/
 
    // ===================================================
    // EXERCÍCIO 4: Classificação de idade
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar variável idade
    // Usar IF/ELSE IF/ELSE:
    // < 12 → Criança
    // < 18 → Adolescente
    // >= 18 → Adulto
 
    Console.WriteLine("📝 Exercício 4");

    Console.WriteLine("introduza a idade");
    double idade = Convert.ToInt32(Console.ReadLine());


    if (idade < 12)
    {
        Console.WriteLine("é uma criança");    
    }
    else if (idade >12 && idade <18)
    {
        Console.WriteLine("é um adolescente");
    }
    else 
    {
        Console.WriteLine("é um adulto");
    }

    //SAIDA
        
                // Mantém o console aberto até uma tecla ser pressionada
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();


    /**� Exercício 4
    Adolescente*/
 
    // ===================================================
    // EXERCÍCIO 5: Menu com SWITCH
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar variável opção (int)
    // Usar SWITCH:
    // 1 → "Novo jogo"
    // 2 → "Carregar jogo"
    // 3 → "Sair"
 
    Console.WriteLine("📝 Exercício 5");

    // introduzir a opção
    Console.WriteLine("1. Novo Jogo");
    Console.WriteLine("2. Carregar Jogo");
    Console.WriteLine("3. Sair");
    Console.WriteLine();

    Console.Write("selecione a opção (1 a 3)\n");
    int opcao = Convert.ToInt32(Console.ReadLine());

    // usar o switch/case
    switch (opcao)
        {
            case 1:
                Console.WriteLine("1. Novo Jogo");
                break;
            case 2:
                Console.WriteLine("2. Carregar Jogo");
                break;
            case 3:
                Console.WriteLine("3. Sair");
                break;
            default:
                Console.WriteLine("Erro: Valor inválido");
                break;
        }


    //SAIDA

                // Mantém o console aberto até uma tecla ser pressionada
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();


    /**� Exercício 5
    Carregar jogo*/
 
    // ===================================================
    // EXERCÍCIO 6: Validação de acesso
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar:
    // idade >= 18
    // temConvite = true/false
    // Usar operadores lógicos
    // Mostrar se pode entrar
 
    Console.WriteLine("📝 Exercício 6");

        int idade2=16;
        bool temconvite=true;

        Console.WriteLine($"A idade é : {idade2}");
        Console.WriteLine($"Tem convite? {temconvite}");

        // validar acesso
        if (idade2 >=18 && temconvite == true)
            {
            Console.WriteLine("Tem permissão para entrar"); 
            }
        else if (idade2 >=18 && temconvite == false)
            {
            Console.WriteLine("Não tem convite para entrar"); 
            }
        else if (idade2 <18 && temconvite == true)
            {
            Console.WriteLine("Não tem idade para entrar"); 
            }
        else if (idade2 <18 && temconvite == false)
            {
            Console.WriteLine("Não tem idade nem convite para entrar"); 
            }
        //SAIDA

                // Mantém o console aberto até uma tecla ser pressionada
            Console.WriteLine("Pressione qualquer tecla para sair...\n");
            Console.ReadKey();

         // versao B
        Console.WriteLine("📝 Exercício 6 versão B");

        Console.Write("Introduza a idade\n");
        int idade3 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Tem convite ? (S ou N)\n");
        string temconvite2 = Console.ReadLine().ToUpper();

        // validar acesso
        if (idade3 >=18 && temconvite2 == "S")
            {
            Console.WriteLine("Tem permissão para entrar"); 
            }
        else if (idade3 >=18 && temconvite2 == "N")
            {
            Console.WriteLine("Não tem convite para entrar"); 
            }
        else if (idade3 <18 && temconvite2 == "S")
            {
            Console.WriteLine("Não tem idade para entrar"); 
            }
        else if (idade3 <18 && temconvite2 == "N")
            {
            Console.WriteLine("Não tem idade nem convite para entrar"); 
            }
        //SAIDA

                    // Mantém o console aberto até uma tecla ser pressionada
                Console.WriteLine("Pressione qualquer tecla para sair...\n");
                Console.ReadKey();


     


    /**� Exercício 6
    pode entrar? True*/
  }
 
}
 