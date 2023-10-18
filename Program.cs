class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program Perhitungan Bangun Datar");
        Console.WriteLine("1. Persegi");
        Console.WriteLine("2. Persegi Panjang");
        Console.WriteLine("3. Segitiga");
        Console.WriteLine("4. Lingkaran");
        Console.WriteLine("5. Layang-layang");
        Console.WriteLine("6. Belah Ketupat");
        Console.WriteLine("7. Jajar Genjang");
        Console.WriteLine("8. Trapesium");

        Square persegi = new Square();
        Rectangle persegiPanjang = new Rectangle();
        Triangle segitiga = new Triangle();
        Circle lingkaran = new Circle();
        Kite layang = new Kite();
        Rhombus belahKetupat = new Rhombus();
        Parallellogram jajarGenjang = new Parallellogram();
        Trapezoid trapesium = new Trapezoid();

        Console.Write("Pilihan Anda [1..8] : ");
        int pilihan = Convert.ToInt32(Console.ReadLine());

        switch (pilihan)
        {
            case 1:
                Console.Write("Masukkan sisi : ");
                persegi.sisi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luas persegi = " + persegi.hitungLuasPersegi());
                Console.WriteLine("Keliling persegi = " + persegi.hitungKelilingPersegi());
                break;
            case 2:
                Console.Write("Masukkan panjang : ");
                persegiPanjang.panjang = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan lebar : ");
                persegiPanjang.lebar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luas persegi panjang = " + persegiPanjang.hitungLuasPersegiPanjang());
                Console.WriteLine("Keliling persegi panjang = " + persegiPanjang.hitungKelilingPersegiPanjang());
                break;
            case 3:
                Console.Write("Masukkan alas : ");
                segitiga.alas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan tinggi : ");
                segitiga.tinggi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luas segitiga = " + segitiga.hitungLuasSegitiga());
                Console.WriteLine("Keliling segitiga = " + segitiga.hitungKelilingSegitiga());
                break;
            case 4:
                Console.Write("Masukkan jari-jari : ");
                lingkaran.jariJari = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luas lingkaran = " + lingkaran.hitungLuasLingkaran());
                Console.WriteLine("Keliling lingkaran = " + lingkaran.hitungKelilingLingkaran());
                break;
            case 5:
                Console.Write("Masukkan diagonal 1 : ");
                layang.diagonal1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan diagonal 2 : ");
                layang.diagonal2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luas layang-layang = " + layang.hitungLuasLayang());
                Console.WriteLine("Keliling layang-layang = " + layang.hitungKelilingLayang());
                break;
            case 6:
                Console.Write("Masukkan diagonal 1 : ");
                belahKetupat.diagonal1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan diagonal 2 : ");
                belahKetupat.diagonal2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luas belah ketupat = " + belahKetupat.hitungLuasBelahKetupat());
                Console.WriteLine("Keliling belah ketupat = " + belahKetupat.hitungKelilingBelahKetupat());
                break;
            case 7:
                Console.Write("Masukkan alas : ");
                jajarGenjang.alas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan tinggi : ");
                jajarGenjang.tinggi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luas jajar genjang = " + jajarGenjang.hitungLuasJajarGenjang());
                Console.WriteLine("Keliling jajar genjang = " + jajarGenjang.hitungKelilingJajarGenjang());
                break;
            case 8:
                Console.Write("Masukkan sisi atas : ");
                trapesium.alasAtas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan sisi bawah : ");
                trapesium.alasBawah = Convert.ToInt32(Console.ReadLine());
                Console.Write("Masukkan tinggi : ");
                trapesium.tinggi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Luas trapesium = " + trapesium.hitungLuasTrapesium());
                Console.WriteLine("Keliling trapesium = " + trapesium.hitungKelilingTrapesium());
                break;
            default:
                Console.WriteLine("Pilihan tidak tersedia");
                break;
        }

        Console.Write("Apakah anda ingin mengulang? [y/n] : ");
        string ulang = Console.ReadLine();
        ulang = ulang.ToLower();

        if (ulang == "y")
        {
            Main(args);
        }
        else
        {
            Console.WriteLine("Terima kasih telah menggunakan program ini");
        }
    }
}