using System.Linq;

public class Modulo3Filter
{
    // test MODULO3
    public static int[] Modulo3(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xs[i] % 3;
        }
        return result;
    }
}