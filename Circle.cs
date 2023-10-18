class Circle
{
    public double jariJari;
    public const double phi = 3.14;

    public double hitungLuasLingkaran()
    {
        return phi * this.jariJari * this.jariJari;
    }

    public double hitungKelilingLingkaran()
    {
        return 2 * phi * this.jariJari;
    }
}