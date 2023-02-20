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
            Console.WriteLine("2 - Comparação                     ");
            Console.WriteLine("3 - Comparando Datas               ");
            Console.WriteLine("4 - CultureInfo                    ");
            Console.WriteLine("5 - DateTime                       ");
            Console.WriteLine("6 - Equals                         ");
            Console.WriteLine("7 - For                            ");
            Console.WriteLine("8 - Formatando Datas               ");
            Console.WriteLine("8 - Formatando Moeda               ");
            Console.WriteLine("9 - FormatDatas                    ");
            Console.WriteLine("10 - Guids                         ");
            Console.WriteLine("11 - Indices                       ");
            Console.WriteLine("12 - Interpolação                  ");
            Console.WriteLine("13 - Manipulando Strings           ");
            Console.WriteLine("13 - Math                          ");
            Console.WriteLine("14 - Métodos Adicionais            ");
            Console.WriteLine("15 - Métodos e Funções             ");
            Console.WriteLine("15 - Padrão de Formatação          ");
            Console.WriteLine("16 - Start Datas                   ");
            Console.WriteLine("17 - StartsWith/EndsWith           ");
            Console.WriteLine("18 - String Builder                ");
            Console.WriteLine("19 - Struct                        ");
            Console.WriteLine("20 - Switch                        ");
            Console.WriteLine("21 - Timespan                      ");
            Console.WriteLine("22 - Timezone                      ");
            Console.WriteLine("23 - Tipos para Moeda              ");
            Console.WriteLine("24 - Value Datas                   ");
            Console.WriteLine("25 - Value Types                   ");
            Console.WriteLine("26 - While/Do                      ");
            Console.WriteLine("27 - Sair                          ");
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
                    case "2": Comparacao.Show(); break;
                    case "3": ComparandoDatas.Show(); break;
                    case "4": CultureInfro.Show(); break;
                    case "5": MyDateTime.Show(); break;
                    case "6": Equales.Show(); break;
                    case "7": For.Show(); break;
                    case "8": FormatandoDatas.Show(); break;
                    case "9": FormatDatas.Show(); break;
                    case "10": Guids.Show(); break;
                    case "11": Indices.Show(); break;
                    case "12": Interpolacao.Show(); break;
                    case "13": ManipulandoStrings.Show(); break;
                    case "14": MetodosAdicionais.Show(); break;
                    case "15": MetodosFunctions.Show(); break;
                    case "16": StartDatas.Show(); break;
                    case "17": StartEnd.Show(); break;
                    case "18": StringBuilder.Show(); break;
                    case "19": Struct.Show(); break;
                    case "20": Switch.Show(); break;
                    case "21": Timespan.Show(); break;
                    case "22": Timezone.Show(); break;
                    case "23": TypeForCoin.Show(); break;
                    case "24": ValueDatas.Show(); break;
                    case "25": ValueTypes.Show(); break;
                    case "26": While.Show(); break;
                    case "27": System.Environment.Exit(0); break;
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