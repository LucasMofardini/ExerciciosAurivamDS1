double salario, salAtualizado = 0;
            String continuar = "SIM";

            while (continuar.ToUpper() == "SIM")
            {
                Console.WriteLine("Digite seu salário");
                salario = int.Parse(Console.ReadLine());
                Console.Clear();


                while (salario < 0)
                {


                    Console.WriteLine("Salário nao é aceito");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Digite seu salário");
                    salario = int.Parse(Console.ReadLine());
                    Console.Clear();


                }
                if (salario <= 600)
                {
                    salAtualizado = salario + (salario * 30 / 100);
                }
                if ((salario > 600.01) && (salario < 1100.00))
                {
                    salAtualizado = salario + (salario * 25 / 100);
                }
                if ((salario > 1100.01) && (salario < 2400.00))
                {
                    salAtualizado = salario + (salario * 20 / 100);
                }
                if ((salario > 2400.01) && (salario < 3550.00))
                {
                    salAtualizado = salario + (salario * 15 / 100);
                }
                if (salario > 3550.00)
                {
                    salAtualizado = salario + (salario * 15 / 100);
                }

                Console.WriteLine("O salario corrigido  é : " + salAtualizado);
                Console.ReadKey();
                Console.WriteLine("Gostaria de continuar : SIM / NAO");

                continuar = Console.ReadLine();
                Console.Clear();
            }


            //feito por Lucas Mofardini
            //feito em c#
