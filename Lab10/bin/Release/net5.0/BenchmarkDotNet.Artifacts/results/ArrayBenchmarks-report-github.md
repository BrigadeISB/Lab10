```

BenchmarkDotNet v0.13.12, Windows 10 (10.0.19045.4412/22H2/2022Update)
12th Gen Intel Core i5-12450H, 1 CPU, 12 logical and 8 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
  Job-TFQQVO : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2

IterationCount=10  RunStrategy=Throughput  WarmupCount=5  

```
| Method     | N   | ArrayType       | Mean       | Error     | StdDev    | Gen0   | Allocated |
|----------- |---- |---------------- |-----------:|----------:|----------:|-------:|----------:|
| **BubbleSort** | **5**   | **Random**          |  **0.5610 ns** | **0.0064 ns** | **0.0038 ns** | **0.0001** |         **-** |
| QuickSort  | 5   | Random          |  1.2417 ns | 0.0240 ns | 0.0125 ns | 0.0002 |       1 B |
| **BubbleSort** | **5**   | **PartiallySorted** |  **0.5493 ns** | **0.0060 ns** | **0.0040 ns** | **0.0001** |         **-** |
| QuickSort  | 5   | PartiallySorted |  1.2478 ns | 0.0211 ns | 0.0140 ns | 0.0002 |       1 B |
| **BubbleSort** | **5**   | **ManyDuplicates**  |  **0.5488 ns** | **0.0165 ns** | **0.0098 ns** | **0.0001** |         **-** |
| QuickSort  | 5   | ManyDuplicates  |  1.3716 ns | 0.0299 ns | 0.0198 ns | 0.0002 |       1 B |
| **BubbleSort** | **10**  | **Random**          |  **0.8430 ns** | **0.0156 ns** | **0.0093 ns** | **0.0001** |       **1 B** |
| QuickSort  | 10  | Random          |  1.8208 ns | 0.0385 ns | 0.0229 ns | 0.0002 |       1 B |
| **BubbleSort** | **10**  | **PartiallySorted** |  **0.8533 ns** | **0.0186 ns** | **0.0123 ns** | **0.0001** |       **1 B** |
| QuickSort  | 10  | PartiallySorted |  1.9146 ns | 0.0760 ns | 0.0503 ns | 0.0002 |       1 B |
| **BubbleSort** | **10**  | **ManyDuplicates**  |  **0.7798 ns** | **0.0190 ns** | **0.0099 ns** | **0.0001** |       **1 B** |
| QuickSort  | 10  | ManyDuplicates  |  2.4046 ns | 0.0719 ns | 0.0428 ns | 0.0002 |       1 B |
| **BubbleSort** | **25**  | **Random**          |  **2.7588 ns** | **0.0378 ns** | **0.0250 ns** | **0.0002** |       **1 B** |
| QuickSort  | 25  | Random          |  4.3229 ns | 0.1758 ns | 0.1163 ns | 0.0004 |       3 B |
| **BubbleSort** | **25**  | **PartiallySorted** |  **2.6984 ns** | **0.0233 ns** | **0.0154 ns** | **0.0002** |       **1 B** |
| QuickSort  | 25  | PartiallySorted |  3.6354 ns | 0.0310 ns | 0.0205 ns | 0.0004 |       3 B |
| **BubbleSort** | **25**  | **ManyDuplicates**  |  **2.4586 ns** | **0.0989 ns** | **0.0654 ns** | **0.0002** |       **1 B** |
| QuickSort  | 25  | ManyDuplicates  |  4.7311 ns | 0.1442 ns | 0.0954 ns | 0.0004 |       3 B |
| **BubbleSort** | **50**  | **Random**          |  **9.3343 ns** | **0.0827 ns** | **0.0547 ns** | **0.0003** |       **2 B** |
| QuickSort  | 50  | Random          |  6.9786 ns | 0.0550 ns | 0.0363 ns | 0.0007 |       4 B |
| **BubbleSort** | **50**  | **PartiallySorted** |  **9.5102 ns** | **0.1532 ns** | **0.0911 ns** | **0.0003** |       **2 B** |
| QuickSort  | 50  | PartiallySorted |  7.1399 ns | 0.3439 ns | 0.2275 ns | 0.0007 |       4 B |
| **BubbleSort** | **50**  | **ManyDuplicates**  |  **8.8484 ns** | **0.1932 ns** | **0.1150 ns** | **0.0003** |       **2 B** |
| QuickSort  | 50  | ManyDuplicates  |  8.7703 ns | 0.2118 ns | 0.1401 ns | 0.0007 |       4 B |
| **BubbleSort** | **75**  | **Random**          | **20.3638 ns** | **0.2793 ns** | **0.1662 ns** | **0.0005** |       **3 B** |
| QuickSort  | 75  | Random          | 12.1966 ns | 0.1336 ns | 0.0883 ns | 0.0010 |       7 B |
| **BubbleSort** | **75**  | **PartiallySorted** | **20.5629 ns** | **0.2871 ns** | **0.1899 ns** | **0.0005** |       **3 B** |
| QuickSort  | 75  | PartiallySorted | 11.9359 ns | 0.1754 ns | 0.1044 ns | 0.0010 |       7 B |
| **BubbleSort** | **75**  | **ManyDuplicates**  | **20.5464 ns** | **1.1946 ns** | **0.7109 ns** | **0.0005** |       **3 B** |
| QuickSort  | 75  | ManyDuplicates  | 16.1323 ns | 0.7056 ns | 0.3690 ns | 0.0010 |       7 B |
| **BubbleSort** | **100** | **Random**          | **36.5791 ns** | **1.4594 ns** | **0.9653 ns** | **0.0006** |       **4 B** |
| QuickSort  | 100 | Random          | 14.4196 ns | 0.2138 ns | 0.1272 ns | 0.0013 |       8 B |
| **BubbleSort** | **100** | **PartiallySorted** | **35.8347 ns** | **0.3376 ns** | **0.2233 ns** | **0.0006** |       **4 B** |
| QuickSort  | 100 | PartiallySorted | 14.4899 ns | 0.1429 ns | 0.0946 ns | 0.0013 |       8 B |
| **BubbleSort** | **100** | **ManyDuplicates**  | **35.1091 ns** | **0.3708 ns** | **0.2453 ns** | **0.0006** |       **4 B** |
| QuickSort  | 100 | ManyDuplicates  | 18.1069 ns | 0.1338 ns | 0.0700 ns | 0.0013 |       8 B |
