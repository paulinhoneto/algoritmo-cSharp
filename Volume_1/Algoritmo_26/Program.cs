﻿/*
 * Author  : Antônio Paulo Neto
 * File    : Program.cs
 * Project : Algoritmo_26
 * 
 * Faça um algoritmo que:
 * a) Leia o nome;
 * b) Leia o sobrenome;
 * c) Concatene o nome com o sobrenome;
 * d) Apresente o nome completo. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmo_26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * inicializa e declara as 
             * variáveis(espaço reservado na memória que tem um nome, um tamnho, uma valor e um tipo)
             */ 
            string nome      = "";
            string sobrenome = "";

            // exibe no console
            Console.Write("Digite um nome : ");
            nome = Console.ReadLine();   // lê nome 

            // exibe no console
            Console.Write("Digite um sobrenome : ");
            sobrenome = Console.ReadLine();   // lê sobrenome 

            // saída ou resultado
            Console.Write("Nome completo : " + nome + " " + sobrenome);

            //  espera entrada do teclado para encerrar o programa
            Console.ReadKey();
        }
    }
}
