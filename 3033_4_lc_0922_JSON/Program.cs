// Jack Herdejurgen 113436899
// Sept 22, 2022
// 

using System.Security.Cryptography.X509Certificates;

string testStr;
testStr = "No electronic materials (You could NOT look at your previous code on your computer) Open notes, open book. You can bring printed codes.";

int numChar = testStr.Count((x) => { if (x == 'a') { return true; } else { return false; } });
int numChar2 = testStr.Count(
    x => "abcd".Contains(x)
    );

Console.WriteLine(numChar2);

List<double> gradeslist = new List<double>();

gradeslist.Add(75);
gradeslist.Add(-97);
gradeslist.Add(86);
gradeslist.Add(68);
gradeslist.Add(87);
gradeslist.Add(-99);

double highest = 0;

foreach(double x in gradeslist)
{
    if (x > highest)
    {
        highest = x;
    }
}
double highest2 = gradeslist.Max(x => Math.Abs(x));

Console.WriteLine(highest);
Console.WriteLine(highest2);

// min -> max
gradeslist.Sort(
        (x,y) =>
        {
            if (x > y) { return 1; }
            else if( x==y) { return 0; }
            else { return -1; }
        }
    );
Console.WriteLine("After Sort");
foreach (double x in gradeslist) { Console.Write($"{x},"); }

Console.ReadLine();