using P_Retail;

class MyProg
{
    static void Main(string[] args)
    {
        Retailer retail = new Retailer();

        //retail.sony_tvif.getInfo();

        retail.tvp.replenishTV(500);
        //retail.tvp.getInfo();
    }
}