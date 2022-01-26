using System;
using Tutorial.Common.Extensions;
using Tutorial.Common.Helper;

"Bitwise Operators".DumpAsTitle();
"Bitwise operations provide a fast mechanism for opeartion on binary numbers at bit level".Dump();

ConsoleHelper.Seperate();

#region & Operator
"& (AND) Operator".Dump();

"Copies a bit if it exists in both operands".Dump();

$"6 & 4 => {6 & 4} | {Convert.ToString((6 & 4),2)}".Dump();

$"6 => 110".Dump();
$"4 => 100".Dump();
$"110 vs 100".Dump();
$"First operand => 0 && 0 => 0".Dump();
$"Second operand => 1 && 0 => 0".Dump();
$"Third operand => 1 && 1 => 1".Dump();
$"Result in base 2 => 100 => 4 ".Dump();
#endregion

ConsoleHelper.Seperate();

#region | Operator
"| (OR) Operator".Dump();

"Copies a bit if it exists in both operands".Dump();

$"6 & 4 => {6 | 4} | {Convert.ToString((6 | 4), 2)}".Dump();

$"6 => 110".Dump();
$"4 => 100".Dump();
$"110 vs 100".Dump();
$"First operand => 0 || 0 => 0".Dump();
$"Second operand => 1 || 0 => 1".Dump();
$"Third operand => 1 || 1 => 1".Dump();
$"Result in base 2 => 110 => 6 ".Dump();
#endregion

ConsoleHelper.Seperate();

#region ^ Operator
"^ (XOR) Operator".Dump();

"Copies a bit if it exists in one but not both operands".Dump();

$"6 ^ 4 => {6 ^ 4} | {Convert.ToString((6 ^ 4), 2)}".Dump();

$"6 => 110".Dump();
$"4 => 100".Dump();
$"110 vs 100".Dump();
$"First operand => 0 ^ 0 => 0".Dump();
$"Second operand => 1 ^ 0 => 1".Dump();
$"Third operand => 1 ^ 1 => 0".Dump();
$"Result in base 2 => 10 => 4 ".Dump();
#endregion

ConsoleHelper.Seperate();

#region ~ Operator
"~ (ONE's COMPLIMENT) Operator".Dump();

"Flips the beats".Dump();

$" ~6 => {~6} | {Convert.ToString((~6), 2)}".Dump();

$"6  => 32 bit   =>  00000000000000000000000000000110".Dump();
$"Bits Flipted   =>  11111111111111111111111111111001".Dump();
$"Result in base 2 => 11111111111111111111111111111001 => -7(due to overflow) ".Dump();

#endregion

ConsoleHelper.Seperate();

#region << Operator
"<< (LEFT SHIFT) Operator".Dump();

"Shifts the bits left".Dump();

$"6 << 1 => {6 << 1} | {Convert.ToString((6 << 1), 2)}".Dump();
$"6 => 0110 => 1100 => 12".Dump();
#endregion

ConsoleHelper.Seperate();

#region >> Operator
">> (RIGHT SHIFT) Operator".Dump();

"Shifts the bits right".Dump();

$"6 >> 1 => {6 >> 1} | {Convert.ToString((6 >> 1), 2)}".Dump();
$"6 => 0110 => 0011 => 3".Dump();
#endregion



