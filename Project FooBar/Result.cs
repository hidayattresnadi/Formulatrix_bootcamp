namespace TheAnswer;
class Result
{
    public string[] InputUser(int n)
    {
        // semisal pengen array tapi pengen nampung tipe data beda-beda
        string[] numbers = new string[n+1];
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
                    numbers[i]="foobar";
                    // Console.WriteLine("foobar");
                }
                else if (i % 3 == 0)
                {
                    numbers[i]="foo";
                    // Console.WriteLine("foo");
                }
                else if (i % 5 == 0)
                {
                    numbers[i]="bar";
                    // Console.WriteLine("bar");
                }
                else
                {
                    numbers[i]=i.ToString();
                    // Console.WriteLine(i);
                }
            }
            else
            {
                numbers[i]=i.ToString();
                // Console.WriteLine(i);
            }
        }
        return numbers;
    }
}