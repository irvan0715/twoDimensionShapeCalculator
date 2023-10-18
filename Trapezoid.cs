class Trapezoid
{
    public double alasAtas, alasBawah, tinggi;

    public double hitungLuasTrapesium()
    {
        return (this.alasAtas + this.alasBawah) * this.tinggi / 2;
    }

    public double hitungKelilingTrapesium()
    {
        return this.alasAtas + this.alasBawah + 2 * this.tinggi;
    }
}