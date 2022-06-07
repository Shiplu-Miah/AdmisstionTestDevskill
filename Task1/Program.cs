using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int i = 0, wrd, l;
            StringBuilder sb = new StringBuilder();

            Console.Write("\n\nCount the total number of words in a str:\n");

            Console.Write("---------------------------------------------------\n");

            Console.Write("Input the string : ");
            str = "Dev Skill";

            l = 0;
            wrd = 1;

            foreach (var a in str)
            {
                sb.Append(a);
                if (str[l] == ' ' || str[l] == '\n' || str[l] == '\t')
                {
                    wrd++;
                }
                l++;
            }

            Console.WriteLine(sb.Replace(' ', '\n'));
            Console.Write("Total number of words in the string is : {0}\n",
            wrd);
            Console.ReadLine();
        }
    }
}