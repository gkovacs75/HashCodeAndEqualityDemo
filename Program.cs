using HashCodeDemo;


PointA p1 = new PointA(100, 100);
PointA p1b = new PointA(100, 100);
PointA p2 = new PointA(100, 200);
PointA p3 = new PointA(100, 300);
PointA p4 = new PointA(100, 400);

// Test object equality
Console.Write("p1 == p1. Expect: True. Result: ");
Console.WriteLine(p1 == p1);
Console.WriteLine();

// Test object equality
Console.Write("p1 == p1b. Expect: False. Result: ");
Console.WriteLine(p1 == p1b);
Console.WriteLine();

// Test values equality
Console.Write("p1.Equals(p1). Expect: True. Result: ");
Console.WriteLine(p1.Equals(p1));
Console.WriteLine();

// Test values equality
Console.Write("p1.Equals(p2). Expect: False. Result: ");
Console.WriteLine(p1.Equals(p2));
Console.WriteLine();



Console.WriteLine();

// Test Hash Code
Dictionary<PointA, string> dic = new Dictionary<PointA, string>();

Console.Write("dic.Add(p1, 'p1')");
dic.Add(p1, "p1");

Console.WriteLine();

Console.Write("dic.Add(p2, 'p2')");
dic.Add(p2, "p2");

Console.WriteLine();

Console.Write("dic.ContainsKey(p1b). Expect: True. Result:  ");
Console.WriteLine(dic.ContainsKey(p1b));
Console.WriteLine();
Console.Write("dic.ContainsKey(p4). Expect: False. Result:  ");
Console.WriteLine(dic.ContainsKey(p4));

