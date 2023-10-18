class Triangle
{
    public double alas, tinggi;

    public double hitungLuasSegitiga()
    {
        return this.alas * this.tinggi / 2;
    }
    public double hitungKelilingSegitiga()
    {
        return 3 * this.alas;
    }
}