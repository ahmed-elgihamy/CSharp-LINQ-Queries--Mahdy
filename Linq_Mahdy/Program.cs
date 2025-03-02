using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks.Dataflow;

namespace Linq_Mahdy
{
    internal class Program
    {


       public class Contractor:Employee { };
       public class CEO:Employee { };
      
        static void Main(string[] args)
        {

            #region Video 1
            //A list containing a set of numbers
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 4, 5 };

            //Deferred Execution
            // A LINQ query is not executed immediately; it is stored as a set of operations
            // that execute when the values are accessed.
            //var result = from i in numbers where i > 7 select i;
            //The variable "result" contains the query, not the actual values.
            // The query will be executed when accessing values, such as using result.ToList() or result.First().

            // ===========================
            // Immediate Execution
            // The query is executed immediately when using functions like:
            // ToList(), ToArray(), ToString(), etc.

            // Combining LINQ Query Syntax with Method Syntax
            //var result2 = from i in numbers.Where(x => x > 5) where i > 7 select i;

            //All aggregate functions are executed immediately
            //var sum = numbers.Where(x => x > 4).ToList().Sum();

            //Example of executing a query and displaying values
            //var result3 = numbers.Where(x => x > 4).ToList();
            //Console.WriteLine("Filtered Numbers:");
            //foreach (int i in result3)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Video 2

            //   List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 4, 5 };
            //  var result = from x in numbers where x > 2 orderby x   select x;
            // can not allow use order by once bafore where and anthor one after where

            // Correct approach using method chaining (Method Syntax)
            //  result = numbers.Where(x => x > 2).OrderByDescending(x => x);


            // var  result = from x in numbers orderby x descending where x > 2   select x;


            //var Emp = new List<Employee> {
            //       new("ahmed",23,540),
            //       new("ahmed",20,545),
            //       new("ali",22,545),
            //       new("omer",30,550),
            //       new Contractor {Name="Mahmoud" },
            //       new CEO {Name="ali"}

            //};

            // Sorting using Method Syntax
            // var query = Emp.OrderBy(x => x.Name).ThenBy(x => x.Age).ThenBy(x => x.Salary);

            // Sorting using Query Syntax
            //query = from em in Emp
            //        orderby em.Name, em.Age
            //        select em;


            //  var query = Emp.OrderBy(x => x.name).OrderBy(x => x.age).Reverse(); XXXXXXXXXXXX must use  with method syntex 
            //      var query = Emp.OrderBy(x => x.name).ThenBy(x => x.age);    

            // =========================== Transformation ===========================
            // Selecting only specific fields (Anonymous Type)
            //var transformedQuery = from em in Emp
            //                       orderby em.Name, em.Age
            //                       select new { EmpName = em.Name, EmpAge = em.Age };

            //// Another transformation using Method Syntax
            //var transformedQuery2 = Emp.OrderBy(x => x.Name)
            //                           .ThenBy(x => x.Age)
            //                           .Select(x => new { EmpName = x.Name, EmpAge = x.Age, x.Salary });

            //// Filtering CEOs only
            //var ceoQuery = Emp.OfType<CEO>().OrderBy(x => x.Name).ThenBy(x => x.Salary);

            //// Displaying results
            //foreach (var emp in query)
            //{
            //    Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}, Salary: {emp.Salary}");
            //}







            #endregion

            #region Video  3

            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 4, 5 };

            //// ========== Quantifiers ==========
            //// Checks if all elements are greater than 0
            //var allGreaterThanZero = numbers.All(x => x > 0);
            //Console.WriteLine($"All elements > 0: {allGreaterThanZero}");

            //// Checks if there is at least one element in the list
            //var hasElements = numbers.Any();
            //Console.WriteLine($"List has elements: {hasElements}");

            //// Checks if the list contains the number 7
            //var containsSeven = numbers.Contains(7);
            //Console.WriteLine($"List contains 7: {containsSeven}");

            //// ========== Partitioning ==========
            //Console.WriteLine("\nPartitioning Operations:");

            //// Takes the first 3 elements
            //var takeThree = numbers.Take(3);
            //Console.WriteLine("Take(3): " + string.Join(", ", takeThree));

            //// Skips the first 3 elements and takes the rest
            //var skipThree = numbers.Skip(3);
            //Console.WriteLine("Skip(3): " + string.Join(", ", skipThree));

