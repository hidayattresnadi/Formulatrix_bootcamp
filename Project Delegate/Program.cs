// See https://aka.ms/new-console-template for more information

// delegate, jadi untuk menambah function2 dari class lain ke class Mydelegate
// usefull case ketika return type void, apabila ada return type selain void, maka
// hanya yang terakhir diassign saja yang jalan, sisanya tidak

public delegate void MyDelegate();
public delegate void MyDelegateString(string input);

public delegate int MyDelegateCalc(int a,int b);

public delegate void MyDelegateCalcVoid(int a,int b);
class Program {
    static void Main (){
        Email email = new();
        SMS sms = new();
        MyDelegate delegates = email.EmailNotify;
        delegates += email.SendEmail;
        delegates += sms.SMSNotify;

        delegates();
        delegates.Invoke();

        MyDelegateString delegateString = email.EmailNotifyString;
        delegateString += email.SendEmailString;
        delegateString += sms.SMSNotifyString;

        delegateString("Protagonist name");
        delegateString.Invoke("Yuki");

        Calculator calculate = new();
        MyDelegateCalc delegateCalc = calculate.Addition;
        delegateCalc += calculate.Times;

        Console.WriteLine(delegateCalc(2,5));

        MyDelegateCalcVoid delegateCalcVoid = calculate.AdditionVoid;
        delegateCalcVoid += calculate.TimesVoid;
        delegateCalcVoid(2,5);

        
    }
}

class Email {
    public void EmailNotify(){
        Console.WriteLine("Email got notified");
    }

    public void EmailNotifyString(string a){
        Console.WriteLine($"Email got notified by {a}");
    }

    public void SendEmail(){
        Console.WriteLine("Email Got Notified");
    }

    public void SendEmailString(string a){
        Console.WriteLine($"Email Got Notified by {a}");
    }
}

class SMS {
    public void SMSNotify(){
        Console.WriteLine("SMS got notified");
    }

    public void SMSNotifyString(string a){
        Console.WriteLine($"SMS got notified {a}");
    }
}

class Calculator {
    public int Addition (int a,int b){
        return a+b;
    }

    public int Times (int a, int b) {
        return a*b;
    }

    public void AdditionVoid (int a,int b){
        Console.WriteLine(a+b);
    }

    public void TimesVoid (int a, int b) {
        Console.WriteLine(a*b);
    }
}

class Gacha {

    private int primogem;
    public Gacha (int primogem){
        this.primogem = primogem;
    }

    public void decreasePrimo(int primo){
        Console.WriteLine(primo-1600);
    }

    public void ShowResult(){
        Console.WriteLine("Your Result is");
    }
}
