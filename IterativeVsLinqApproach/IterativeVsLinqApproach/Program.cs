// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using IterativeVsLinqApproach;

Console.WriteLine("Mapping using Iterative and LINQ");

var summary = BenchmarkRunner.Run<BenchMarkTest>();
