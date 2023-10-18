class Parallellogram
{
    public double alas, tinggi;

    public double hitungLuasJajarGenjang()
    {
        return this.alas * this.tinggi;
    }
    public double hitungKelilingJajarGenjang()
    {
        return 2 * (this.alas + this.tinggi);
    }
}