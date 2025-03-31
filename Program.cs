double jurossimples;
double capital;
double taxadejuros;
double tempo;
double juros;
double montante;

Console.Clear();

Console.WriteLine ("--- Calculo de investimento: ---");

Console.Write ("Capital [c] (R$).......: ");
capital = Convert.ToDouble(Console.ReadLine ())!;

Console.Write ("Taxa de juros [i] (%)..: ");
taxadejuros = Convert.ToDouble(Console.ReadLine ())!;

Console.Write ("Tempo [t] (meses)......: ");
tempo = Convert.ToDouble(Console.ReadLine ())!;

taxadejuros = taxadejuros / 100;

juros = capital * taxadejuros * tempo; 

jurossimples = capital * taxadejuros * tempo;

Console.WriteLine ($@"
Juros (R$).....: {juros}");

jurossimples = capital * taxadejuros * tempo;

montante = capital + juros;

Console.WriteLine ($"Montante (R$)..: {montante}");
