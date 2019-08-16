using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ConsoleApp1;

namespace Main
{
    class Menu
    {

        static void Main(string[] args)
        {
            string menu = "0", texto, text, caminhoTXT;
            int codigo = 0;
            Random random = new Random();
            Regex rx1 = new Regex(@"[:].*[-]", RegexOptions.Compiled);
            Regex rx2 = new Regex(@"[r][:] .*", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            while (menu != "5")
            {
                //Menu de seleção
                Console.Clear();
                Console.WriteLine("|--------------------------------------------------------|");
                Console.WriteLine("|    CRIPTOGRAFAR E DESCRIPTOGRAFAR                      |");
                Console.WriteLine("|                                                        |");
                Console.WriteLine("|    1- Criptografar texto                               |");
                Console.WriteLine("|    2- Criptografar texto e salvar em arquivo .txt      |");
                Console.WriteLine("|    3- Descriptografar texto                            |");
                Console.WriteLine("|    4- Descriptografar texto de um arquivo .txt         |");
                Console.WriteLine("|    5- Sair                                             |");
                Console.WriteLine("|--------------------------------------------------------|");
                Console.Write("     Digite o número da opção desejada: ");
                menu = Console.ReadLine();

                switch (menu)
                {
                    //Criptografar texto
                    case "1":
                        Console.Clear();
                        Console.Write("Digite o texto a ser criptografado: ");
                        texto = Console.ReadLine();
                        texto = texto.ToLower();
                        texto = Criptografia.RemoverAcentuacao(texto);
                        codigo = random.Next(1, 11);
                        text = Criptografia.Opcao1(texto, codigo);
                        Console.Clear();
                        Console.WriteLine("Texto criptografado: " + text);
                        Console.WriteLine("\nCódigo para descriptografar: " + codigo);
                        Console.WriteLine("\nDigite qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    //Criptografar texto e salvar em arquivo .txt
                    case "2":
                        Console.Clear();
                        Console.Write("Digite o texto a ser criptografado: ");
                        texto = Console.ReadLine();
                        Console.Write("Digite um nome para o arquivo: ");
                        caminhoTXT = $"C:\\Users\\Public\\{Console.ReadLine()}.txt";
                        texto = Criptografia.RemoverAcentuacao(texto.ToLower());
                        codigo = random.Next(1, 11);
                        text = Criptografia.Opcao2(texto, caminhoTXT, codigo);
                        Console.Clear();
                        Console.WriteLine($"Texto Criptografado: {text} \n\nChave da criptografia: {codigo} \n\nCaminho do arquivo: {caminhoTXT}");
                        Console.WriteLine("\nDigite qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    //Descriptografar texto
                    case "3":
                        Console.Clear();
                        Console.Write("Digite o texto criptografado: ");
                        texto = Console.ReadLine();
                        Console.Write("Digite a chave para descriptografar: ");
                        codigo = Convert.ToInt32(Console.ReadLine());
                        text = Criptografia.Opcao3(texto, codigo);
                        Console.Clear();
                        Console.WriteLine("Texto descriptografado: " + text);
                        Console.WriteLine("\nDigite qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    //Descriptografar texto de um arquivo .txt 
                    case "4":
                        Console.Clear();
                        Console.Write("Digite o nome do arquivo que contém o texto criptografado: ");
                        caminhoTXT = $"C:\\Users\\Public\\{Console.ReadLine()}.txt";
                        texto = System.IO.File.ReadAllText(caminhoTXT);
                        MatchCollection matches2 = rx2.Matches(texto);
                        foreach (Match match in matches2)
                            codigo = Convert.ToInt32(match.Value.Replace("r:", ""));
                        MatchCollection matches1 = rx1.Matches(texto);
                        foreach (Match match in matches1)
                            texto = match.Value.Replace(":", "");
                        texto = texto.Replace("C", "");
                        text = Criptografia.Opcao3(texto, codigo);
                        Console.Clear();
                        Console.WriteLine("Texto descriptografado: " + text);
                        Console.WriteLine("\nDigite qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    //Sair
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Encerrando...");
                        Console.WriteLine("\nDigite qualquer tecla para continuar.");
                        Console.ReadKey();
                        break;

                    //Caso nenhum tenha sido selecionado
                    default:
                        Console.Clear();
                        Console.WriteLine("Opção invalida");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
