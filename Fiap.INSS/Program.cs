using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.INSS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Seja bem vindo!\nDigite seu usuario:");
                string user = Console.ReadLine();

                Console.WriteLine("Digite sua senha:");
                string senha = Console.ReadLine();

                if (user == "rm99919@fiap.com.br" && senha == "99919"){

                    Console.WriteLine("escreva seu Gênero: (F/M)");
                    string gen = Console.ReadLine();

                    Console.WriteLine("Digite sua idade:");
                    int idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite seu tempo de contribuição?");
                    int temp = int.Parse(Console.ReadLine());

                    if (gen == "F")
                    {
                        if (idade >= 62 && temp >= 15)
                        {
                            Console.WriteLine("Já pode se aposentar! Os requisitos minimos são 65 anos de idade e 20 de contribuição");
                        }
                        else { Console.WriteLine("Ainda não pode se aposentar! Os requisitos minimos são 65 anos de idade e 20 de contribuição"); }
                    }
                    else if (gen == "M") {
                        if (idade >= 65 && temp > 20)
                        {
                            Console.WriteLine("Já pode se aposentar! Os requisitos minimos são 65 anos de idade e 20 de contribuição");
                        }
                        else { Console.WriteLine("Ainda não pode se aposentar! Os requisitos minimos são 65 anos de idade e 20 de contribuição"); }

                    }else
                    {
                        Console.WriteLine("Gênero incorreto!");
                    }

                }
                else{
                    Console.Write("Usuario/Senha incorretos");
                }

            } catch (Exception ex) {

                Console.WriteLine(ex.Message);
            }
         Console.ReadKey();
        }
    }
}
