``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2486)
12th Gen Intel Core i7-12700K, 1 CPU, 20 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
| Method |     Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|------- |---------:|----------:|----------:|-------:|-------:|----------:|
|   Test | 1.984 μs | 0.0388 μs | 0.0626 μs | 1.8158 | 0.0038 |  23.18 KB |
