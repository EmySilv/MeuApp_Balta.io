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
            Console.WriteLine("9 - Exceptions(É só um erro)       ");
            Console.WriteLine("10 - For                           ");
            Console.WriteLine("11 - Foreach                       ");
            Console.WriteLine("12 - Formatando Datas              ");
            Console.WriteLine("13 - Formatando Moeda              ");
            Console.WriteLine("14 - FormatDatas                   ");
            Console.WriteLine("15 - Guids                         ");
            Console.WriteLine("16 - Indices                       ");
            Console.WriteLine("17 - Interpolação                  ");
            Console.WriteLine("18 - Manipulando Strings           ");
            Console.WriteLine("19 - Math                          ");
            Console.WriteLine("20 - Métodos Adicionais            ");
            Console.WriteLine("21 - Métodos e Funções             ");
            Console.WriteLine("22 - Padrão de Formatação          ");
            Console.WriteLine("23 - Percorrendo um Array          ");
            Console.WriteLine("24 - Start Datas                   ");
            Console.WriteLine("25 - StartsWith/EndsWith           ");
            Console.WriteLine("26 - String Builder                ");
            Console.WriteLine("27 - Struct                        ");
            Console.WriteLine("28 - Switch                        ");
            Console.WriteLine("29 - Timespan                      ");
            Console.WriteLine("30 - Timezone                      ");
            Console.WriteLine("31 - TryCatch (Exeption)           ");
            Console.WriteLine("32 - Tipos para Moeda              ");
            Console.WriteLine("33 - Value Datas                   ");
            Console.WriteLine("34 - Value Types                   ");
            Console.WriteLine("35 - While/Do                      ");
            Console.WriteLine("36 - Sair                          ");
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
                    case "9": Excecoes.Show(); break;
                    case "10": For.Show(); break;
                    case "11": ForEacha.Show(); break;
                    case "12": FormatandoDatas.Show(); break;
                    case "13": FormatCoins.Show(); break;
                    case "14": FormatDatas.Show(); break;
                    case "15": Guids.Show(); break;
                    case "16": Indices.Show(); break;
                    case "17": Interpolacao.Show(); break;
                    case "18": ManipulandoStrings.Show(); break;
                    case "19": MyMath.Show(); break;
                    case "20": MetodosAdicionais.Show(); break;
                    case "21": MetodosFunctions.Show(); break;
                    case "22": PadraodeFormatacao.Show(); break;
                    case "23": PercorrendoArray.Show(); break;
                    case "24": StartDatas.Show(); break;
                    case "25": StartEnd.Show(); break;
                    case "26": StringBuilder.Show(); break;
                    case "27": Struct.Show(); break;
                    case "28": Switch.Show(); break;
                    case "29": Timespan.Show(); break;
                    case "30": Timezone.Show(); break;
                    case "31": TryCathca.Show(); break;
                    case "32": TypeForCoin.Show(); break;
                    case "33": ValueDatas.Show(); break;
                    case "34": ValueTypes.Show(); break;
                    case "35": While.Show(); break;
                    case "36": System.Environment.Exit(0); break;
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