
namespace Problema1{

    public class Problema {

        public static void Main(string[] args) {

            string numero = Console.ReadLine();

            while(numero.Length != 4) {
                Console.WriteLine("O número deve conter exatamente 4 digitos! digite novemente:");
                numero = Console.ReadLine();
            }

            int nPares = 0;

            foreach ( char algarismo in numero) {
                int equivalentValue = (int)(algarismo) - 30;
                if (equivalentValue % 2 == 0) nPares++;
            }

            Console.WriteLine(nPares);
        }

    }

}