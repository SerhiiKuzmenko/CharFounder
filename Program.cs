using System.Drawing;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string text = "The Tao gave birth to machine language.  Machine language gave birth to the assembler. The assembler gave birth to the compiler. Now there are ten thousand languages. Each language has its purpose, however humble.  Each language expresses the Yin and Yang of software. Each language has its place within the Tao. But do not program in COBOL if you can avoid it.         -- Geoffrey James, \"The Tao of Programming\"";
            //string text = "C makes it easy for you to shoot yourself in the foot. C++ makes that harder, but when you do, it blows away your whole leg. (с)Bjarne Stroustrup";
            //text = Console.ReadLine();




            string[] words = text.Split(' ');
           
            List<string> trustWords = new List<string>();
        
            for(int i =0;i<words.Length;i++)
            {
                if (words[i] == "")
                {
                    continue;
                }
                else
                {
                    trustWords.Add(words[i]);
                }
            }
            


            char[] results = new char[trustWords.Count];
            for (int i = 0; i < trustWords.Count; i++)
            {
                int k = 0;
                char tmp;
                
                tmp = trustWords[i].ToCharArray()[0];

                for (int j = 0; j < trustWords[i].Length; j++)
                {
                    if (k == j)
                    {
                        continue;
                    }

                    if (tmp != trustWords[i][j])
                    {
                        continue;
                    }
                    else
                    {
                        tmp = trustWords[i].ToCharArray()[k+1];
                        k++;
                        
                        j = 0;
                    }
                }
                results[i] = tmp; 
            }


            int trueIndex = 0;
            char once = results[trueIndex];
         

            for(int i = 0; i < results.Length; i++)
            {
                if(i != trueIndex)
                {
                    if (once == results[i])
                    {
                        trueIndex++;
                        once = results[trueIndex];
                        i=0;
                    }
                }
            }

            Console.WriteLine(once);
        }
    }
}
