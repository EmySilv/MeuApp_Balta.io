using System;

namespace MeuApp
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("O que você queres fazer?           ");
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1 - Adicionando Valores            ");
            Console.WriteLine("2 - Array                          ");
            Console.WriteLine("3 - Comparação                     ");
            Console.WriteLine("4 - Comparando Datas               ");
            Console.WriteLine("5 - CultureInfo                    ");
            Console.WriteLine("6 - DateTime                       ");
            Console.WriteLine("7 - Equals                         ");
            Console.WriteLine("8 - For                            ");
            Console.WriteLine("9 - Formatando Datas               ");
            Console.WriteLine("10 - Formatando Moeda              ");
            Console.WriteLine("11 - FormatDatas                   ");
            Console.WriteLine("12 - Guids                         ");
            Console.WriteLine("13 - Indices                       ");
            Console.WriteLine("14 - Interpolação                  ");
            Console.WriteLine("15 - Manipulando Strings           ");
            Console.WriteLine("16 - Math                          ");
            Console.WriteLine("17 - Métodos Adicionais            ");
            Console.WriteLine("18 - Métodos e Funções             ");
            Console.WriteLine("19 - Padrão de Formatação          ");
            Console.WriteLine("20 - Percorrendo um Array          ");
            Console.WriteLine("21 - Start Datas                   ");
            Console.WriteLine("22 - StartsWith/EndsWith           ");
            Console.WriteLine("23 - String Builder                ");
            Console.WriteLine("24 - Struct                        ");
            Console.WriteLine("25 - Switch                        ");
            Console.WriteLine("26 - Timespan                      ");
            Console.WriteLine("27 - Timezone                      ");
            Console.WriteLine("28 - Tipos para Moeda              ");
            Console.WriteLine("29 - Value Datas                   ");
            Console.WriteLine("30 - Value Types                   ");
            Console.WriteLine("31 - While/Do                      ");
            Console.WriteLine("32 - Sair                          ");
            Console.WriteLine("===================================");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Selecione uma opção:             ");

            Console.ForegroundColor = ConsoleColor.Red;
            string option = Console.ReadLine()!;
            Console.ResetColor();

            try
            {
                switch (option)
                {
                    case "1": AdicionadoValores.Show(); break;
                    case "2": MyArrays.Show(); break;
                    case "3": Comparacao.Show(); break;
                    case "4": ComparandoDatas.Show(); break;
                    case "5": CultureInfro.Show(); break;
                    case "6": MyDateTime.Show(); break;
                    case "7": Equales.Show(); break;
                    case "8": For.Show(); break;
                    case "9": FormatandoDatas.Show(); break;
                    case "10": FormatCoins.Show(); break;
                    case "11": FormatDatas.Show(); break;
                    case "12": Guids.Show(); break;
                    case "13": Indices.Show(); break;
                    case "14": Interpolacao.Show(); break;
                    case "15": ManipulandoStrings.Show(); break;
                    case "16": MyMath.Show(); break;
                    case "17": MetodosAdicionais.Show(); break;
                    case "18": MetodosFunctions.Show(); break;
                    case "19": PadraodeFormatacao.Show(); break;
                    case "20": PercorrendoArray.Show(); break;
                    case "21": StartDatas.Show(); break;
                    case "22": StartEnd.Show(); break;
                    case "23": StringBuilder.Show(); break;
                    case "24": Struct.Show(); break;
                    case "25": Switch.Show(); break;
                    case "26": Timespan.Show(); break;
                    case "27": Timezone.Show(); break;
                    case "28": TypeForCoin.Show(); break;
                    case "29": ValueDatas.Show(); break;
                    case "30": ValueTypes.Show(); break;
                    case "31": While.Show(); break;
                    case "32": System.Environment.Exit(0); break;
                    default: Menu.Show(); break;

                }

            }
            catch (System.Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNão foi possível fazer a operação.");
                Console.WriteLine("Dica: Use os caracteres representados nas opções.");

                Console.ResetColor();
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu.");


                Console.ReadKey();
                Menu.Show();
            }
        }
    }
}