namespace TheAnswer;
public class Result
{
    public string MakeSentence(int n, Dictionary<int, string> dictionary)
    {
        Dictionary<int, string> dict = new();
        if (n < 0)
        {
            return "Cannot accept negative numbers";
        }
        for (int i = 0; i <= n; i++)
        {
            if (i > 0)
            {
                int dividedNumber = 0;
                string word = "";
                foreach (var item in dictionary)
                {
                    if (dividedNumber == 0)
                    {
                        if (i % item.Key == 0)
                        {
                            dict.Add(i, item.Value);
                            word += item.Value;
                            dividedNumber++;
                        }
                    }
                    else
                    {
                        if (i % item.Key == 0)
                        {
                            word += item.Value;
                            dict[i] = word;
                        }

                    }
                }
                if (dividedNumber == 0)
                {
                    dict.Add(i, i.ToString());
                }
            }
            else
            {
                dict.Add(i, i.ToString());
            }
        }
        string sentence = string.Join(",", dict.Values);
        return sentence;
    }
}