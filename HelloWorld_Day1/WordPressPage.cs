using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_Day1
{
    public class WordPressPage
    {
      public  int id;// =2;
      public string title; //= "sfdsf" ;
      public string content;//="content test";
      public enum Status { draft, published, PendingReview };
      //public Status status = Status.pendingreview;

        public Status status {get; set; } //= Status.PendingReview;
        public bool isPublished {get {return(this.status==Status.published);}}
 

      public  bool isVisible=true;
      public DateTime PublishDate = DateTime.Now;
      public int Parent = 1;
      public int order = 2;
      public int viewCount = 3;

     public static int PageCount = 0;


     public static List<WordPressPage> lista =new List<WordPressPage>();
        //tostring return an id value

       public override string ToString()
       {
           //retrun all the prop

           return id.ToString() + "\ntitle:" + title + "\ncontent: " + content + "\nstatus: " + status + "\nisVisible: " + isVisible + "\nPublishDate: " + PublishDate + "\nParent: " + Parent + "\norder: " + order + "\nviewCount: " + viewCount;
           //return id.ToString();
           //return convert.ToString(id);
       }


        public WordPressPage(string title, string content)
       {
           this.title = title;
           this.content = content; 
            //pagecount - nb pages of wordpress
           this.id = PageCount++;

            //pagecount++; id=pagecount;
            
       }

        //set current date and set status in publish

        public void Publish()

       {
           try
           {
               if (this.isPublished == false)
               {
                   throw new Exception();
               }

           }
            catch(Exception)
           {
               Console.WriteLine("is published");
           }
            this.PublishDate = DateTime.Now;
            this.status = Status.published;

        }

        public void PendingReview()
        {
            //pending review ii schimbi statusul si o salvezi in lista
            //review si pun in lista

            this.status = Status.PendingReview;
            lista.Add(this);
        }


        
        public void Publish (int hours){
            if (this.isPublished == false)
            {
                throw new Exception("Is   published");
            }
            this.PublishDate = DateTime.Now.AddHours(hours);
            this.status = Status.published;

    }
        public void Publish (DateTime datetime)
        {
            if (this.isPublished == false)
            {
                throw new Exception("Is   published");
            }
            this.PublishDate = datetime;
            this.status = Status.published;

        }

       public void SetChild(WordPressPage page)
        {
            //copilul este parametru
            page.Parent = page.id;
        }

       public void SetParent(WordPressPage page)
        {
            this.Parent = page.id;
        }

        //nr cuv din content

        public int getWordCount()
       {
            //toate cuv sep de un spatiu
           string[] split = this.content.Split(' ');
           return split.Length;
            //return content.Split(' ').Length;
       }

       
      

}

    


}
