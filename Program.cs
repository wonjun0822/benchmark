using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using JsonBenchmark;

var result = BenchmarkRunner.Run<JsonBenchmarks>();
