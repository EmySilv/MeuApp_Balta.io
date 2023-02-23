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
            Console.WriteLine("O que queres fazer?                ");
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("1 - Adicionando Valores            ");
            Console.WriteLine("2 - Alterando Valores              ");
            Console.WriteLine("3 - Array                          ");
            Console.WriteLine("4 - Comparação                     ");
            Console.WriteLine("5 - Comparando Datas               ");
            Console.WriteLine("6 - CultureInfo                    ");
            Console.WriteLine("7 - DateTime                       ");
            Console.WriteLine("8 - Equals                         ");
            Console.WriteLine("9 - For                            ");
            Console.WriteLine("10 - Foreach                       ");
            Console.WriteLine("11 - Formatando Datas              ");
            Console.WriteLine("12 - Formatando Moeda              ");
            Console.WriteLine("13 - FormatDatas                   ");
            Console.WriteLine("14 - Guids                         ");
            Console.WriteLine("15 - Indices                       ");
            Console.WriteLine("16 - Interpolação                  ");
            Console.WriteLine("17 - Manipulando Strings           ");
            Console.WriteLine("18 - Math                          ");
            Console.WriteLine("19 - Métodos Adicionais            ");
            Console.WriteLine("20 - Métodos e Funções             ");
            Console.WriteLine("21 - Padrão de Formatação          ");
            Console.WriteLine("22 - Percorrendo um Array          ");
            Console.WriteLine("23 - Start Datas                   ");
            Console.WriteLine("24 - StartsWith/EndsWith           ");
            Console.WriteLine("25 - String Builder                ");
            Console.WriteLine("26 - Struct                        ");
            Console.WriteLine("27 - Switch                        ");
            Console.WriteLine("28 - Timespan                      ");
            Console.WriteLine("29 - Timezone                      ");
            Console.WriteLine("30 - Tipos para Moeda              ");
            Console.WriteLine("31 - Value Datas                   ");
            Console.WriteLine("32 - Value Types                   ");
            Console.WriteLine("33 - While/Do                      ");
            Console.WriteLine("34 - Sair                          ");
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
                    case "2": AlterandoValue.Show(); break;
                    case "3": MyArrays.Show(); break;
                    case "4": Comparacao.Show(); break;
                    case "5": ComparandoDatas.Show(); break;
                    case "6": CultureInfro.Show(); break;
                    case "7": MyDateTime.Show(); break;
                    case "8": Equales.Show(); break;
                    case "9": For.Show(); break;
                    case "10": ForEacha.Show(); break;
                    case "11": FormatandoDatas.Show(); break;
                    case "12": FormatCoins.Show(); break;
                    case "13": FormatDatas.Show(); break;
                    case "14": Guids.Show(); break;
                    case "15": Indices.Show(); break;
                    case "16": Interpolacao.Show(); break;
                    case "17": ManipulandoStrings.Show(); break;
                    case "18": MyMath.Show(); break;
                    case "19": MetodosAdicionais.Show(); break;
                    case "20": MetodosFunctions.Show(); break;
                    case "21": PadraodeFormatacao.Show(); break;
                    case "22": PercorrendoArray.Show(); break;
                    case "23": StartDatas.Show(); break;
                    case "24": StartEnd.Show(); break;
                    case "25": StringBuilder.Show(); break;
                    case "26": Struct.Show(); break;
                    case "27": Switch.Show(); break;
                    case "28": Timespan.Show(); break;
                    case "29": Timezone.Show(); break;
                    case "30": TypeForCoin.Show(); break;
                    case "31": ValueDatas.Show(); break;
                    case "32": ValueTypes.Show(); break;
                    case "33": While.Show(); break;
                    case "34": System.Environment.Exit(0); break;
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