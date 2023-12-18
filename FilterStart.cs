using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RowsFilter
{
    static public class FilterStart
    {
        /// <summary>
        /// Метод реализует наполнение нового массива, из элементов заданного массива отобранных по критерию.
        /// </summary>
        /// <param name="arrayRow"> массив заданный пользователем</param>
        /// <returns><param name="arrayFilter"> новый массив возвращаемый в основную программу</param></returns>
        static public string[] Filter(string[] arrayRow)
        {
            int count = 0;
            for (int i = 0; i < arrayRow.Length; i++)
            {
                if (arrayRow[i].Length <= 3 ){ count = count + 1; }
            }
            string[] arrayFilter = new string [count];
            int indexArrayFilter = 0;
            for (int indexArrayRow = 0; indexArrayRow < arrayRow.Length; indexArrayRow++)
            {
                if (arrayRow[indexArrayRow].Length <= 3)
                {
                    arrayFilter[indexArrayFilter] = arrayRow[indexArrayRow];
                    indexArrayFilter++; 
                }
            }
            return arrayFilter;
        }
    }
}
