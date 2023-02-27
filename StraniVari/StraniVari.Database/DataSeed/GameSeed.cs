using Microsoft.EntityFrameworkCore;
using StraniVari.Core.Entities;

namespace StraniVari.Database.DataSeed
{
    public static class GameSeed
    {
        public static void SeedGames(this ModelBuilder builder)
        {
            List<string> gameNames = new()
            {
                "Izmedju dvije vatre",
                "Fudbal",
                "Pitalice s loptom",
                "Pogodi tko sam – igra imitacije i pogađanja",
                "Crtanje zavezanih očiju"
            };

            List<string> rules = new()
            {
                "U igri učestvuje osam (8) igrača, sedam (7) u svojoj polovici terena za igru i jedan graničar. Graničar se nalazi iza linije terena za igre na suprotnoj strani od polovice terena za igru gdje se nalazi njegova ekipa. Suparnička ekipa nalazi se između graničara i njegove ekipe.Cilj igre je da svaka ekipa rukom bačenu loptu neobranjivo pogađa igrače suparničke ekipe u njihovom polju,a da izbjegnu iste namjere suparničke ekipe.Meč se igra na ispadanje,tačnije kada protivnička ekipa pogodi igrača,igrač ispada i meč se igra sve dok se ne pogodi i posljedni igrač u polju.",
                "Svaka se ekipa sastoji od najviše 11 igrača (ne zamjena tj. rezervi), od kojih jedan mora biti golman. Pravila takmičenja određuju minimalan broj igrača koji je potreban za stvaranje ekipe, što je najčešće sedam.",
                "Uzmite loptu i preko nje zalijepite bijeli papir sa selotejpom. Napišite djeci. Neka djeca sjednu u krug i bacaju loptu. Kad uhvate loptu, moraju odgovoriti na pitanje najbliže desnom kažiprstu. Nakon odgovora, opet bacaju loptu. Možete na lopti napisati brojeve, a pitanja posebno na papiru ako vam je tako lakše.",
                "Riječ je o pantomimi gdje jedna osoba glumi neku drugu osobu koju ostali igrači znaju. Sve je dozvoljeno osim razgovora.",
                "Na dječjoj ploči ili većem komadu papira organizirajte igru u kojoj ćete se izmjenjivati u crtanju. Preostali igrači neke redom zadaju zadatke. U igri nema bodova i pobjednika, cilj je dobra zabava."
            };

            List<Game> games = new();

            for(int i=1; i<=5; i++)
            {
                games.Add(new Game
                {
                    Id =i, 
                    Name = gameNames[i % 5],
                    Rules = rules[i%5]
                });
            }
            builder.Entity<Game>().HasData(games);
        }
    }
}
