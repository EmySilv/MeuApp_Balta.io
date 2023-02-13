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
            Console.WriteLine("5 - Equals                         ");
            Console.WriteLine("6 - For                            ");
            Console.WriteLine("7 - Formatando Datas               ");
            Console.WriteLine("8 - FormatDatas                    ");
            Console.WriteLine("9 - Guids                          ");
            Console.WriteLine("10 - Indices                       ");
            Console.WriteLine("11 - Interpolação                  ");
            Console.WriteLine("12 - Manipulando Strings           ");
            Console.WriteLine("13 - Métodos Adicionais            ");
            Console.WriteLine("14 - Métodos e Funções             ");
            Console.WriteLine("15 - Start Datas                   ");
            Console.WriteLine("16 - StartsWith/EndsWith           ");
            Console.WriteLine("17 - String Builder                ");
            Console.WriteLine("18 - Struct                        ");
            Console.WriteLine("19 - Switch                        ");
            Console.WriteLine("20 - Timespan                      ");
            Console.WriteLine("21 - Timezone                      ");
            Console.WriteLine("22 - Value Datas                   ");
            Console.WriteLine("23 - Value Types                   ");
            Console.WriteLine("24 - While/Do                      ");
            Console.WriteLine("25 - Sair                          ");
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
                    case "5": Equales.Show(); break;
                    case "6": For.Show(); break;
                    case "7": FormatandoDatas.Show(); break;
                    case "8": FormatDatas.Show(); break;
                    case "9": Guids.Show(); break;
                    case "10": Indices.Show(); break;
                    case "11": Interpolacao.Show(); break;
                    case "12": ManipulandoStrings.Show(); break;
                    case "13": MetodosAdicionais.Show(); break;
                    case "14": MetodosFunctions.Show(); break;
                    case "15": StartDatas.Show(); break;
                    case "16": StartEnd.Show(); break;
                    case "17": StringBuilder.Show(); break;
                    case "18": Struct.Show(); break;
                    case "19": Switch.Show(); break;
                    case "20": Timespan.Show(); break;
                    case "21": Timezone.Show(); break;
                    case "22": ValueDatas.Show(); break;
                    case "23": ValueTypes.Show(); break;
                    case "24": While.Show(); break;
                    case "25": System.Environment.Exit(0); break;
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