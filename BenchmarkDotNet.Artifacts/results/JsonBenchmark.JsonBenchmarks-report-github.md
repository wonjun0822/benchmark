``` ini

BenchmarkDotNet=v0.13.4, OS=Windows 10 (10.0.19045.2486)
12th Gen Intel Core i7-12700K, 1 CPU, 20 logical and 12 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                                      Method |            Mean |          Error |         StdDev |          Median | Rank | Completed Work Items | Lock Contentions |       Gen0 |       Gen1 |      Gen2 |     Allocated |
|-------------------------------------------- |----------------:|---------------:|---------------:|----------------:|-----:|---------------------:|-----------------:|-----------:|-----------:|----------:|--------------:|
|        Serialization_Text_SpanJson_To_Small |        41.16 μs |       0.596 μs |       0.558 μs |        40.99 μs |    1 |                    - |                - |     3.3569 |     0.4272 |         - |      43.62 KB |
|      Serialization_Text_Newtonsoft_To_Small |        74.18 μs |       0.698 μs |       0.653 μs |        74.16 μs |    2 |                    - |                - |     7.5684 |     1.8311 |         - |      97.13 KB |
|  Serialization_Text_SystemTextJson_To_Small |        75.73 μs |       1.234 μs |       1.094 μs |        75.53 μs |    3 |                    - |                - |     3.4180 |     0.4883 |         - |       44.2 KB |
|        Serialization_Text_FastJson_To_Small |       150.44 μs |       2.175 μs |       2.035 μs |       149.96 μs |    4 |                    - |                - |    13.6719 |     3.4180 |         - |     176.94 KB |
|       Serialization_Text_SpanJson_To_Medium |     6,060.86 μs |     109.844 μs |     130.762 μs |     6,085.38 μs |    5 |                    - |                - |     7.8125 |     7.8125 |    7.8125 |     4394.7 KB |
|     Serialization_Text_Newtonsoft_To_Medium |     8,084.48 μs |     158.893 μs |     256.583 μs |     8,037.08 μs |    6 |                    - |                - |   375.0000 |   296.8750 |         - |    9289.92 KB |
| Serialization_Text_SystemTextJson_To_Medium |     8,426.76 μs |     166.367 μs |     304.211 μs |     8,389.43 μs |    7 |                    - |                - |          - |          - |         - |    4396.98 KB |
|       Serialization_Text_FastJson_To_Medium |    16,322.73 μs |     322.149 μs |     472.201 μs |    16,253.23 μs |    8 |                    - |                - |   750.0000 |   625.0000 |         - |   16462.97 KB |
|        Serialization_Text_SpanJson_To_Large |   470,224.07 μs |   8,978.238 μs |   8,398.249 μs |   467,650.10 μs |    9 |                    - |                - |          - |          - |         - |  443575.64 KB |
|  Serialization_Text_SystemTextJson_To_Large |   860,759.69 μs |  16,243.516 μs |  13,564.071 μs |   862,960.30 μs |   10 |                    - |                - |          - |          - |         - |  443476.04 KB |
|      Serialization_Text_Newtonsoft_To_Large | 1,443,230.66 μs | 125,544.632 μs | 370,171.179 μs | 1,692,709.40 μs |   11 |                    - |                - | 39000.0000 | 38000.0000 | 1000.0000 |  935556.08 KB |
|        Serialization_Text_FastJson_To_Large | 1,819,561.52 μs | 128,259.597 μs | 378,176.316 μs | 1,995,183.45 μs |   12 |                    - |                - | 76000.0000 | 75000.0000 | 1000.0000 | 1642510.78 KB |
