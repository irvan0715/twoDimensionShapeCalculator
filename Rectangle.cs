class Rectangle
{
    public double panjang, lebar;

    public double hitungLuasPersegiPanjang()
    {
        return this.panjang * this.lebar;
    }
    public double hitungKelilingPersegiPanjang()
    {
        return 2 * (this.panjang + this.lebar);
    }
}