int[] sorozat = { 3, 2, 5, 4, 1 };
Random rnd = new();

Csererendezes();
Buborekrendezes();
Veletlen();

//feladatlap f1
Dolg01();

void Dolg01()
{

}

void Veletlen()
{
    Console.WriteLine("\n");
    //Egész szám [0, Int.MaxValue]
    int r1 = rnd.Next();
    Console.WriteLine($"r1 = {r1}");
    //Egész szám [0, maxValue]
    int r2 = rnd.Next(100);
    Console.WriteLine($"r2 = {r2}");
    //egész szám [minValue, maxValue]
    int r3 = rnd.Next(-30, 60);
    Console.WriteLine($"r3 = {r3}");

    //[0, 1] -> 64bites lebegőpontos szám
    double r4 = rnd.NextDouble();
    Console.WriteLine($"r4 = {r4}");


    //------------------

    //[15, 25] szám, pontosan 1 db tizedesjegy pontossággal:
    float r5 = rnd.Next(15, 26) / 10f;
    Console.WriteLine($"r5 = {r5}");
}

void Buborekrendezes()
{
    for (int i = sorozat.Length - 1; i >= 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (sorozat[j] > sorozat[j + 1])
            {
                int seged = sorozat[j];
                sorozat[i] = sorozat[j + 1];
                sorozat[j + 1] = seged;
            }
        }
    }
    Console.WriteLine("\n");
    foreach (var e in sorozat)
    {
        Console.Write($"{e}, ");
    }
}

void Csererendezes(){ 
for(int i = 0; i < sorozat.Length - 1; i++)
{
        for (int j = i + 1; j < sorozat.Length; j++)
        {
            if (sorozat[i] > sorozat[j])
            {
                int seged = sorozat[i];
                sorozat[i] = sorozat[j];
                sorozat[j] = seged;
            }
        }
    }

    foreach (var e in sorozat)
    {
        Console.Write($"{e}, ");
    }
}