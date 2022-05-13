// Program.cs

using lab5_1B;
VectorN s = new VectorN(3, new double[] { 1, 2, 3 });
Console.WriteLine("Vector s:");
s.Display();
Console.WriteLine("Vector s after changes (s + s):");
s = s + s;
s.Display();
Console.WriteLine($"Scalar (s, s): {s * s}\n");

VectorN v = new VectorN();
v.Read();
Console.WriteLine("Vector V:");
v.Display();
Console.WriteLine("Vector S:");
s.Display();
Console.WriteLine($"Scalar (s, v): {s * v}");
Console.WriteLine("Vector C = S - V");
VectorN res = s - v;
res.Display();
Console.WriteLine("Vector C = ++S - V--:");
res = ++s - v.PostDecrement();
res.Display();
Console.WriteLine("\nVector V:");
v.Display();
Console.WriteLine("Vector S:");
s.Display();

VectorN b = new VectorN(v);
Console.WriteLine("Vector B:");
b.Display();

Console.ReadKey();