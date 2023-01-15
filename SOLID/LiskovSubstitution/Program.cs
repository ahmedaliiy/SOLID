using LiskovSubstitution.WithLiskovSubstitution;
using LiskovSubstitution.WithoutLiskovSubstitution;
using System;

// WithoutLiskovSubstitution
AppleWithoutLS apple = new OrangeWithoutLS();
Console.WriteLine(apple.GetColor());

// WithLiskovSubstitution
Fruit fruit = new OrangeWithLS();
Console.WriteLine(fruit.GetColor());
fruit = new AppleWithLS();
Console.WriteLine(fruit.GetColor());

Console.ReadLine();