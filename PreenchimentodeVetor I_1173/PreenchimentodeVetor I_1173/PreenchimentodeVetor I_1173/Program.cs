using System;

class URI {

    static void Main(string[] args) {
       
        int n = int.Parse(Console.ReadLine());
        
        int[] vetor = new int[10];
        
        for (int i = 0; i < 10; i++) {
            vetor[i] += n;
            n+=n;           
        }
        for (int i = 0; i < 10; i++) {
            Console.WriteLine("N[" + i+"] = " + vetor[i]);    
        }
    }
}