 String nome;
            double nota1, nota2, nota3, mediaFinal;

            Console.WriteLine("Digite seu nome : ");
            nome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite sua primeira nota : ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua segunda nota : ");
            nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua terceira nota : ");
            nota3 = double.Parse(Console.ReadLine());

            mediaFinal = (nota1 + nota2 + nota3) / 3;
            if (mediaFinal >= 7)
            {
                Console.Clear();
                Console.WriteLine(nome + ", você foi aprovado(a), sua nota é de " + mediaFinal);
            }
            else if (mediaFinal <= 5)
            {
                Console.Clear();
                Console.WriteLine(nome + ", você foi reprovado(a), sua nota é de " + mediaFinal);
            }
            else if (mediaFinal >= 5.1 && mediaFinal <= 6.9)
            {
                Console.Clear();
                Console.WriteLine(nome + ", você está de recuperação , sua nota é de " + mediaFinal);
            }
          
            Console.ReadKey();
