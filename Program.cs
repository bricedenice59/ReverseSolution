// See https://aka.ms/new-console-template for more information

using System.Globalization;
using BenchmarkDotNet.Running;
using Reverse;

var summary = BenchmarkRunner.Run<ReverseBenchmark>();
