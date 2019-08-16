using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Criptografia
    {
        //Criptografa e descriptografa
        public static string Criptografa(char[] texto, int codigo, int opcao)
        {
            string textoRetorno = null;
            //Matriz da criptografia
            char[,] criptografia = {{ 'a', '#', 'g', 'g', 'Z', 'Q', '2', 'Z', ',', 'P', 'm'},
                                    { 'b', '0', 't', 'q', 'A', 'w', '3', '0', '.', 'o', 'M' },
                                    { 'c', 'q', '.', 'w', 'q', 'e', '$', '9', 'G', 'I', 'n' },
                                    { 'd', '@', ',', 'e', 'C', 'R', '%', '8', 'F', 'U', 'b' },
                                    { 'e', 'z', '@', 'r', 'd', 'T', 'p', '&', 'D', 'Y', 'v' },
                                    { 'f', 'w', '&', 't', 'E', 'y', 'L', '#', 'E', 't', 'c' },
                                    { 'g', '+', 'e', 'y', 'v', 'Y', 'm', '$', 'T', 'R', 'X' },
                                    { 'h', 'c', '9', 'u', 'F', 'u', 'O', '1', 'Y', 'e', 'x' },
                                    { 'i', 'D', '7', 'i', 'r', 'U', 'j', '2', 'u', 'W', 'z' },
                                    { 'j', 'E', '/', 'o', 'g', 'i', 'N', '3', 'i', 'w', 'Z' },
                                    { 'k', 'm', ']', 'p', 'b', 'I', 'b', 'u', 'o', 'Q', 'l' },
                                    { 'l', 'x', '(', '[', 't', 'O', 'H', 'y', 'p', 'q', 'k' },
                                    { 'm', 'p', '#', ']', 'y', 'P', 'I', 'Y', 'a', 'a', '1' },
                                    { 'n', '3', 'v', '!', 'H', 'A', 'u', 'r', 'q', 's', '2' },
                                    { 'o', '4', 'y', '@', 'h', 'S', 'g', 'e', 'w', 'd', '3' },
                                    { 'p', 'h', 'w', '#', 'j', 'D', 'v', 'w', 'E', 'f', '0' },
                                    { 'q', 'A', 'z', '$', 'u', 'G', 'f', 'W', 'C', 'H', 'H' },
                                    { 'r', 'f', '1', '%', 'U', 'H', 't', 'E', 'G', 'j', 'g' },
                                    { 's', 'o', '5', '&', 'l', 'J', 'R', 'R', 'H', 'h', 'F' },
                                    { 't', '7', 's', '*', 'i', 'k', 'D', 'L', 'J', 'K', 'D' },
                                    { 'u', '!', 'd', '(', 'o', 'l', 'X', 'K', 'K', 'k', 's' },
                                    { 'v', 'i', 'f', ')', 'p', 'z', 'Z', 'J', 'L', 'l', 'a' },
                                    { 'w', 'R', 'x', '_', '3', 'x', 's', 'h', 'O', 'L', 't' },
                                    { 'x', '&', 'h', '-', '4', 'c', 'r', 'a', '@', '6', 'r' },
                                    { 'y', 'k', '>', 'z', '#', 'v', 'E', 's', '!', '4', 'e' },
                                    { 'z', 't', 'a', 'x', '!', 'b', '&', 'd', '(', '*', 'w' },
                                    { ' ', ']', ';', 'c', 'M', 'n', '*', 'f', 'V', '%', 'q' },
                                    { 'ç', '[', ':', 'n', 'P', 'm', '7', 'G', 'N', '0', 'i' },
                                    { '0', 'M', '1', 'W', '9', '1', '9', '1', '1', '1', '!' },
                                    { '1', 'S', 'A', 'U', '8', '!', '0', '2', '3', '2', '@' },
                                    { '2', 'J', 'S', 'I', '6', '2', '#', '3', '2', '3', '#' },
                                    { '3', 'K', 'F', 'O', '5', '@', '$', '4', '4', '4', '$' },
                                    { '4', 'L', 'G', 'P', '4', '#', '@', '5', '6', '5', '%' },
                                    { '5', 'G', 'H', 'Ç', '3', '$', '%', '6', '5', '$', 'B' },
                                    { '6', 'F', 'K', 'K', '2', '4', '&', '%', '8', '#', 'V' },
                                    { '7', 'T', 'I', 'J', '1', '5', '(', '[', '7', '(', '1' },
                                    { '8', 'Y', 'Y', 'H', '0', '6', ')', ']', '#', ']', '2' },
                                    { '9', 'U', 'T', 'V', ':', '7', ':', ':', '%', ',', '3' },
                                    };

            // criptografa
            if (opcao == 1)
            {
                for (int count = 0; count < texto.Length; count++)
                {
                    for (int count2 = 0; count2 < criptografia.GetLongLength(0); count2++)
                    {
                        if (texto[count] == criptografia[count2, 0])
                        {
                            textoRetorno = textoRetorno + criptografia[count2, codigo];
                        }
                    }
                }
            }

            //Descriptografa
            if (opcao == 3)
            {
                for (int count = 0; count < texto.Length; count++)
                {
                    for (int count2 = 0; count2 < criptografia.GetLongLength(0); count2++)
                    {
                        if (texto[count] == criptografia[count2, codigo])
                        {
                            textoRetorno = textoRetorno + criptografia[count2, 0];
                        }
                    }
                }
            }
            return textoRetorno;
        }
        //Criptografa um texto
        public static string Opcao1(string texto, int codigo)
        {
            int opcao = 1;
            char[] textoParaCriptografar = texto.ToCharArray();
            string textoCriptografado;
            textoCriptografado = Criptografa(textoParaCriptografar, codigo, opcao);
            return textoCriptografado;
        }

        // criptografa e escreve em um arquivo .txt
        public static string Opcao2(string texto, string caminhoTXT, int codigo)
        {
            int opcao = 1;
            char[] textoParaCriptografar = texto.ToCharArray();
            string textoCriptografado;
            textoCriptografado = Criptografa(textoParaCriptografar, codigo, opcao);
            System.IO.File.WriteAllText(@caminhoTXT, $"Texto criptografado: " +
                                                     $"{textoCriptografado} " +
                                                     $"- Chave para descriptografar: {codigo}");
            return textoCriptografado;
        }

        //Descriptografa um texto 
        public static string Opcao3(string texto, int codigo)
        {
            int opcao = 3;
            char[] textoParaDescriptografar = texto.ToCharArray();
            string textoDescriptografado;
            textoDescriptografado = Criptografa(textoParaDescriptografar, codigo, opcao);
            return textoDescriptografado;
        }

        //Descriptografa um texto que está em um arquivo txt
        public static string Opcao4(string texto, int codigo)
        {
            int opcao = 3;
            char[] textoParaDescriptografar = texto.ToCharArray();
            string textoDescriptografado;
            textoDescriptografado = Criptografa(textoParaDescriptografar, codigo, opcao);
            return textoDescriptografado;
        }

        //Remove acentos
        public static string RemoverAcentuacao(string text)
        {
            return new string(text
                .Normalize(NormalizationForm.FormD)
                .Where(ch => char.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                .ToArray());
        }
    }
}
