namespace StringParser;

internal class Answer
{
    static internal bool Check(string str)
    {
        if (str == null || str.Length == 0)
        {
            return true;
        }

        var ouverturesEnCOurs = "";

        foreach (var car in str)
        {
            if (car is ']' or ')')
            {
                if (ouverturesEnCOurs.Length == 0)
                {
                    return false;
                }
                else if (car is ']' && ouverturesEnCOurs.Last() is '['
                    || car is ')' && ouverturesEnCOurs.Last() is '(')
                {
                    ouverturesEnCOurs = ouverturesEnCOurs.Substring(0, ouverturesEnCOurs.Length- 1);
                }
            }
            else
            {
                ouverturesEnCOurs += car.ToString();
            }
        }

        return ouverturesEnCOurs.Length == 0;
    }
}
