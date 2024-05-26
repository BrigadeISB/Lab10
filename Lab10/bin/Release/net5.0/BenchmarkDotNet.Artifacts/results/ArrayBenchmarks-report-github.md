```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4412/22H2/2022Update)
12th Gen Intel Core i5-12450H, 1 CPU, 12 logical and 8 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  Job-SEUQGR : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2

IterationCount=10  RunStrategy=Throughput  WarmupCount=5  

```
| Method     | N   | ArrayType       | Mean       | Error     | StdDev    | Gen0   | Allocated |
|----------- |---- |---------------- |-----------:|----------:|----------:|-------:|----------:|
| **BubbleSort** | **5**   | **Random**          |  **0.5224 ns** | **0.0049 ns** | **0.0033 ns** | **0.0001** |         **-** |
| QuickSort  | 5   | Random          |  1.2220 ns | 0.0264 ns | 0.0174 ns | 0.0002 |       1 B |
| **BubbleSort** | **5**   | **PartiallySorted** |  **0.5336 ns** | **0.0198 ns** | **0.0131 ns** | **0.0001** |         **-** |
| QuickSort  | 5   | PartiallySorted |  1.1897 ns | 0.0129 ns | 0.0077 ns | 0.0002 |       1 B |
| **BubbleSort** | **5**   | **ManyDuplicates**  |  **0.5099 ns** | **0.0036 ns** | **0.0024 ns** | **0.0001** |         **-** |
| QuickSort  | 5   | ManyDuplicates  |  1.2988 ns | 0.0086 ns | 0.0057 ns | 0.0002 |       1 B |
| **BubbleSort** | **10**  | **Random**          |  **0.7900 ns** | **0.0032 ns** | **0.0017 ns** | **0.0001** |       **1 B** |
| QuickSort  | 10  | Random          |  1.7164 ns | 0.0090 ns | 0.0053 ns | 0.0002 |       1 B |
| **BubbleSort** | **10**  | **PartiallySorted** |  **0.8203 ns** | **0.0152 ns** | **0.0100 ns** | **0.0001** |       **1 B** |
| QuickSort  | 10  | PartiallySorted |  1.7211 ns | 0.0219 ns | 0.0130 ns | 0.0002 |       1 B |
| **BubbleSort** | **10**  | **ManyDuplicates**  |  **0.7176 ns** | **0.0067 ns** | **0.0044 ns** | **0.0001** |       **1 B** |
| QuickSort  | 10  | ManyDuplicates  |  2.0890 ns | 0.0145 ns | 0.0096 ns | 0.0002 |       1 B |
| **BubbleSort** | **25**  | **Random**          |  **2.5571 ns** | **0.0725 ns** | **0.0479 ns** | **0.0002** |       **1 B** |
| QuickSort  | 25  | Random          |  4.1689 ns | 0.1219 ns | 0.0806 ns | 0.0004 |       3 B |
| **BubbleSort** | **25**  | **PartiallySorted** |  **2.6486 ns** | **0.0411 ns** | **0.0245 ns** | **0.0002** |       **1 B** |
| QuickSort  | 25  | PartiallySorted |  3.5381 ns | 0.0568 ns | 0.0376 ns | 0.0004 |       3 B |
| **BubbleSort** | **25**  | **ManyDuplicates**  |  **2.3959 ns** | **0.0825 ns** | **0.0546 ns** | **0.0002** |       **1 B** |
| QuickSort  | 25  | ManyDuplicates  |  4.5115 ns | 0.0709 ns | 0.0422 ns | 0.0004 |       3 B |
| **BubbleSort** | **50**  | **Random**          |  **9.2632 ns** | **0.1534 ns** | **0.0913 ns** | **0.0004** |       **2 B** |
| QuickSort  | 50  | Random          |  6.8222 ns | 0.0849 ns | 0.0561 ns | 0.0007 |       4 B |
| **BubbleSort** | **50**  | **PartiallySorted** |  **9.3947 ns** | **0.1366 ns** | **0.0903 ns** | **0.0004** |       **2 B** |
| QuickSort  | 50  | PartiallySorted |  7.1274 ns | 0.3129 ns | 0.1862 ns | 0.0007 |       4 B |
| **BubbleSort** | **50**  | **ManyDuplicates**  |  **8.4246 ns** | **0.0706 ns** | **0.0420 ns** | **0.0004** |       **2 B** |
| QuickSort  | 50  | ManyDuplicates  |  8.0009 ns | 0.0528 ns | 0.0314 ns | 0.0007 |       4 B |
| **BubbleSort** | **75**  | **Random**          | **19.7316 ns** | **0.1313 ns** | **0.0781 ns** | **0.0005** |       **3 B** |
| QuickSort  | 75  | Random          | 12.0394 ns | 0.5480 ns | 0.3625 ns | 0.0010 |       7 B |
| **BubbleSort** | **75**  | **PartiallySorted** | **19.7471 ns** | **0.4060 ns** | **0.2123 ns** | **0.0005** |       **3 B** |
| QuickSort  | 75  | PartiallySorted | 11.3733 ns | 0.1008 ns | 0.0600 ns | 0.0010 |       7 B |
| **BubbleSort** | **75**  | **ManyDuplicates**  | **18.6649 ns** | **0.3219 ns** | **0.1915 ns** | **0.0005** |       **3 B** |
| QuickSort  | 75  | ManyDuplicates  | 15.2075 ns | 0.5589 ns | 0.3697 ns | 0.0010 |       7 B |
| **BubbleSort** | **100** | **Random**          | **33.9526 ns** | **0.2140 ns** | **0.1415 ns** | **0.0006** |       **4 B** |
| QuickSort  | 100 | Random          | 13.7528 ns | 0.1456 ns | 0.0867 ns | 0.0013 |       8 B |
| **BubbleSort** | **100** | **PartiallySorted** | **34.5692 ns** | **0.4130 ns** | **0.2458 ns** | **0.0006** |       **4 B** |
| QuickSort  | 100 | PartiallySorted | 13.7932 ns | 0.1607 ns | 0.0956 ns | 0.0013 |       8 B |
| **BubbleSort** | **100** | **ManyDuplicates**  | **33.6194 ns** | **0.2179 ns** | **0.1297 ns** | **0.0006** |       **4 B** |
| QuickSort  | 100 | ManyDuplicates  | 17.5483 ns | 0.5038 ns | 0.2998 ns | 0.0013 |       8 B |
