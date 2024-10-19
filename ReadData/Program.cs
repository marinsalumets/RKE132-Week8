using System;
using System.IO;

string filePath = @"/Users/MarinSalumets/projects/data/heroes.txt";

string[] dataFromFile = File.ReadAllLines(filePath);

foreach (string element in dataFromFile)
{
    Console.WriteLine(element);
}