class Rhombus
{
    public double diagonal1, diagonal2;

    public double hitungLuasBelahKetupat()
    {
        return this.diagonal1 * this.diagonal2 / 2;
    }

    public double hitungKelilingBelahKetupat()
    {
        return 4 * this.diagonal1;
    }
}