namespace Problema3 {

    public partial class Program {
        public static void Main(string[] args) { 
        
            Filme f = new Filme("filme teste", Genero.Terror, 128, "15:30");

            Console.WriteLine(f.calcularDuracaoEmHoras());
            Console.WriteLine(f);
            f.retornarHoraQueAcaba();

        }
    }

}