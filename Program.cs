BankTransfer bankTransfer = new BankTransfer();
Ewallet ewallet = new Ewallet();
KartuKredit kartuKredit = new KartuKredit();

Console.WriteLine("----Simulasi Checkout----");
Console.WriteLine("pilih metode");
Console.WriteLine("1.Bank Transfer \n2. E-Wallet \n3. Kartu Kredit");
Console.Write("Pilihan anda (1/2/3): ");
string pilihan = Console.ReadLine();

switch (pilihan)
{
    case "1":
        bankTransfer = new BankTransfer();
        bankTransfer.Bayar(1000);
        break;

    case "2":
        ewallet = new Ewallet();
        ewallet.Bayar(1000);
        break;

    case "3":
        kartuKredit = new KartuKredit();
        kartuKredit.Bayar(1000);
        break;

}

class MetodePembayaran
{
    public virtual void Bayar (int jumlah)
    {
        Console.WriteLine($"Segera lakukan pembayaran sebesar Rp. {jumlah}");
    }
}

class BankTransfer : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Silahkan transfer sejumlah {jumlah} ke nomor rekening 123456789");
    }
}

//class EWalet
class Ewallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Saldo terpotong sejumlah Rp. {jumlah}");
    }
}

//class
class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine($"Transaksi sejumlah Rp. {jumlah} berhasil dilakukan");
    }
}