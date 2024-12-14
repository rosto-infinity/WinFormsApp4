using System;

class Program
{
    static void Main()
    {
        int[,] matrice2 = new int[2, 2];

        matrice2[0, 0] = 1;
        matrice2[1, 0] = 3;
        matrice2[0, 1] = 5;
        matrice2[1, 1] = 7;

        AfficheMatrice(matrice2);
    }
    static void AfficheMatrice (int[,] m)
    {
        for (int i = 0; i <m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
            {
                Console.Write(m[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}
