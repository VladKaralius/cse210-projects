    public class ReferenceGenerator
    {
        private string _fileName;
        private string[] _masteryList;
   
        public ReferenceGenerator()
        {
            _fileName = "mastery.txt";
            _masteryList = System.IO.File.ReadAllLines(_fileName);
        }

        public ReferenceGenerator(string fileName)
        {
            _fileName = fileName;
            // Read the file with reference list
            _masteryList = System.IO.File.ReadAllLines(_fileName);
        }

        public ValueTuple<string, int, int> GetReference()
        {
            // Choose a random line
            Random random = new Random();
            int index = random.Next(_masteryList.Length);
            string line = _masteryList[index];
            // Split the line
            string[] parts = line.Split("|");

            string book = parts[0];
            int chapter = int.Parse(parts[1]);
            int verse = int.Parse(parts[2]);

            if (parts.Length == 3)
            {
                var reference = ValueTuple.Create(book, chapter, verse);
                return reference;
            }
            
            return reference;
        }
    }