            //// Takes the last 3 elements
            //var takeLastThree = numbers.TakeLast(3);
            //Console.WriteLine("TakeLast(3): " + string.Join(", ", takeLastThree));

            //// Skips the first 3 elements and then takes the next 3 elements
            //var skipAndTake = numbers.Skip(3).Take(3);
            //Console.WriteLine("Skip(3).Take(3): " + string.Join(", ", skipAndTake));

            //// Takes elements while the condition is true (stops at the first false case)
            //var takeWhileGreaterThanFour = numbers.TakeWhile(x => x > 4);
            //Console.WriteLine("TakeWhile(x > 4): " + string.Join(", ", takeWhileGreaterThanFour));

            //// Skips elements while the condition is true, then takes the remaining elements
            //var skipWhileGreaterThanFour = numbers.SkipWhile(x => x > 4);
            //Console.WriteLine("SkipWhile(x > 4): " + string.Join(", ", skipWhileGreaterThanFour));

            //// Splits the list into chunks of 3 elements each
            //var chunks = numbers.Chunk(3);
            //Console.WriteLine("\nChunk(3):");
            //foreach (var chunk in chunks)
            //{
            //    Console.WriteLine(string.Join(", ", chunk));
            //    Console.WriteLine("--------------------------------");
            //}

            //// ========== Set Operations ==========
            //Console.WriteLine("\nSet Operations:");
            //var secondList = new List<int> { 1, 2, 3, 4, 5 };

            //// Returns distinct elements (removes duplicates)
            //var distinctNumbers = numbers.Distinct();
            //Console.WriteLine("Distinct: " + string.Join(", ", distinctNumbers));

            //// Returns elements in `numbers` that are not in `secondList`
            //var exceptQuery = numbers.Except(secondList);
            //Console.WriteLine("Except(secondList): " + string.Join(", ", exceptQuery));

            //// Returns elements that exist in both `numbers` and `secondList`
            //var intersectQuery = numbers.Intersect(secondList);
            //Console.WriteLine("Intersect(secondList): " + string.Join(", ", intersectQuery));

            //// Returns all elements from both lists, removing duplicates
            //var unionQuery = numbers.Union(secondList);
            //Console.WriteLine("Union(secondList): " + string.Join(", ", unionQuery));

            // ========== Notes ==========
            // DistinctBy, ExceptBy, IntersectBy, and UnionBy work on complex objects (like classes).
            // They allow filtering based on a specific property of the objects.


            #endregion

            #region Video 4


            // var Emp = new List<Employee> {
            //        new("ahmed",23,540,1),
            //        new("Mahmoud",23,540,1),
            //        new("hoda",20,545,2),
            //        new("doaa",20,545,2),
            //        new("aya",20,545,2),
            //        new("ali",22,545,4),
            //        new("omer",30,550,3),


            // };

            // ===================== INNER JOIN =====================
            //        Console.WriteLine("=== Inner Join (Query Syntax) ===");
            //        var query1 = from emp in Emp
            //                     join dep in Dep on emp.DeptID equals dep.Id
            //                     select new { EmpName = emp.Name, DeptName = dep.Name };

            //        foreach (var item in query1)
            //        {
            //            Console.WriteLine($"Employee: {item.EmpName}, Department: {item.DeptName}");
            //        }

            //        // ===================== INNER JOIN (Method Syntax) =====================
            //        Console.WriteLine("\n=== Inner Join (Method Syntax) ===");
            //        var query2 = Emp.Join(Dep,
            //            emp => emp.DeptID,
            //            dep => dep.Id,
            //            (e, d) => new { EmpName = e.Name, DeptName = d.Name });

            //        foreach (var item in query2)
            //        {
            //            Console.WriteLine($"Employee: {item.EmpName}, Department: {item.DeptName}");
            //        }

            //        // ===================== GROUP BY =====================
            //        Console.WriteLine("\n=== Group By Department ===");
            //        var query3 = from emp in Emp
            //                     group emp by emp.DeptID into empGroup
            //                     select empGroup;

            //        foreach (var group in query3)
            //        {
            //            var emps = string.Join(", ", group.Select(x => x.Name));
            //            Console.WriteLine($"Group #{group.Key}: {emps}");
            //        }
            //    }
            //}

            #endregion

        }
    }
}
 