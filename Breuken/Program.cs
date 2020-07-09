using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_4
{
    class Program
    {
        static void Main()  // Main method
        {
            List<Fraction> fractionList;
            long k, n;
            (fractionList, k, n) = InputParser();
            QuickSortHybrid(fractionList, 0, fractionList.Count - 1, k);
            Console.WriteLine(n);
            foreach (Fraction fraction in fractionList)
            {
                Console.WriteLine(fraction.Numerator + " " + fraction.Denominator);
            }
        }

        static void QuickSortHybrid(List<Fraction> fractionList, int p, int r, long k)  // The recursive Quicksort - SelectionSort Algorithm
        {
            if (r - p + 1 <= k)
            {
                SelectionSort(fractionList, p, r);
            }
            else
            {
                int q = Partition(fractionList, p, r);
                QuickSortHybrid(fractionList, p, q - 1, k);
                QuickSortHybrid(fractionList, q + 1, r, k);
            }
        }

        static (List<Fraction>, long k, long n) InputParser()    // Takes and processes input. Returns the list of fractions to be sorted.
        {
            List<Fraction> fractionList = new List<Fraction>();

            string input = Console.ReadLine();
            string[] splitInput = input.Split(' ');
            long n = long.Parse(splitInput[0]);
            long k = long.Parse(splitInput[1]);

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                splitInput = input.Split(' ');
                long numerator = long.Parse(splitInput[0]);
                long denominator = long.Parse(splitInput[1]);

                Fraction frac = new Fraction(numerator, denominator);
                fractionList.Add(frac);
            }

            return (fractionList, k, n);
        }

        static void SelectionSort(List<Fraction> fractionList, int p, int r)     // Selection Sort Algorithm
        {
            int startInt = p;
            while (startInt < r)
            {
                Fraction temp;
                int currentInt = startInt + 1;
                int minimumInt = startInt;
                while (currentInt <= r)
                {
                    if (fractionList[currentInt].CompareTo(fractionList[minimumInt]) == -1)
                    {
                        minimumInt = currentInt;
                    }
                    currentInt++;
                }
                temp = fractionList[minimumInt];
                fractionList[minimumInt] = fractionList[startInt];
                fractionList[startInt] = temp;

                startInt++;
            }
        }

        static int Partition(List<Fraction> fractionList, int p, int r)  // Partition part of the Quicksort algorithm
        {
            Fraction pivot = fractionList[r];
            int i = p - 1;

            for (int j = p; j < r; j++)
            {
                if (fractionList[j].CompareTo(pivot) == -1 || fractionList[j].CompareTo(pivot) == 0)
                {
                    i++;
                    Fraction temp2 = fractionList[i];
                    fractionList[i] = fractionList[j];
                    fractionList[j] = temp2;
                }
            }
            Fraction temp = fractionList[r];
            fractionList[r] = fractionList[i + 1];
            fractionList[i + 1] = temp;
            return i + 1;
        }
    }

    class Fraction : IComparable<Fraction>
    {
        public long Numerator;
        public long Denominator;

        public Fraction(long numerator, long denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public int CompareTo(Fraction b)
        {
            long aFraction = this.Numerator * b.Denominator;
            long bFraction = b.Numerator * this.Denominator;

            if (aFraction > bFraction)
            {
                return 1;
            }
            if (aFraction < bFraction)
            {
                return -1;
            }
            else
            {
                if (this.Denominator > b.Denominator)
                {
                    return 1;
                }
                if (this.Denominator < b.Denominator)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }   // Fraction class
}
