namespace TheAnswer;
class Result
{
    public Dictionary<int,string> InputUser(int n)
    {
        // semisal pengen array tapi pengen nampung tipe data beda-beda
        string[] numbers = new string[n+1];
        Dictionary<int,string> dict = new();
        if (n < 0) {
            Console.WriteLine("Cannot accept negative numbers");
            // return;
        }
        for (int i = 0; i <= n; i++)
        {
            // numbers[i]=i;
            // if(i==5){
            //     numbers[i]="foo";
            // }
            // Console.WriteLine(numbers[i]);
            // Console.WriteLine("========");
            if (i > 0)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    dict.Add(i,"foobar");
                    numbers[i]="foobar";
                    // Console.WriteLine("foobar");
                }
                else if (i % 3 == 0)
                {
                    dict.Add(i,"foo");
                    numbers[i]="foo";
                    // Console.WriteLine("foo");
                }
                else if (i % 5 == 0)
                {
                    dict.Add(i,"bar");
                    numbers[i]="bar";
                    // Console.WriteLine("bar");
                }
                else
                {
                    dict.Add(i,i.ToString());
                    numbers[i]=i.ToString();
                    // Console.WriteLine(i);
                }
            }
            else
            {
                dict.Add(i,i.ToString());
                numbers[i]=i.ToString();
                // Console.WriteLine(i);
            }
        }
        return dict;
    }
}