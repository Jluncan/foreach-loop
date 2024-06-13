namespace foreach_loop {
    internal class Program {
        static void Main(string[] args) {
            int[] nbrs = {
                 754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
                 187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
                 460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
                 690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
                 435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };

            int highest = 99;               // because we know every # is greater than 99
            int lowest = 1000;   // because we know ever # is lower than 1K
            int sum = 0;
            foreach (var nbr in nbrs) {          // nbr is singular nbrs from group up above

                if (nbr > highest) {
                    highest = nbr;
                }

                if (nbr < lowest) {              // looking to find # lower than the highest
                    lowest = nbr;
                }
                sum += nbr; //  sum = sum + nbr;                // all this does is add the number to the sum each time the loop hits  it takes the number from the right, adds it to nbr and puts it back in sum
            } Console.WriteLine($"Average:{sum / nbrs.Length}, Highest:{highest}, Lowest:{lowest}");   
        }
        
    }
}
