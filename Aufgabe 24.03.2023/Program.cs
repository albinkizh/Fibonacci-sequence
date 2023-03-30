int var1 = 1;
int var2 = 1;
int var3 = 1;
//Zuerst werden Variablen für die Zahlen erstellt

Console.WriteLine("Wie weit soll die Rechnung gehen?");
int ans = Convert.ToInt32(Console.ReadLine());



for (int i = 0; i < ans; i++)
{
    //Hier wird jede Variable benützt und in verschiedenen Formen gerechnet
    var3 = var1 + var2;
    Console.WriteLine("{0} + {1} = {2}", var2, var1, var3);
    //Hier wird von oben die neuen Zahlen genommen und dann bei dieser Rechnung benützt
    var2 = var1 + var3;
    Console.WriteLine("{0} + {1} = {2}", var1, var3, var2);
    //Hier genau das gleiche
    var1 = var2 + var3;
    Console.WriteLine("{0} + {1} = {2}", var2, var1, var1);
}




