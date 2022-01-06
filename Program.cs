// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using LeetcodeFancySequence;

var fancy = new Fancy();
fancy.Append(2);   // fancy sequence: [2]
fancy.AddAll(3);   // fancy sequence: [2+3] -> [5]
fancy.Append(7);   // fancy sequence: [5, 7]
fancy.MultAll(2);  // fancy sequence: [5*2, 7*2] -> [10, 14]
fancy.GetIndex(0); // return 10
fancy.AddAll(3);   // fancy sequence: [10+3, 14+3] -> [13, 17]
fancy.Append(10);  // fancy sequence: [13, 17, 10]
fancy.MultAll(2);  // fancy sequence: [13*2, 17*2, 10*2] -> [26, 34, 20]
Debug.Assert(fancy.GetIndex(0) == 26); // return 26
Debug.Assert(fancy.GetIndex(1) == 34); // return 34
Debug.Assert(fancy.GetIndex(2) == 20); // return 20


//var cmd = new String[]
//{
//    "Fancy", "append", "append", "getIndex",
//    "append", "getIndex", "addAll", "append", "getIndex",
//    "getIndex", "append", "append", "getIndex", "append",
//    "getIndex", "append", "getIndex", "append", "getIndex",
//    "multAll", "addAll", "getIndex", "append", "addAll",
//    "getIndex", "multAll", "getIndex", "multAll", "addAll",
//    "addAll", "append", "multAll", "append", "append", "append",
//    "multAll", "getIndex", "multAll", "multAll", "multAll",
//    "getIndex", "addAll", "append", "multAll", "addAll",
//    "addAll", "multAll", "addAll", "addAll", "append", "append", "getIndex"
//};

////["Fancy","append","append","getIndex","append","getIndex","addAll","append","getIndex","getIndex","append","append","getIndex","append","getIndex","append","getIndex","append","getIndex","multAll","addAll","getIndex","append","addAll","getIndex","multAll","getIndex","multAll","addAll","addAll","append","multAll","append","append","append","multAll","getIndex","multAll","multAll","multAll","getIndex","addAll","append","multAll","addAll","addAll","multAll","addAll","addAll","append","append","getIndex"]
////[[],[12],[8],[1],[12],[0],[12],[8],[2],[2],[4],[13],[4],[12],[6],[11],[1],[10],[2],[3],[1],[6],[14],[5],[6],[12],[3],[12],[15],[6],[7],[8],[13],[15],[15],[10],[9],[12],[12],[9],[9],[9],[9],[4],[8],[11],[15],[9],[1],[4],[10],[9]]

//var arg = new int[]
//{
//  0,12,8,1,12,0,12,8,2,2,4,13,4,12,6,11,1,10,2,3,1,
//  6,14,5,6,12,3,12,15,6,7,8,13,15,15,10,9,12,12,9,9,
//  9,9,4,8,11,15,9,1,4,10,9
//};

//var codeGen = new CodeGen();
//codeGen.Generate(cmd, arg);

//Console.ReadLine();


fancy = new Fancy();
fancy.Append(12);
fancy.Append(8);
fancy.GetIndex(1);
fancy.Append(12);
fancy.GetIndex(0);
fancy.AddAll(12);
fancy.Append(8);
fancy.GetIndex(2);
fancy.GetIndex(2);
fancy.Append(4);
fancy.Append(13);
fancy.GetIndex(4);
fancy.Append(12);
fancy.GetIndex(6);
fancy.Append(11);
fancy.GetIndex(1);
fancy.Append(10);
fancy.GetIndex(2);
fancy.MultAll(3);
fancy.AddAll(1);
fancy.GetIndex(6);
fancy.Append(14);
fancy.AddAll(5);
fancy.GetIndex(6);
fancy.MultAll(12);
fancy.GetIndex(3);
fancy.MultAll(12);
fancy.AddAll(15);
fancy.AddAll(6);
fancy.Append(7);
fancy.MultAll(8);
fancy.Append(13);
fancy.Append(15);
fancy.Append(15);
fancy.MultAll(10);
fancy.GetIndex(9);
fancy.MultAll(12);
fancy.MultAll(12);
fancy.MultAll(9);
fancy.GetIndex(9);

fancy.AddAll(9);
fancy.Append(9);
fancy.MultAll(4);
fancy.AddAll(8);
fancy.AddAll(11);
fancy.MultAll(15);
fancy.AddAll(9);
fancy.AddAll(1);
fancy.Append(4);
fancy.Append(10);

var answer = fancy.GetIndex(9);

Debug.Assert(answer == 150746316);


