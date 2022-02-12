

namespace Problema3 {
    class Filme {

        public string titulo { get; private set; }
        public Genero genero { get; private set; }
        public int duracaoEmMinutos { get; private set; }
        public string horarioSessao { get; private set; }

        public Filme() { 
        }

        public Filme(string titulo, Genero genero, int duracaoEmMinutos,
            string horarioSessao) {
            this.titulo = titulo;
            this.genero = genero;
            this.duracaoEmMinutos = duracaoEmMinutos;
            this.horarioSessao = horarioSessao;
        }

        public double calcularDuracaoEmHoras() {
            return Math.Floor( (double)duracaoEmMinutos / 60.0);
        }

        public void retornarHoraQueAcaba() {            
            int horas = (int)calcularDuracaoEmHoras();
            int minutos = duracaoEmMinutos - horas;
            
            string minutosString = string.Concat(horarioSessao[3],horarioSessao[4]);
            string horasString = string.Concat(horarioSessao[0], horarioSessao[1]);
            int Auxmin = int.Parse(minutosString);
            int Auxhour = int.Parse(horasString);

            horas += Auxhour;
            minutos += Auxmin;

            if(minutos > 60) {
                minutos -= 60;
                horas++;
            }

            if(horas > 24) {
                horas -= 24;
            }
            Console.WriteLine($"{horas}:{minutos}");
        }

        public override string ToString() {
            return $"Titulo: {titulo}\n"
                    + $"Genero: {genero}\n"
                    + $"Duracao: {calcularDuracaoEmHoras()} horas e {duracaoEmMinutos - calcularDuracaoEmHoras() * 60.0} minutos\n";
        }
    }
}
