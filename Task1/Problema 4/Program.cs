
namespace Problema4 {

    public class Program {
        public static void Main(string[] args) {

            Veiculo v = new("Civic", "Honda", 100);

            v.abastecer(20);
            Console.WriteLine(v);

            v.abastecer(40);
            Console.WriteLine(v);

            v.abastecer(80);
            Console.WriteLine(v);

        }
    }

}