namespace eRent.Services.DataDB;

public partial class Fitpaso
{
    public int PasosId { get; set; }

    public int KorisnikId { get; set; }

    public DateTime DatumIzdavanja { get; set; }

    public bool IsValid { get; set; }

    public virtual Korisnik Korisnik { get; set; } = null!;
}
