using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ShindinDN.Sprint4.Task6.V24.Lib
{
    public class DataService : ISprint4Task6V24
    {
        public string[] Calculate(string[] array)
        {
            int count = array.Count(s => s.Length > 7);
            string[] res = new string[count];
            int i = 0;
            foreach (string lec in array)
            {
                if (lec.Length > 7)
                {
                    res[i++] = lec;
                }
            }
            return res;
        }
    }
}
