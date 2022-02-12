namespace Problema2 {

    partial class Program {

        public static int Main(string[] args) {

            int mult, start, end;
            Console.Write("Multiplicando:");
            mult = int.Parse(Console.ReadLine());
            Console.Write("Início do intervalo:");
            start = int.Parse(Console.ReadLine());
            Console.Write("Fim do intervalo:");
            end = int.Parse(Console.ReadLine());

            if (mult < 0 || mult > 5000) {
                Console.WriteLine("O multiplicando deve estar entre zero e 5000");
                return 0;
            } else if (start < 0 || start > 5000) {
                Console.WriteLine("O início do intervalo deve estar entre zero e 5000");
                return 0;
            }else if (start < 0 || start > 5000) {
                Console.WriteLine("O fim do intervalo deve estar entre zero e 5000");
                return 0;
            }else if (end - start >= 10) {
                Console.WriteLine("O intervalo deve ser menor que 10");
                return 0;
            }else if ( start >= end ) {
                Console.WriteLine("O início deve ser menor que seu fim");
                return 0;
            }

            for (int i = start; i <= end; i++) {
                Console.WriteLine($"{mult} x {i} = {mult*i}");
            }

            return 1;
        }
    }

}
