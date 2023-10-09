// See https://aka.ms/new-console-template for more information

using classwork13_net;
/*
MyMath mm = new MyMath();
MyDelegate md = new MyDelegate(mm.Sum);

md += mm.Min;
md += mm.Mul;
foreach (var el in md.GetInvocationList())
{
    Console.WriteLine(el.Method.Name);
}
md.Invoke(3, 4);
md(3, 4);*/
MessageDisplayer displayer = new MessageDisplayer();


DisplayMessageDelegate delegateUpperCase = displayer.DisplayUpperCase;
DisplayMessageDelegate delegateLowerCase = displayer.DisplayLowerCase;
DisplayMessageDelegate delegateLength = displayer.DisplayLength;
DisplayMessageDelegate delegateRed = displayer.DisplayRed;

delegateUpperCase("Good evening");
delegateLowerCase("Good evening");
delegateLength("Good evening");
delegateRed("Good evening");
