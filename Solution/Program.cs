// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using LeetcodeFancySequence;


var cmd = new string[]
{
    "Fancy", "append", "getIndex", "multAll", "multAll", "getIndex", "addAll", "append", "append", "getIndex", "append",
    "append", "addAll", "getIndex", "multAll", "addAll", "append", "addAll", "getIndex", "getIndex", "multAll",
    "multAll", "multAll", "append", "addAll", "getIndex", "getIndex", "getIndex", "append", "getIndex", "addAll",
    "multAll", "append", "multAll", "addAll", "getIndex", "append", "append", "addAll", "getIndex", "multAll",
    "getIndex", "addAll", "getIndex", "multAll", "addAll", "getIndex", "addAll", "append", "append", "append",
    "multAll", "multAll", "append", "multAll", "addAll", "getIndex", "addAll", "multAll", "multAll", "multAll",
    "append", "multAll", "append", "multAll", "addAll", "append", "append", "getIndex", "getIndex", "getIndex",
    "addAll", "multAll", "multAll", "append", "append", "getIndex", "append", "append", "append", "getIndex", "getIndex"
};

var argz = new int[]
{
    0, 5, 0, 14, 10, 0, 12, 10, 4, 2, 4, 2, 1, 1, 8, 11, 15, 12, 0, 3, 4, 11, 11, 10, 8, 2, 3, 0, 7, 3, 2, 6, 10, 6, 8,
    7, 9, 9, 12, 0, 13, 7, 3, 4, 8, 14, 2, 9, 9, 9, 7, 5, 12, 9, 3, 8, 10, 14, 14, 14, 6, 1, 3, 11, 12, 6, 7, 13, 12, 5,
    6, 1, 11, 11, 4, 9, 7, 11, 1, 3, 1, 0
};


var codeGen = new CodeGen();
codeGen.Generate(cmd, argz);

//Console.ReadLine();






