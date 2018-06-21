/* Aleš Jaterka
 * Testovací aplikace na SelfHosting service pro WCF.
 * Okopírováno z MSDN, pozměněny jména a struktura.
 * 
 * Spuštění servisy, klasicky F5.
 * Spuštěním testovacího klienta ve VS Comunity 2017, umístěn zde:
 * C:\Program Files (x86)\Microsoft Visual Studio\2017\Community\Common7\IDE\WcfTestClient.exe
 * A po přidání Servisy (hosta) s danou adresou (http://localhost:8080/hello),
 * lze otestovat zadáním "jména" do pole Value (hodnota) a stlačením tlačítka Invoke.
 * Servisa odpoví, a odpověď se vypíše ve spodní části okna.
 * (Při vypnuté servise vyskočí chyba)
 */

namespace SelfHosting
{
    class Program
    {
        /// <summary>
        /// Vstupní metoda pro SelfHosting servisu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var app = new MyApp();
            app.Run();
        }
    }
}
