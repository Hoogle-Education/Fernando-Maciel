using Problema3;

namespace Problema_3 {
    class Cinema {

        public string nome { get; private set; }
        public string endereco { get; private set; }
        public List<Filme> filmesEmCartaz = new List<Filme>();

        public Cinema() {
        }

        public Cinema(string nome, string endereco, List<Filme> filmesEmCartaz) {
            this.nome = nome;
            this.endereco = endereco;
            this.filmesEmCartaz = filmesEmCartaz;
        }

        public void adicionarFilme(Filme filme) {
            filmesEmCartaz.Add(filme);
            listarFilmes();
        }

        public void removerFilme(Filme filme) {
            Console.WriteLine($"Deseja mesmo remover o filme {filme.titulo}? (S/N)");
            char option = char.Parse(Console.ReadLine());

            if(option == 'S') filmesEmCartaz.Remove(filme);
        }

        public void listarFilmes() {
            foreach (Filme filme in filmesEmCartaz) {
                Console.WriteLine(filme);
            }
        }

    }
}
