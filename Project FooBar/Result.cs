namespace TheAnswer;
class Result
{
    public void InputUser(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            if (i > 0)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("foobar");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("foo");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}