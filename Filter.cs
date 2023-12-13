using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RowFilter;


namespace FilterStart
{
    static public class FilterStart
    {
        static public string[] Filter(string[] arrayRow)
        {
            Console.WriteLine("Использовали фильтр");
            for (int i = 0; i < arrayRow.Length; i++)
            {
                if (arrayRow[i].Length > 3 ){ arrayRow[i] = ""; }
            }
            return arrayRow;
        }

    }
}
