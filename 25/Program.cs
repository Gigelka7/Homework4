int a = 3;
int b = 5;
int Exponentiation(int a, int b)
{
    int c = 1;
    for(int i=1; i <= b; i++)
    {
        c = c * a;
    }
    return c;
}
int d = Exponentiation(a, b);
Console.WriteLine(d);