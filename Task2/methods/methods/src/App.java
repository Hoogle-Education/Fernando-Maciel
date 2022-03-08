public class App {

    public static int somaDoisNumeros(int a, int b){
        return a+b;
    }

    public static int diferencaDoisNumeros(int a, int b){
        return a-b;
    }

    public static int produtoDoisNumeros(int a, int b){
        return a*b;
    }

    public static int divisaoDoisNumeros(int a, int b){
        return a/b;
    }

    public static void main(String[] args) throws Exception {
    
        int primeiro = somaDoisNumeros(10, 20);
        int segundo = diferencaDoisNumeros(primeiro, 20);
        int terceiro = produtoDoisNumeros(segundo, 20);
        int quarto = divisaoDoisNumeros(terceiro, 20);

        System.out.println(quarto);

    }
}
