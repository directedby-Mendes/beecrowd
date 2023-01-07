using System;

namespace Grenais {
    class URI {

        public static void Main(string[] args) {
            int repetir=1,inter=0,gremio=0,grenais=0,empate=0;

            while (repetir == 1) {
                string[] placar = Console.ReadLine().Split();
                int n1 = int.Parse(placar[0]);
                int n2 = int.Parse(placar[1]);

                if (n1 > n2) {
                    inter += 1;
                }
                else if (n1 < n2) {
                    gremio += 1;
                }
                else
                    empate += 1;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                repetir = int.Parse(Console.ReadLine());
                grenais += 1;
            }
          
            Console.WriteLine(grenais+" grenais");
            Console.WriteLine("Inter:"+inter);
            Console.WriteLine("Gremio:"+gremio);
            Console.WriteLine("Empates:" + empate);


            if (inter>gremio) {
                Console.WriteLine("Inter venceu mais");
            }
            else
                Console.WriteLine("Gremio venceu mais");
        }
    }
}


