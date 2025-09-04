using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static ConsoleApp1.ListGenerators;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ------------------ Restriction Operators ------------------ //

            // 1
            var outOfStock = ProductList.Where(p => p.UnitsInStock == 0);

            // 2
            var inStockExpensive = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            // 3
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var shortDigits = digits.Where((name, index) => name.Length < index);




            // ------------------ Element Operators ------------------ //

            // 1
            var firstOutOfStock = ProductList.First(p => p.UnitsInStock == 0);

            // 2
            var pricey = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            // 3
            int[] arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var secondGreaterThan5 = arr1.Where(n => n > 5).Skip(1).FirstOrDefault();









            // ------------------Aggregate Operators ------------------ //

            int[] arr2 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // 1
            var oddCount = arr2.Count(n => n % 2 != 0);

            // 2
            var custOrders = CustomerList.Select(c => new { c.Name, OrderCount = c.Orders.Length });

            // 3
            var categoryCounts = ProductList.GroupBy(p => p.Category)
                                            .Select(g => new { Category = g.Key, Count = g.Count() });

            // 4
            var total = arr2.Sum();

            // 5
            string[] dict = File.ReadAllLines("dictionary_english.txt");
            var totalChars = dict.Sum(w => w.Length);

            // 6
            var unitsPerCategory = ProductList.GroupBy(p => p.Category)
                                              .Select(g => new { Category = g.Key, Units = g.Sum(p => p.UnitsInStock) });

            // 7
            var minWordLength = dict.Min(w => w.Length);

            // 8
            var cheapestPerCategory = ProductList.GroupBy(p => p.Category)
                                                 .Select(g => new { Category = g.Key, MinPrice = g.Min(p => p.UnitPrice) });

            // 9
            var cheapestProducts = ProductList.GroupBy(p => p.Category)
                                              .SelectMany(g =>
                                              {
                                                  var minPrice = g.Min(p => p.UnitPrice);
                                                  return g.Where(p => p.UnitPrice == minPrice);
                                              });

            // 10
            var maxWordLength = dict.Max(w => w.Length);

            // 11
            var maxPricePerCategory = ProductList.GroupBy(p => p.Category)
                                                 .Select(g => new { Category = g.Key, MaxPrice = g.Max(p => p.UnitPrice) });

            // 12
            var mostExpProducts = ProductList.GroupBy(p => p.Category)
                                             .SelectMany(g =>
                                             {
                                                 var maxPrice = g.Max(p => p.UnitPrice);
                                                 return g.Where(p => p.UnitPrice == maxPrice);
                                             });

            // 13
            var avgWordLength = dict.Average(w => w.Length);

            // 14
            var avgPricePerCategory = ProductList.GroupBy(p => p.Category)
                                                 .Select(g => new { Category = g.Key, AvgPrice = g.Average(p => p.UnitPrice) });




            // ---------------- Ordering Operators------------------ //

            // 1
            var sortByName = ProductList.OrderBy(p => p.ProductName);

            // 2
            string[] words1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            var caseInsensitiveSort = words1.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            // 3
            var sortByStockDesc = ProductList.OrderByDescending(p => p.UnitsInStock);

            // 4
            var sortDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);

            // 5
            var sortWordsLenCI = words1.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            // 6
            var sortCatPrice = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            // 7
            var sortWordsLenCIDesc = words1.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            // 8
            var secondLetterI = digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse();





            // ------------------ Transformation Operators----------------- //

            // 1
            var productNames = ProductList.Select(p => p.ProductName);

            // 2
            string[] words2 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var upperLower = words2.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });

            // 3
            var productProps = ProductList.Select(p => new { p.ProductID, p.ProductName, Price = p.UnitPrice });

            // 4
            var numPos = arr2.Select((n, i) => new { Number = n, InPlace = n == i });

            // 5
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select new { A = a, B = b };

            // 6
            var cheapOrders = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);

            // 7
            var orders1998 = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);







            // ----------------Partitioning Operators------------------ //

            // 1
            var first3WA = CustomerList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Take(3);

            // 2
            var skip2WA = CustomerList.Where(c => c.City == "Washington").SelectMany(c => c.Orders).Skip(2);

            // 3
            var takeUntilLess = arr2.TakeWhile((n, i) => n >= i);

            // 4
            var skipUntilDiv3 = arr2.SkipWhile(n => n % 3 != 0);

            // 5
            var skipUntilLess = arr2.SkipWhile((n, i) => n >= i);

            // -----------------Quantifiers ------------------ //

            // 1
            var hasEi = dict.Any(w => w.Contains("ei"));

            // 2
            var catWithOutOfStock = ProductList.GroupBy(p => p.Category)
                                               .Where(g => g.Any(p => p.UnitsInStock == 0));

            // 3
            var catAllInStock = ProductList.GroupBy(p => p.Category)
                                           .Where(g => g.All(p => p.UnitsInStock > 0));
        }
    }
}
