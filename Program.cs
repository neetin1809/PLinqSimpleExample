using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Diagnostics;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

IEnumerable<int> rvals = Enumerable.Range(0, 100000000);
var result = rvals.Where(x => x % 12345678 == 0).Select(x => x);

Stopwatch sq = Stopwatch.StartNew();

foreach (var item in result)
    Console.WriteLine(item);
Console.WriteLine("Time taken for processing: " + sq.ElapsedMilliseconds + "ms");

var result1 = rvals.AsParallel().Where(x => x % 12345678 == 0).Select(x => x);
sq.Restart();
System.Threading.Thread.Sleep(100);
foreach (var item in result1)
    Console.WriteLine(item);
Console.WriteLine("Time taken for processing(With Parallel Linq: " + sq.ElapsedMilliseconds + "ms");

