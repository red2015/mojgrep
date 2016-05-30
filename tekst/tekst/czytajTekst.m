function tekst = czytajTekst(nazwapliku)

    f = fopen(nazwapliku);
    tekst = fread(f, inf, 'char=>char')';
    fclose(f);
