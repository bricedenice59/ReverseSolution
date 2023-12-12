using System.Text;
using BenchmarkDotNet.Attributes;

namespace Reverse;

[MemoryDiagnoser]
public class ReverseBenchmark
{
    private const int NbChars = 1_000_000;
    private string? _str;

    [GlobalSetup]
    public void GlobalSetup()
    {
        _str = Utils.GenerateRandomAlphanumericString(NbChars);
    }

    [Benchmark]
    public string ReverseStringOptimized()
    {
        return _str!.ReverseStringOptimized();
    }

    [Benchmark]
    public string ReverseStringWithStringBuilder()
    {
        return _str!.ReverseStringWithStringBuilder();
    }

    [Benchmark]
    public string ReverseStringWithSLinq()
    {
        return new string(_str!.Reverse().ToArray());
    }
}