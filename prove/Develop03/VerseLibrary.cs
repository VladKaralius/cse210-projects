    public class VerseLibrary
    {
        private string _fileName;
        private Dictionary<(string, int, int), string> _verseLibrary;
   
        public VerseLibrary()
        {
            _fileName = "verses.txt";
            
            _verseLibrary = new Dictionary<(string, int, int), string>();

            string[]verseList = System.IO.File.ReadAllLines(_fileName);
            foreach (string line in verseList)
            {
                string[] parts = line.Split("|");
                string book = parts[0];
                int chapter = int.Parse(parts[1]);
                int verse = int.Parse(parts[2]);
                string verseText = parts[3];
                _verseLibrary.Add((book, chapter, verse), verseText);
            }
        }

        public string GetVerseText(string book, int chapter, int verse)
        {
            string verseText = _verseLibrary[(book, chapter, verse)];
            return verseText;
        }
    }