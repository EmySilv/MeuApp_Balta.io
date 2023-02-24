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
            Console.WriteLine("7 - Customizando Exceptions        ");
            Console.WriteLine("8 - DateTime                       ");
            Console.WriteLine("9 - Disparando Exceções(criando)   ");
            Console.WriteLine("10 - Equals                        ");
            Console.WriteLine("11 - Exceptions(É só um erro)      ");
            Console.WriteLine("12 - Finally                       ");
            Console.WriteLine("13 - For                           ");
            Console.WriteLine("14 - Foreach                       ");
            Console.WriteLine("15 - Formatando Datas              ");
            Console.WriteLine("16 - Formatando Moeda              ");
            Console.WriteLine("17 - FormatDatas                   ");
            Console.WriteLine("18 - Guids                         ");
            Console.WriteLine("19 - Indices                       ");
            Console.WriteLine("20 - Interpolação                  ");
            Console.WriteLine("21 - Manipulando Strings           ");
            Console.WriteLine("22 - Math                          ");
            Console.WriteLine("23 - Métodos Adicionais            ");
            Console.WriteLine("24 - Métodos e Funções             ");
            Console.WriteLine("25 - Padrão de Formatação          ");
            Console.WriteLine("26 - Percorrendo um Array          ");
            Console.WriteLine("27 - Start Datas                   ");
            Console.WriteLine("28 - StartsWith/EndsWith           ");
            Console.WriteLine("29 - String Builder                ");
            Console.WriteLine("30 - Struct                        ");
            Console.WriteLine("31 - Switch                        ");
            Console.WriteLine("32 - Timespan                      ");
            Console.WriteLine("33 - Timezone                      ");
            Console.WriteLine("34 - Tratando Erros                ");
            Console.WriteLine("35 - TryCatch (Exeption)           ");
            Console.WriteLine("36 - Tipos para Moeda              ");
            Console.WriteLine("37 - Value Datas                   ");
            Console.WriteLine("38 - Value Types                   ");
            Console.WriteLine("39 - While/Do                      ");
            Console.WriteLine("40 - Sair                          ");
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
                    case "7": CustomizandoExceptions.Show(); break;
                    case "8": MyDateTime.Show(); break;
                    case "9": DisparandoExcecoes.Show(); break;
                    case "10": Equales.Show(); break;
                    case "11": Excecoes.Show(); break;
                    case "12": Finally.Show(); break;
                    case "13": For.Show(); break;
                    case "14": ForEacha.Show(); break;
                    case "15": FormatandoDatas.Show(); break;
                    case "16": FormatCoins.Show(); break;
                    case "17": FormatDatas.Show(); break;
                    case "18": Guids.Show(); break;
                    case "19": Indices.Show(); break;
                    case "20": Interpolacao.Show(); break;
                    case "21": ManipulandoStrings.Show(); break;
                    case "22": MyMath.Show(); break;
                    case "23": MetodosAdicionais.Show(); break;
                    case "24": MetodosFunctions.Show(); break;
                    case "25": PadraodeFormatacao.Show(); break;
                    case "26": PercorrendoArray.Show(); break;
                    case "27": StartDatas.Show(); break;
                    case "28": StartEnd.Show(); break;
                    case "29": StringBuilder.Show(); break;
                    case "30": Struct.Show(); break;
                    case "31": Switch.Show(); break;
                    case "32": Timespan.Show(); break;
                    case "33": Timezone.Show(); break;
                    case "34": TratandoErros.Show(); break;
                    case "35": TryCathca.Show(); break;
                    case "36": TypeForCoin.Show(); break;
                    case "37": ValueDatas.Show(); break;
                    case "38": ValueTypes.Show(); break;
                    case "39": While.Show(); break;
                    case "40": System.Environment.Exit(0); break;
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