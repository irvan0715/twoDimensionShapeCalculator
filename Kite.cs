class Kite
{
    public double diagonal1, diagonal2;

    public double hitungLuasLayang()
    {
        return this.diagonal1 * this.diagonal2 / 2;
    }

    public double hitungKelilingLayang()
    {
        return 2 * (this.diagonal1 + this.diagonal2);
    }
}