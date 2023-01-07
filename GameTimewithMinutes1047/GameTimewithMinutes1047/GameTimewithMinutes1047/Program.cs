using System;
class URI {

    static void Main(string[] args) {
        string[] value = Console.ReadLine().Split();
        int hinicial = int.Parse(value[0]);
        int minicial = int.Parse(value[1]);
        int hfinal = int.Parse(value[2]);
        int mfinal = int.Parse(value[3]);
        double total = 0;

        int inicioMinutos = hinicial * 60 + minicial;
        int finalMinutos = hfinal * 60 + mfinal;

        if (finalMinutos > inicioMinutos) {
            total = finalMinutos - inicioMinutos;
        }
        else if (finalMinutos < inicioMinutos) {
            total = 1440 - inicioMinutos + finalMinutos;
        }
        else if (inicioMinutos == finalMinutos) {
            total = 1440;
        }
        double horas = Math.Truncate(total / 60);
        double minutos = total % 60;
        Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
    }

}