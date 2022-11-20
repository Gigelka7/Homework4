int a = 345;
int b = 0;
while (a > 0)
 {
 
    b = b + a % 10;
    a = a /10 ;
 
}
Console.WriteLine(b);