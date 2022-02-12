
namespace Problema4 {
    class Veiculo {
        public string nome { get; set; }
        public string marca { get; set; }
        public int capacidade { get; set; }
        public int litrosNoTanque { get; set; }

        public Veiculo() {
            litrosNoTanque = 0;
        }

        public Veiculo(string nome, string marca, int capacidade) {
            this.nome = nome;
            this.marca = marca;
            this.capacidade = capacidade;
            this.litrosNoTanque = 0;
        }

        public void abastecer(int amount) {
            int novaQuantidade = litrosNoTanque + amount;
            int custo = amount;

            if (novaQuantidade > capacidade) {
                litrosNoTanque = capacidade;
                Console.WriteLine($"O tanque foi excedido em {novaQuantidade - capacidade} litros");
                custo = amount - (novaQuantidade - capacidade);
            } else litrosNoTanque += amount;

            Console.WriteLine($"O custo foi de R${custo*7},00");
        }

        public override string ToString() {
            return $"nome = {nome}\n" 
                + $"marca = {marca}\n" 
                + $"capacidade = {capacidade}\n" 
                + $"Litros no Tanque = {litrosNoTanque}\n" ;
        }

    }
}
