using System;

namespace MeuApp
{
    public static class Interpolacao
    {
        public static void Show()
        {
            Console.Clear();

            var price = 10.2;
            // var texto = "o preço do produto é " + price + ", apenas na promoção";
            var txt = string.Format(" o preço do prduto é {0} apenas na promoção {1}", price, true);//usado pra formatar uma string;
                                                                                                    //0 e 1 é a posição dos elemntos aqui de cima, price e true, sem ter ordem definida

            var texto = $@"o preço do produto
             é de {price} apenas na promoção"; //o arroba serve para o programa entender que essa linha de baixo é a continuação da de cima
                                               //e com o arroba vc n consegue usar o \n como quebra de linha

            Console.WriteLine(txt);

            Console.ReadKey();
            Menu.Show();
        }
    }
}