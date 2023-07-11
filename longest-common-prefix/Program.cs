// See https://aka.ms/new-console-template for more information
using longest_common_prefix;

Console.WriteLine("Hello, World!");

var a = new Solution();

var str1 = new string[] { "flower", "flow", "flight" };
var str2 = new string[] { "dog", "racecar", "car" };
var str3 = new string[] { "a" };
var str4 = new string[] { "baab", "bacb", "b", "cbc" };
var str5 = new string[] { "reflower", "flow", "flight" };




var ret1 = a.LongestCommonPrefix(str1);
//var ret2 = a.LongestCommonPrefix(str2);
//var ret3 = a.LongestCommonPrefix(str3);
//var ret4 = a.LongestCommonPrefix(str4);
//var ret5 = a.LongestCommonPrefix(str5);
Console.WriteLine(ret1);
//Console.WriteLine(ret2);
//Console.WriteLine(ret3);
//Console.WriteLine(ret4);
//Console.WriteLine(ret5);