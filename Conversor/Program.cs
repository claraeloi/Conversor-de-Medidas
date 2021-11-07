using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*====================================================================================================================================================
  
  Função: Conversões de medidas, moedas e peso.
  Programador(a): Maria Clara Eloi da Silva
  Data: 25/05/2021
  
  ======================================================================================================================================================
 */
namespace Atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int op, medidas, moedas, peso, metricas, volumetricas, OpDolar, OpEuro;

            do
            {
                //Menu principal
                Console.WriteLine("╔════════════════════════════════════╗");
                Console.WriteLine("║             CONVERSORES            ║");
                Console.WriteLine("╟────────────────────────────────────║");
                Console.WriteLine("║   [1]       Conversor de Medidas   ║");
                Console.WriteLine("╟────────────────────────────────────║");
                Console.WriteLine("║   [2]       Conversor de Moedas    ║");
                Console.WriteLine("╟────────────────────────────────────║");
                Console.WriteLine("║   [3]        Conversor de Peso     ║");
                Console.WriteLine("╟────────────────────────────────────║");
                Console.WriteLine("║   [4]               Sair           ║");
                Console.WriteLine("╚════════════════════════════════════╝");

                //Entrada
                Console.Write("\nInforme qual conversor você deseja: ");
                op = int.Parse(Console.ReadLine());

                //Tratamento
                while (op < 1 || op > 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                    Console.ResetColor();
                    Console.Write("\nInforme qual conversor você deseja: ");
                    op = int.Parse(Console.ReadLine());
                }
                Console.Clear();
                //Switch opções do conversor
                switch (op)
                {
                    case 1:
                        do
                        {
                            //Menu do conversor de medidas
                            Console.WriteLine("╔════════════════════════════════════╗");
                            Console.WriteLine("║        CONVERSOR DE MEDIDAS        ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║   [1]           Métricas           ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║   [2]         Volumétricas         ║");
                            Console.WriteLine("╟────────────────────────────────────║");
                            Console.WriteLine("║   [3]    Voltar ao Menu Principal  ║");
                            Console.WriteLine("╚════════════════════════════════════╝");

                            //Entrada
                            Console.Write("\nInforme qual conversor de medidas você deseja: ");
                            medidas = int.Parse(Console.ReadLine());

                            //Tratamento
                            while (medidas < 1 || medidas > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                                Console.ResetColor();
                                Console.Write("\nInforme qual conversor de medidas você deseja: ");
                                medidas = int.Parse(Console.ReadLine());
                            }
                            Console.Clear();

                            //Switch opções do conversor de medidas
                            switch (medidas)
                            {
                                case 1:
                                    do
                                    {
                                        //Submenu do conversor métricas
                                        Console.WriteLine("╔════════════════════════════════════╗");
                                        Console.WriteLine("║              MÉTRICAS              ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║   [1]     Metro para Centímetro    ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║   [2]     Centímetro para Metro    ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║   [3]    Voltar ao Menu Principal  ║");
                                        Console.WriteLine("╚════════════════════════════════════╝");

                                        //Entrada
                                        Console.Write("\nDigite qual você deseja: ");
                                        metricas = int.Parse(Console.ReadLine());

                                        //Tratamento
                                        while (metricas < 1 || metricas > 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                                            Console.ResetColor();
                                            Console.Write("\nDigite qual você deseja: ");
                                            metricas = int.Parse(Console.ReadLine());
                                        }
                                        Console.Clear();

                                        //Switch opções do conversor métricas
                                        switch (metricas)
                                        {
                                            case 1:
                                                //Declaração de váriavéis
                                                double metros, centimetros;

                                                //Opção metro para centímetro
                                                Console.WriteLine("╔═════════════════════════════════════╗");
                                                Console.WriteLine("║        METRO PARA CENTÍMETRO        ║");
                                                Console.WriteLine("╚═════════════════════════════════════╝");

                                                //Entrada
                                                Console.Write("\nDigite o valor em metros: ");
                                                metros = double.Parse(Console.ReadLine());

                                                //Tratamento
                                                while (metros <= 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                                    Console.ResetColor();
                                                    Console.Write("\nDigite o valor em metros: ");
                                                    metros = double.Parse(Console.ReadLine());
                                                }

                                                //Processamento
                                                centimetros = metros * 100;

                                                //Saída
                                                Console.WriteLine("\n{0} metro(s) = {1} centimetro(s)\n", metros, centimetros);
                                                break;
                                            case 2:
                                                //Opção centímetro para metro
                                                Console.WriteLine("╔═════════════════════════════════════╗");
                                                Console.WriteLine("║        CENTÍMETRO PARA METRO        ║");
                                                Console.WriteLine("╚═════════════════════════════════════╝");

                                                //Entrada
                                                Console.Write("\nDigite o valor em centimetros: ");
                                                centimetros = double.Parse(Console.ReadLine());

                                                //Tratamento
                                                while (centimetros <= 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                                    Console.ResetColor();
                                                    Console.Write("\nDigite o valor em centimetros: ");
                                                    centimetros = double.Parse(Console.ReadLine());
                                                }

                                                //Processamento
                                                metros = centimetros / 100;

                                                //Saída
                                                Console.WriteLine("\n{0} centímetro(s) = {1} metro(s).\n", centimetros, metros);
                                                break;
                                        }

                                    }
                                    while (metricas != 3);
                                    break;
                                case 2:
                                    do
                                    {
                                        //Submenu do conversor volumétricas
                                        Console.WriteLine("╔════════════════════════════════════╗");
                                        Console.WriteLine("║            VOLUMÉTRICAS            ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║   [1]      Litro para Mililitro    ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║   [2]      Mililitro para Litro    ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║   [3]    Voltar ao Menu Principal  ║");
                                        Console.WriteLine("╚════════════════════════════════════╝");

                                        //Entrada
                                        Console.Write("\nDigite qual você deseja: ");
                                        volumetricas = int.Parse(Console.ReadLine());

                                        //Tratamento
                                        while (volumetricas < 1 || volumetricas > 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                                            Console.ResetColor();
                                            Console.Write("\nDigite qual você deseja: ");
                                            volumetricas = int.Parse(Console.ReadLine());
                                        }
                                        Console.Clear();
                                        //Switch opções do conversor volumétricas
                                        switch (volumetricas)
                                        {
                                            case 1:
                                                //Declaração de variáveis
                                                double litros, mililitros;

                                                //Opção litro para mililitro
                                                Console.WriteLine("╔════════════════════════════════════╗");
                                                Console.WriteLine("║        LITRO PARA MILILITRO        ║");
                                                Console.WriteLine("╚════════════════════════════════════╝");

                                                //Entrada
                                                Console.Write("\nDigite o valor em litros: ");
                                                litros = double.Parse(Console.ReadLine());

                                                //Tratamento
                                                while (litros <= 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                                    Console.ResetColor();
                                                    Console.Write("\nDigite o valor em litros: ");
                                                    litros = double.Parse(Console.ReadLine());
                                                }

                                                //Processamento
                                                mililitros = litros * 1000;

                                                //Saída
                                                Console.WriteLine("\n{0} litro(s) = {1} mililitro(s)\n", litros, mililitros);
                                                break;

                                            case 2:
                                                //Opção mililitro para litro
                                                Console.WriteLine("╔════════════════════════════════════╗");
                                                Console.WriteLine("║        MILILITRO PARA LITRO        ║");
                                                Console.WriteLine("╚════════════════════════════════════╝");

                                                //Entrada
                                                Console.Write("\nDigite o valor em mililitros: ");
                                                mililitros = double.Parse(Console.ReadLine());

                                                //Tratamento
                                                while (mililitros <= 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                                    Console.ResetColor();
                                                    Console.Write("\nDigite o valor em mililitros: ");
                                                    mililitros = double.Parse(Console.ReadLine());
                                                }

                                                //Processamento
                                                litros = mililitros / 1000;

                                                //Saída
                                                Console.WriteLine("\n{0} mililitro(s) = {1} litro(s)\n", mililitros, litros);
                                                break;
                                        }

                                    }
                                    while (volumetricas != 3);
                                    break;
                            }

                        }
                        while (medidas != 3);
                        break;
                    case 2:
                        do
                        {
                            //Menu do conversor de moedas
                            Console.WriteLine("╔═════════════════════════════════════╗");
                            Console.WriteLine("║         CONVERSOR DE MOEDAS         ║");
                            Console.WriteLine("╟─────────────────────────────────────║");
                            Console.WriteLine("║   [1]             Dólar             ║");
                            Console.WriteLine("╟─────────────────────────────────────║");
                            Console.WriteLine("║   [2]             Euro              ║");
                            Console.WriteLine("╟─────────────────────────────────────║");
                            Console.WriteLine("║   [3]    Voltar ao Menu Principal   ║");
                            Console.WriteLine("╚═════════════════════════════════════╝");

                            //Entrada
                            Console.Write("\nInforme qual conversor de moedas você deseja: ");
                            moedas = int.Parse(Console.ReadLine());

                            //Tratamento
                            while (moedas < 1 || moedas > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                                Console.ResetColor();
                                Console.Write("\nInforme qual conversor de moedas você deseja: ");
                                moedas = int.Parse(Console.ReadLine());
                            }
                            Console.Clear();

                            //Switch opções do conversor de moedas
                            switch (moedas)
                            {
                                case 1:
                                    do
                                    {
                                        //Submenu do conversor dólar
                                        Console.WriteLine("╔═════════════════════════════════════╗");
                                        Console.WriteLine("║                DÓLAR                ║");
                                        Console.WriteLine("╟─────────────────────────────────────║");
                                        Console.WriteLine("║   [1]         Dólar para Real       ║");
                                        Console.WriteLine("╟─────────────────────────────────────║");
                                        Console.WriteLine("║   [2]         Real para Dólar       ║");
                                        Console.WriteLine("╟─────────────────────────────────────║");
                                        Console.WriteLine("║   [3]    Voltar ao Menu Principal   ║");
                                        Console.WriteLine("╚═════════════════════════════════════╝");

                                        //Entrada
                                        Console.Write("\nDigite qual você deseja: ");
                                        OpDolar = int.Parse(Console.ReadLine());

                                        //Tratamento
                                        while (OpDolar < 1 || OpDolar > 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                                            Console.ResetColor();
                                            Console.Write("\nDigite qual você deseja: ");
                                            OpDolar = int.Parse(Console.ReadLine());
                                        }
                                        Console.Clear();

                                        //Switch opções do conversor dólar
                                        switch (OpDolar)
                                        {
                                            case 1:
                                                //Declaração de variáveis
                                                double dolar, cotacao, real;

                                                //Opção dólar para real
                                                Console.WriteLine("╔═════════════════════════════════════╗");
                                                Console.WriteLine("║           DÓLAR PARA REAL           ║");
                                                Console.WriteLine("╚═════════════════════════════════════╝");

                                                //Entrada
                                                Console.Write("\nDigite o valor em dólares: $");
                                                dolar = double.Parse(Console.ReadLine());
                                                Console.Write("Digite o valor da cotação do dólar: ");
                                                cotacao = double.Parse(Console.ReadLine());

                                                //Tratamento
                                                while (dolar <= 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                                    Console.ResetColor();
                                                    Console.Write("\nDigite o valor em dólares: $");
                                                    dolar = double.Parse(Console.ReadLine());
                                                    Console.Write("Digite o valor da cotação do dólar: ");
                                                    cotacao = double.Parse(Console.ReadLine());
                                                }

                                                //Processamento
                                                real = dolar * cotacao;

                                                //Saída
                                                Console.WriteLine("\n${0:F2} dólares = R${1:F2} reais\n", dolar, real);
                                                break;

                                            case 2:
                                                //Opção real para dólar
                                                Console.WriteLine("╔═════════════════════════════════════╗");
                                                Console.WriteLine("║           REAL PARA DÓLAR           ║");
                                                Console.WriteLine("╚═════════════════════════════════════╝");

                                                //Entrada
                                                Console.Write("\nDigite o valor em reais: R$");
                                                real = double.Parse(Console.ReadLine());
                                                Console.Write("Digite o valor da cotação do dólar: ");
                                                cotacao = double.Parse(Console.ReadLine());

                                                //Tratamento
                                                while (real <= 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                                    Console.ResetColor();
                                                    Console.Write("\nDigite o valor em reais: R$");
                                                    real = double.Parse(Console.ReadLine());
                                                    Console.Write("Digite o valor da cotação do dólar: ");
                                                    cotacao = double.Parse(Console.ReadLine());
                                                }

                                                //Processamento
                                                dolar = real / cotacao;

                                                //Saída
                                                Console.WriteLine("\nR${0:f2} reais = ${1:f2} dólares\n", real, dolar);
                                                break;
                                        }

                                    }
                                    while (OpDolar != 3);
                                    break;

                                case 2:
                                    do
                                    {
                                        //Submenu do conversor euro
                                        Console.WriteLine("╔════════════════════════════════════╗");
                                        Console.WriteLine("║                EURO                ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║   [1]         Euro para Real       ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║   [2]         Real para Euro       ║");
                                        Console.WriteLine("╟────────────────────────────────────║");
                                        Console.WriteLine("║   [3]    Voltar ao Menu Principal  ║");
                                        Console.WriteLine("╚════════════════════════════════════╝");

                                        //Entrada
                                        Console.Write("\nDigite qual você deseja: ");
                                        OpEuro = int.Parse(Console.ReadLine());

                                        //Tratamento
                                        while (OpEuro < 1 || OpEuro > 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.DarkRed;
                                            Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                                            Console.ResetColor();
                                            Console.Write("\nDigite qual você deseja: ");
                                            OpEuro = int.Parse(Console.ReadLine());
                                        }
                                        Console.Clear();

                                        //Switch opções do conversor euro
                                        switch (OpEuro)
                                        {
                                            case 1:
                                                //Declaração de variáveis
                                                double euro, cotacao, real;

                                                //Opção euro para real
                                                Console.WriteLine("╔══════════════════════════════════════╗");
                                                Console.WriteLine("║            EURO PARA REAL            ║");
                                                Console.WriteLine("╚══════════════════════════════════════╝");

                                                //Entrada
                                                Console.Write("\nDigite o valor em euros: €");
                                                euro = double.Parse(Console.ReadLine());
                                                Console.Write("Digite o valor da cotação do euro: ");
                                                cotacao = double.Parse(Console.ReadLine());

                                                //Tratamento
                                                while (euro <= 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                                    Console.ResetColor();
                                                    Console.Write("\nDigite o valor em euros: €");
                                                    euro = double.Parse(Console.ReadLine());
                                                    Console.Write("Digite o valor da cotação do euro: ");
                                                    cotacao = double.Parse(Console.ReadLine());
                                                }

                                                //Processamento
                                                real = euro * cotacao;

                                                //Saída
                                                Console.WriteLine("\n€{0:f2} euros = R${1:f2} reais\n", euro, real);
                                                break;

                                            case 2:
                                                //Opção real para euro
                                                Console.WriteLine("╔══════════════════════════════════════╗");
                                                Console.WriteLine("║            REAL PARA EURO            ║");
                                                Console.WriteLine("╚══════════════════════════════════════╝");

                                                //Entrada
                                                Console.Write("\nDigite o valor em reais: R$");
                                                real = double.Parse(Console.ReadLine());
                                                Console.Write("Digite o valor da cotação do euro: ");
                                                cotacao = double.Parse(Console.ReadLine());

                                                //Tratamento
                                                while (real <= 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.DarkRed;
                                                    Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                                    Console.ResetColor();
                                                    Console.Write("\nDigite o valor em reais: R$");
                                                    real = double.Parse(Console.ReadLine());
                                                    Console.Write("Digite o valor da cotação do euro: ");
                                                    cotacao = double.Parse(Console.ReadLine());
                                                }

                                                //Processamento
                                                euro = real / cotacao;

                                                //Saída
                                                Console.WriteLine("\nR${0:f2} reais = €{1:f2} euros\n", real, euro);
                                                break;
                                        }

                                    }
                                    while (OpEuro != 3);
                                    break;
                            }

                        }
                        while (moedas != 3);
                        break;

                    case 3:
                        do
                        {
                            //Menu do conversor de peso
                            Console.WriteLine("╔═════════════════════════════════════╗");
                            Console.WriteLine("║          CONVERSOR DE PESO          ║");
                            Console.WriteLine("╟─────────────────────────────────────║");
                            Console.WriteLine("║   [1]         Quilo para Grama      ║");
                            Console.WriteLine("╟─────────────────────────────────────║");
                            Console.WriteLine("║   [2]         Grama para Quilo      ║");
                            Console.WriteLine("╟─────────────────────────────────────║");
                            Console.WriteLine("║   [3]     Voltar ao Menu Principal  ║");
                            Console.WriteLine("╚═════════════════════════════════════╝");

                            //Entrada
                            Console.Write("\nInforme qual conversor de peso você deseja: ");
                            peso = int.Parse(Console.ReadLine());

                            //Tratamento
                            while (peso < 1 || peso > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("\n\nOpção inválida. Tente novamente.");
                                Console.ResetColor();
                                Console.Write("\nInforme qual conversor de peso você deseja: ");
                                peso = int.Parse(Console.ReadLine());
                            }
                            Console.Clear();

                            //Switch opções do conversor peso
                            switch (peso)
                            {
                                case 1:
                                    //Declaração de variáveis
                                    double quilo, grama;

                                    //Opção quilo para grama
                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                    Console.WriteLine("║           QUILO PARA GRAMA          ║");
                                    Console.WriteLine("╚═════════════════════════════════════╝");

                                    //Entrada
                                    Console.Write("\nDigite o valor em quilos: ");
                                    quilo = double.Parse(Console.ReadLine());

                                    //Tratamento
                                    while (quilo <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                        Console.ResetColor();
                                        Console.Write("\nDigite o valor em quilos: ");
                                        quilo = double.Parse(Console.ReadLine());
                                    }

                                    //Processamento
                                    grama = quilo * 1000;

                                    //Saída
                                    Console.WriteLine("\n{0} quilo(s) = {1} grama(s)\n", quilo, grama);
                                    break;

                                case 2:
                                    //Opção grama para quilo
                                    Console.WriteLine("╔═════════════════════════════════════╗");
                                    Console.WriteLine("║           GRAMA PARA QUILO          ║");
                                    Console.WriteLine("╚═════════════════════════════════════╝");

                                    //Entrada
                                    Console.Write("\nDigite o valor em gramas: ");
                                    grama = double.Parse(Console.ReadLine());

                                    //Tratamento
                                    while (grama <= 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine("\n\nValor inválido. Tente novamente.");
                                        Console.ResetColor();
                                        Console.Write("\nDigite o valor em gramas: ");
                                        grama = double.Parse(Console.ReadLine());
                                    }

                                    //Processamento
                                    quilo = grama / 1000;

                                    //Saída
                                    Console.WriteLine("\n{0} grama(s) = {1} quilo(s)\n", grama, quilo);
                                    break;
                            }

                        }
                        while (peso != 3);
                        break;
                }
            }
            while (op != 4);

            //Saída do programa
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║     OBRIGADO POR USAR NOSSO CONVERSOR!     ║");
            Console.WriteLine("║      APERTE QUALQUER TECLA PARA SAIR.      ║");
            Console.WriteLine("╚════════════════════════════════════════════╝\n");

            Console.WriteLine("          ▐▓█▀▀▀▀▀▀▀▀▀█▓▌░▄▄▄▄▄░");
            Console.WriteLine("          ▐▓█░░▀░░▀▄░░█▓▌░█▄▄▄█░");
            Console.WriteLine("          ▐▓█░░▄░░▄▀░░█▓▌░█▄▄▄█░");
            Console.WriteLine("          ▐▓█▄▄▄▄▄▄▄▄▄█▓▌░█████░");
            Console.WriteLine("          ░░░░▄▄███▄▄░░░░░█████░");

            Console.ReadKey();
        }
    }
}