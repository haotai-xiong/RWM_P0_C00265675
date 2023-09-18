using System.Linq;

public class CubeFilter
{
    // test CUBE
    public static int cube(int x)
    {
        return x * x * x;
    }

    public static int[] cubes(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = cube(xs[i]);
        }
        return result;
    }

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

    // test MODULOFIRST
    public static int[] ModuloFirst(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xs[i] % xs[0];
        }
        return result;
    }

    // test DecrementIfLessThanFirst
    public static int[] DecrementIfLessThanFirst(int[] xs)
    {
        int[] result = new int[xs.Length];
        for (int i = 0; i < xs.Length; i++)
        {
            if (xs[i] < xs[0])
            {
                result[i] = xs[i] - 1;
            }
            else
            {
                result[i] = xs[i];
            }
        }
        return result;
    }

    public static int[] RunningTotal(int[] xs)
    {
        int[] result = new int[xs.Length];
        int tempSum = 0;
        for (int i = 0; i < xs.Length; i++)
        {
            tempSum += xs[i];
            result[i] = tempSum;
        }
        return result;
    }

    public static int[] CubeDiff(int[] xs)
    {
        int[] result = new int[xs.Length];
        int tempMinus = 0;
        result[0] = xs[0];

        for (int i = 1; i < xs.Length; i++)
        {
            tempMinus = xs[i] - xs[i-1];
            if (tempMinus < 0)
            {
                tempMinus *= -1;
            }

            result[i] = tempMinus;
        }
        return result;
    }

    public static int[] CubeFact(int[] xs)
    {
        int[] result = new int[xs.Length];
        int temp = 1;

        for (int i = 0; i < xs.Length; i++)
        {
            temp = 1;
            for (int j = xs[i]; j > 0; j--)
            {
                temp *= j;
            }
            result[i] = temp;
        }
        return result;
    }
}