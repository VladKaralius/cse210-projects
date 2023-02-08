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

    public string[] GetReference()
    {
        // Choose a random line
        Random random = new Random();
        int index = random.Next(_masteryList.Length);
        string line = _masteryList[index];
        // Split the line
        string[] reference = line.Split("|");
        
        return reference;
    }
}