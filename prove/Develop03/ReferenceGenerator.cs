    public class ReferenceGenerator
    {
        private string _fileName;
        
   
        public ReferenceGenerator()
        {
            _fileName = "mastery.txt";
            // Read the file with reference
            string[] lines = System.IO.File.ReadAllLines(_fileName);
            // Choose a random line
            Random random = new Random();
            int index = random.Next(lines.Length);
            string line = lines[index];
            // Split the line
            string[] parts = line.Split("|");

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);
            
            if (parts.Length == 3)
            {
                Reference reference = new Reference(book, chapter, verse);
            }

            else
            {
                int verseEnd = int.Parse(parts[3]);
                Reference reference = new Reference(book, chapter, verse, verseEnd);
            }
        }
    }