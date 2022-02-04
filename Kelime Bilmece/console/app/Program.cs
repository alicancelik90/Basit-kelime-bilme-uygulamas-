using System;

namespace app
{
   class Word
   {
       public Word(string question,string answer)
       {
           this.Question = question;
           this.Answer = answer;
       }
        public string Question { get; set; }
        public string Answer { get; set; }

        public bool CheckedAnswer(string answer)
        {
            return this.Answer.ToLower() == answer.ToLower();
        }
       
     
   }

   class Over
   {
       public Over(Word[] words)
       {
           this.Words = words;
           this.WordIndex = 0;
           this.Score = 0;
       }
       public Word[] Words { get; set; }
       public int Score { get; set; }
       public int WordIndex { get; set; }

       public Word GetWordIndex()
       {
           return this.Words[this.WordIndex];
       }
       public void ScoreWiew()
       {
         Console.WriteLine($"Sorulara verdiğiniz doğru cevap sayısı : {this.Score}");
       }

       public void WordWiew()
       {
           var word = this.GetWordIndex();

           Console.WriteLine($"{this.WordIndex+1}. Kelime : {word.Question}");

           Console.Write("Cevabınız : ");
           var answer = Console.ReadLine();

           this.Result(answer);

      
       }

       public void Result(string answer)
       {
          var word = this.GetWordIndex();

          if (word.CheckedAnswer(answer))
          {
              this.Score++;
          }
          
          this.WordIndex++;

          if (this.Words.Length == this.WordIndex)
          {
              this.ScoreWiew();
              this.Report();
          }
          else
          {
              this.WordWiew();
          }
       }

       public void Report()
       {
          var score = this.Score;

          if (score >= 0 && score <= 4)
          {
              Console.WriteLine("Kelime çalışmanız yetersiz görünüyor.Daha sıkı çalışmalısınız...");
          }
          else if (score >= 4 && score <= 8)
          {
              Console.WriteLine("Kelime çalışmanız hiç fena değil.Biraz gayretle daha iyisini yapabilirsin...");
          }
          else
          {
               Console.WriteLine("Kelime çalışmanız harika ! Başarılarınızın devamını dileriz...");
          }
       }

   }

  
      
    class Program
    {

        static void Main(string[] args)
        {
           var w1 = new Word("Build","Yapı");
           var w2 = new Word("İmplement","Uygulamak");
           var w3 = new Word("Client","Müşteri");
           var w4 = new Word("Resolve","Çözümleme");
           var w5 = new Word("İncrement","Artış");
           var w6 = new Word("Access","Erişim");
           var w7 = new Word("Context","Uygulamak");
           var w8 = new Word("Query","Sorgu");
           var w9 = new Word("Session","Oturum");
           var w10 = new Word("Scope","Kapsam");

           var words = new Word[]{w1,w2,w3,w4,w5,w6,w7,w8,w9,w10};

           var over = new Over(words);

           over.WordWiew();
                   

        }
              

        
    }
}
