// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Runtime.InteropServices;



Buffet bufet1 = new Buffet();


Ninja ninja1 = new Ninja();

Console.WriteLine("+++++++++++++");

while (ninja1.IsFull ==false)
{
    
ninja1.Eat(bufet1.Serve());
}
ninja1.Eat(bufet1.Serve());