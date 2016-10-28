using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Day1
{
    class Program
    {
        static void Main(string[] args)
        {
    
            WordPressPage page = new WordPressPage(" title", "content");
            WordPressPage page2 = new WordPressPage("2title", "2content");



          WordPressPage page3 = new WordPressPage(" 3title", " 3content");
            WordPressPage page4 = new WordPressPage("4title", "4content");
            WordPressPage page5 = new WordPressPage("4title", "4content");
            WordPressPage page6 = new WordPressPage("4title", "4content");

           /* page3.isVisible = false;
            page4.order = 2;

            //page.isVisible = true;
            Console.WriteLine(page.ToString());
            Console.WriteLine();
            Console.WriteLine(page2.ToString());
            Console.WriteLine();
            Console.WriteLine(page3.ToString());
            Console.WriteLine();
            Console.WriteLine(page4);*/
            //Console.ReadKey();
          
            /*Console.WriteLine("Hello World!");
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();*/

           // page.Publish();

           // Console.WriteLine(page);

          //  Console.ReadKey();

          /*  page.PendingReview();
            page2.PendingReview();
            
            foreach (var i in WordPressPage.lista){
                Console.WriteLine(i);
                Console.ReadKey();
                            }
            */
         /*   page3.Publish(5);
            page4.Publish(DateTime.Now.AddDays(1));
            page5.SetChild(page4);
            page6.SetParent(page);
*/
            //page.getWordCount();

        //    Console.WriteLine(page.getWordCount());
          /*  Console.WriteLine();
            Console.WriteLine(page2);
            Console.WriteLine();
            Console.WriteLine(page3);
            Console.WriteLine();
Console.WriteLine(page4);
            Console.WriteLine();
            Console.WriteLine(page5);
            Console.WriteLine();
            Console.WriteLine(page6);*/

            Console.WriteLine(page.isPublished);
            page.status = WordPressPage.Status.published;
            page.Publish();
        Console.WriteLine(page.isPublished);
           Console.ReadKey();
        }
    }
}
