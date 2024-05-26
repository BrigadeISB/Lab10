using Benchmark;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Exporters;
using BenchmarkDotNet.Jobs;
using System;

[Config(typeof(BenchmarkConfig))]
public class ArrayBenchmarks
{
    [Params(10, 100, 1000, 10000, 100000)]
    public int N;

    [Params(ArrayType.Random, ArrayType.PartiallySorted, ArrayType.ManyDuplicates)]
    public ArrayType ArrayType;

    private int[] data;

    [GlobalSetup]
    public void Setup()
    {
        data = ArrayDataGenerator.GenerateArray(N, ArrayType);
    }

    [Benchmark(OperationsPerInvoke = 100)]
    public void BubbleSort()
    {
        var tempArray = (int[])data.Clone();
        SortingAlgorithms.BubbleSort(tempArray);
    }

    [Benchmark(OperationsPerInvoke = 50)]
    public void QuickSort()
    {
        var tempArray = (int[])data.Clone();
        SortingAlgorithms.QuickSort(tempArray);
    }

}
