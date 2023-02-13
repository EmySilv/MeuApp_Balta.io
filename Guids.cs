using System;

namespace MeuApp
{
    public static class Guids
    {
        public static void Show()
        {
            //GUID = Globally Unique Identifier/ idntificador unico
            var id = Guid.NewGuid();//criando um idenficaador unico, não precisa importar nada pq ele tá dentro do System;
            id.ToString().Substring(0, 8);//transformando em string e pegando somente os 8 primeiros caracteres

            id = new Guid("Passando valor na string");// pra isso precisa do new Guid

            if (id == Guid.NewGuid())//comparação de Guids

                id = new Guid("7abc7839-b8d5-45e5-b9c9-aa9e3a13a8ae");//atribuindo o valor ao Guid

            id = new Guid(); //gera um Guid somente com zeros(somente inicializando o Guid)

            //basicamente um gerador de valores randomicos
            Console.WriteLine(id);

            Console.ReadKey();
            Menu.Show();
        }
    }
}