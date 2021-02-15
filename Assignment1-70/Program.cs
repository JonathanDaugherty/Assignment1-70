using System;

namespace Assignment1_70 {
    class Program {
        static void Main(string[] args) {
            /*var total = 0;
            for (var idx = 1; idx < 71; idx++)
                if (idx % 7 == 0) {
                    total += idx;
                }
                    Console.WriteLine($"Total is {total}"); */

             int[] nbrs = { 754, 697, 823, 6, 235, 543, 908, 123, 450, 768, 999, 630 };
             var highest = 0;
             var lowest = 1000;
             foreach (var nbr in nbrs) {
                highest = (nbr > highest) ? nbr : highest;
                lowest = (nbr < lowest) ? nbr : lowest;
                
                /* if (nbr > highest) {
                     highest = nbr;
                 }
                 if (nbr < lowest) {
                     lowest = nbr;
                 } */
             }
             Console.WriteLine($"Highest: {highest}; Lowest: {lowest}"); 

            
        }
    }
}
