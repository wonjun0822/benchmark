``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2486)
12th Gen Intel Core i7-12700K, 1 CPU, 20 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                                      Method |          Mean |         Error |        StdDev |       Gen0 |       Gen1 |      Gen2 |    Allocated |
|-------------------------------------------- |--------------:|--------------:|--------------:|-----------:|-----------:|----------:|-------------:|
|      Serialization_Text_Newtonsoft_To_Small |      71.99 μs |      0.270 μs |      0.239 μs |     7.5684 |     1.4648 |         - |     97.07 KB |
|     Serialization_Text_Newtonsoft_To_Medium |   7,521.22 μs |     33.141 μs |     27.674 μs |   375.0000 |   296.8750 |         - |    9292.6 KB |
|      Serialization_Text_Newtonsoft_To_Large | 910,780.19 μs | 11,162.418 μs | 10,441.333 μs | 39000.0000 | 38000.0000 | 1000.0000 | 935565.12 KB |
|  Serialization_Text_SystemTextJson_To_Small |      31.92 μs |      0.128 μs |      0.120 μs |     3.4180 |     0.4883 |         - |     44.22 KB |
| Serialization_Text_SystemTextJson_To_Medium |   4,391.48 μs |     15.249 μs |     14.264 μs |     7.8125 |     7.8125 |    7.8125 |   4395.59 KB |
|  Serialization_Text_SystemTextJson_To_Large | 402,436.92 μs |  1,643.031 μs |  1,536.892 μs |          - |          - |         - | 443470.55 KB |
|        Serialization_Text_SpanJson_To_Small |      18.70 μs |      0.111 μs |      0.099 μs |     3.4180 |     0.4883 |         - |      43.9 KB |
|       Serialization_Text_SpanJson_To_Medium |   3,117.34 μs |     15.711 μs |     13.120 μs |    11.7188 |    11.7188 |   11.7188 |   4396.98 KB |
|        Serialization_Text_SpanJson_To_Large | 227,991.88 μs |  2,005.815 μs |  1,876.240 μs |          - |          - |         - | 443540.52 KB |
