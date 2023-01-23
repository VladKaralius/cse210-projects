    public class Reference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _verseEnd;
        private string _fileName;
   
        public Reference(string book, int chapter, int verse)
        {
            Console.WriteLine(verse);
        }

        public Reference(string book, int chapter, int verse, int verseEnd)
        {
            Console.WriteLine(verse + verseEnd);
        }

    }