namespace MoveTowardsZero;

internal class A
{
    internal static int ClosestToZero(int[] ints)
    {
        if (ints == null || ints.Length == 0)
        {
            return 0;
        }

        var negatif = int.MinValue;
        var positif = int.MaxValue;

        var nombresPositifs = false;
        var nombresNegatifs = false;

        var list = ints.ToList();

        foreach ( var i in list )
        {
            if (i == 0)
                return 0;
            else if (i < 0)
            {
                nombresNegatifs = true;
                if (i > negatif)
                {
                    negatif = i;
                }
            }
            else if (i > 0)
            {
                nombresPositifs = true;
                if (i < positif)
                {
                    positif = i;
                }
            }
        }

        if (!nombresNegatifs)
        {
            return positif;
        }
        if (!nombresPositifs)
        {
            return negatif;
        }

        return positif + negatif > 0 ? negatif : positif;
    }
}
