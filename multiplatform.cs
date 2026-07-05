using System;

public class CPHInline
{
    public bool Execute()
    {
        // Komenda ma działać np. tak:
        // !stream Dead by Daylight | DBD z widzami, lecimy po escape'y 
                // Kategoria        |    Tytuł Streama
        CPH.TryGetArg("SurowyInpucikEssa", out string SurowyInpucikEssa);
        CPH.TryGetArg("inpucik1", out string inpucik1);

        string inpucik = !string.IsNullOrWhiteSpace(SurowyInpucikEssa) ? SurowyInpucikEssa : inpucik1;

        if (string.IsNullOrWhiteSpace(inpucik))
        {
            WysylanieOdpowiedziDoSigmaStreama("Użycie: !stream KATEGORIA | TYTUŁ");
            return false;
        }

        string[] czesciiiiiii = inpucik.Split(new[] { '|' }, 2);

        if (czesciiiiiii.Length < 2)
        {
            WysylanieOdpowiedziDoSigmaStreama("Brakuje separatora | użyj: !stream KATEGORIA | TYTUŁ");
            return false;
        }

        string kategoriaSigmaStreama = czesciiiiiii[0].Trim();
        string TytulSigmaStreama = czesciiiiiii[1].Trim();

        if (string.IsNullOrWhiteSpace(kategoriaSigmaStreama) || string.IsNullOrWhiteSpace(TytulSigmaStreama))
        {
            WysylanieOdpowiedziDoSigmaStreama("Kategoria i tytuł nie mogą być puste.");
            return false;
        }

        // Twitch ma limit tytułu 140 znaków
        if (TytulSigmaStreama.Length > 140)
            TytulSigmaStreama = TytulSigmaStreama.Substring(0, 140);

        // YouTube ma limit tytułu 100 znaków
        string YouTubeTytulik = TytulSigmaStreama.Length > 100 ? TytulSigmaStreama.Substring(0, 100) : TytulSigmaStreama;

        bool twitchTitleOk = false;
        bool youtubeTitleOk = false;
        bool youtubeCategoryOk = false;
        bool kickTitleOk = false;



        try
        {
            twitchTitleOk = CPH.SetChannelTitle(TytulSigmaStreama);
            CPH.SetChannelGame(kategoriaSigmaStreama);
        }




        catch (Exception MojaExKtorejNieMam)
        {
            CPH.LogWarn("[MultiStream] Twitch error: " + MojaExKtorejNieMam.Message);
        }



        try
        {
            youtubeTitleOk = CPH.YouTubeSetTitle(YouTubeTytulik);
            youtubeCategoryOk = CPH.YouTubeSetCategory(kategoriaSigmaStreama);
        }



        catch (Exception MojaExKtorejNieMam)
        {
            CPH.LogWarn("[MultiStream] YouTube error: " + MojaExKtorejNieMam.Message);
        }



        try
        {
            CPH.KickSetTitle(TytulSigmaStreama);
            CPH.KickSetCategory(kategoriaSigmaStreama);
            kickTitleOk = true;
        }


        catch (Exception MojaExKtorejNieMam)
        {
            CPH.LogWarn("[MultiStream] Kick error: " + MojaExKtorejNieMam.Message);
        }



        CPH.LogInfo("[MultiStream] Category: " + kategoriaSigmaStreama);
        CPH.LogInfo("[MultiStream] Title: " + TytulSigmaStreama);



        WysylanieOdpowiedziDoSigmaStreama(
            "Zmieniono dane streama: " +
            "Twitch " + BolekOrazLolek(twitchTitle_Dziala) + ", " +
            "YouTube " + BolekOrazLolek(youtubeTitleOk || youtubeCategory_Dziala) + ", " +
            "Kick " + BolekOrazLolek(kickTitle_Dziala)
        );

        return true;
    }

    private void WysylanieOdpowiedziDoSigmaStreama(string messssssssssage)
    {
        // Wyśle na Twitch chat, jeśli Twitch jest podpięty czy cos wsumie po co to skoro widac ale who cares
        try


        {
            CPH.SendMessage(messssssssssage, true, true);
        }
        catch


        {
            CPH.LogInfo("[MultiStream] " + messssssssssage);
        }

    }

    
    
    private string BolekOrazLolek(bool value)
    {
        return value ? "OK" : "FAIL";
    }
}
/*MIT License

Copyright (c) 2026 Lukituki6

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.*/
