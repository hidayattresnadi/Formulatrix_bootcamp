// namespace untuk membatasi supaya run program ga ke semuanya, tapi hanya beberapa file aja di setiap file
// kasih namespace sama supaya program dijalankan sesuai kebutuhan
namespace Human;
class Person {
    public string name;
    public int height;
    public string gender;

    public Handphone handphone;

    public Shoes shoes;

    public Person (
        string name,
        int height,
        string gender,
        Handphone handphone,
        Shoes shoes){
        this.name=name;
        this.height=height;
        this.gender=gender;
        this.handphone=handphone;
        this.shoes=shoes;
    }
}