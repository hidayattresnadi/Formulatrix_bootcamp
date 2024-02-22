// See https://aka.ms/new-console-template for more information
using OverRiding;

class Program {
    static void Main (){

        Animal general = new("female","gray","lol");
        general.Sound();

        Cat kitten =new("female","orange","kimi");
        kitten.Sound();

        Dog lucy = new("female","golden","lucy");
        lucy.Sound();

        Ant nemo = new("male","black","nemo");
        nemo.Sound();
        nemo.plus();
    }
}
