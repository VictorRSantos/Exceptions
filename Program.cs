using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Clear();

            // Exceptions
            var arr = new int[3];

            try
            {

                for (int i = 0; i < 10; i++)
                {
                    System.Console.WriteLine(arr[i]);
                }

                Cadastrar("");
            }
            catch (IndexOutOfRangeException ex)
            {
                System.Console.WriteLine(ex.InnerException);
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (MinhaException ex)
            {
                System.Console.WriteLine(ex.InnerException);
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine(ex.QuandoAconteceu);
                System.Console.WriteLine("Exceção customizada");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.InnerException);
                System.Console.WriteLine(ex.Message);
                System.Console.WriteLine("Ops, algo deu errado!");
            }
            finally
            {
                Console.WriteLine("Chegou ao fim");

            }


        }

        private static void Cadastrar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                throw new MinhaException(DateTime.Now);
            }
        }

        public class MinhaException : Exception
        {
            public MinhaException(DateTime date)
            {
                QuandoAconteceu = date;
            }
            public DateTime QuandoAconteceu { get; set; }
        }
    }
}
