using P_Retail;
using P_TV;

class MyProg
{
    static void Main(string[] args)
    {
        Visio_Smart_TV tv = new Visio_Smart_TV();
        tv.replenishTV(600);
        tv.getInfo();
    }
}