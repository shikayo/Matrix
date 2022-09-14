``` ini

BenchmarkDotNet=v0.13.2, OS=Windows 10 (10.0.19044.1889/21H2/November2021Update)
AMD Ryzen 5 3500U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.101
  [Host]     : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2
  DefaultJob : .NET 6.0.1 (6.0.121.56705), X64 RyuJIT AVX2


```
|  Method |     Mean |   Error |  StdDev |
|-------- |---------:|--------:|--------:|
| CalcIJK | 104.4 ns | 2.20 ns | 4.50 ns |
| CalcIKJ | 103.3 ns | 2.06 ns | 2.20 ns |
| CalcJIK | 102.2 ns | 1.35 ns | 1.27 ns |
| CalcJKI | 102.4 ns | 1.70 ns | 1.59 ns |
| CalcKIJ | 102.9 ns | 2.16 ns | 2.12 ns |
| CalcKJI | 102.1 ns | 1.96 ns | 1.92 ns |
