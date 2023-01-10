namespace EnveloppesRouges;

internal class Solution
{
    internal static int LuckyMoney(int money, int giftees)
    {
        const int luckyNumber = 8;
        const int babNumber = 4;

        var res = 0;

        if (giftees == 0)
        {
            return 0;
        }
        if (giftees == 1)
        {
            return money == luckyNumber ? 1 : 0;
        }

        while (giftees > 2 && money > giftees)
        {
            money -= luckyNumber;
            res++;
            giftees--;
        }

        if (giftees == 2)
        {
            if (money <= luckyNumber)
            {
                return res;
            }
            else
            {
                if (money >= 2* luckyNumber)
                {
                    return res + 2;
                }
                else if (money - luckyNumber != babNumber)
                {
                    return res + 1;
                }
                else
                {
                    return res;
                }
            }
        }
        else
        {
            return res;
        }
    }
}
