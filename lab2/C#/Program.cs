using System;
using MyStringg;
using Textt;
namespace progasharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int act;
            string str1;
            string stroka1 = "All around me are familiar faces";
            string stroka2 = "Worn out places, worn out faces";
            string stroka3 = "Bright and early for the daily races";
            string stroka4 = "Going nowhere, going nowhere";

            MyString line1 =new MyString(stroka1.ToCharArray(), stroka1.Length);
            MyString line2 = new MyString(stroka2.ToCharArray(), stroka2.Length);
            MyString line3 = new MyString(stroka3.ToCharArray(), stroka3.Length);
            MyString line4 = new MyString(stroka4.ToCharArray(), stroka4.Length);

            Text text = new Text(line1); 
            text.AddToText(line2);
            text.AddToText(line3);
            text.AddToText(line4);

            char[][] TEXT = text.GetText();                           //массив со строками (текстом)
            Console.WriteLine("The text: ");
            text.OutputText(TEXT, text.GetAmountOfLines());

            Console.WriteLine("1-add a line \n2-delete a line \n3-clear the text \n4-get average line length \n5 - get the percentage of vowels in the whole text \n6 - delete a line that contains a given substring \n7 - see the menu \n0 - finish the program"); 
            do
            {
                Console.WriteLine("\nWhat do you want ?");
              
                str1 = Console.ReadLine();
                act = Convert.ToInt32(str1);
                switch (act)
                {
                    case 1:
                        {
                            string addline;
                            Console.WriteLine("Write a line:");
                            addline=Console.ReadLine();
                            MyString addline_str = new MyString(addline.ToCharArray(), addline.Length);       
                            text.AddToText(addline_str);
                            TEXT = text.GetText();
                            Console.WriteLine("The text: ");
                            text.OutputText(TEXT, text.GetAmountOfLines());
                            break;
                        }
                    case 2:
                        {
                            int Index;
                            string ind;
                            Console.WriteLine("What line do you want to delete ?");                     
                            ind = Console.ReadLine();
                            Index = Convert.ToInt32(ind);
                            text.DeleteLine(Index - 1);
                            TEXT = text.GetText();
                            Console.WriteLine("The text: ");
                            text.OutputText(TEXT, text.GetAmountOfLines());
                            break;
                        }
                    case 3:
                        {
                            text.DeleteText();
                            TEXT = text.GetText();
                            Console.WriteLine("The text: ");
                            text.OutputText(TEXT, text.GetAmountOfLines());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("The average length of line: ");
                            Console.WriteLine(text.AverageLength());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("The percentage of vowels in the whole text:");
                            Console.WriteLine( text.PercentageOfVowels());
                            break;
                        }
                    case 6:
                        {
                            string substr;
                            Console.WriteLine("Enter the substring: ");
                            substr=Console.ReadLine();
                            text.DeleteLineWithSubstr(substr.ToCharArray(), substr.Length);
                            TEXT = text.GetText();
                            Console.WriteLine("The text: ");
                            text.OutputText(TEXT, text.GetAmountOfLines());
                            break;
                        }          
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error");
                            break;
                        }
                }
            } while (act != 0);
            Console.ReadLine();
        }
    }
}
