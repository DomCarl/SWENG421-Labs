using P_Retail;
using P_TV;

class MyProg
{
    static void Main(string[] args)
    {
        TV_Proxy tvp = new TV_Proxy();

        tvp.sony_tvif.replenishTV(500);
    }
}