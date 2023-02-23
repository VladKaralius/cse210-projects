public class SampleDataGenerator
{
    private string[] _titles =
        {
            "12 Steps To Finding The Perfect Cat",
            "Cats Are Taking Over And What To Do About It",
            "5 Lessons About Cats You Can Learn From Superheroes",
            "Top Reasons People Hate Dogs",
            "What Hollywood Can Teach Us About Dogs",
            "Become An Expert On Dogs By Watching This Video",
            "9 Signs You're A Hamster Expert",
            "The History Of Hamsters Told Through Tweets",
            "This Week's Top Stories About Hamsters",
            "The Rabbits You'll Never Forget"
        };
    
    private int _currentTitlesIndex = 0;

    // _names will be used both for authors and commenters.
    private string[] _names = 
        {
            "John Doe", "Shanae Adhelm", "Neptunus Magni", "Virgilius Gervasius", "Lothair Juvenal",
            "Yuri Platon", "Abital Lamech", "Avner Leia", "Maya Kama", "Ramana Rukmini",
            "Margherita Rossa", "Carmela Annabella", "Itumeleng Tariro", "Brycen Reginald", "Suzie Alissa",
            "Jesper Alf", "Viktor Torsten", "Taiwo Adisa", "Xiuying Zhi", "Lei Xinyi",
            "Yoshi Masaru", "Haruki Kyouko", "Cipriano Amadeo", "Bernardo Emilio", "Abdulaziz Qusay"
        };
    
    private int _currentNamesIndex = 0;
    
    private string[] _texts =
        {
            "You are remarkably ignorant about this subject. But still you post.",
            "This is understandable, laudable and just downright adorable.",
            "I'm having much trouble working out what you're saying.",
            "I think given the observations so far it is unnecessary to post a rejoinder.",
            "Let me put my vote down against this woefully bloated tomfoolery. I am sick to death of this.",
            "It's beyond comical, enough to make a meerkat do continuous hysterical somersaults for an eternity.",
            "When will folks stop orchestrating a maelstrom of misinformation?",
            "First things first. Now let the chorus of loudmouths sing forth.",
            "Well, yes and no. But mostly you must be joking. Probably it'll wither on the vine, but I hope not.",
            "A witless response. It's everyone's fault, we all share the blame and we shall all suffer the consequences.",
            "Perceptive talk. Sometimes pointing out the simple seems to be a revelation...",
            "It's hard to work out what still seems staggeringly amazing.",
            "I seriously doubt that happened. We have had enough of that sort in the bygone decade!!!",
            "Deeply categorically untrue. In that situation the loneliness must be overwhelming.",
            "Typical. Absolute hypocrisy!!!!!!",
            "A pretty darned fair point, and one that I support as well.",
            "Must be irony. No sane person could truly think so irrationally.",
            "Sad but true. I don't believe you, I think you are being inane.",
            "This piece is the best proof yet that Animal Farm remains as true today as ever.",
            "I've just had a flash of inspiration. Said it before and I'll say it again!"
        };
    
    private int _currentTextsIndex = 0;

    public SampleDataGenerator()
    {
        Shuffle(_titles);
        Shuffle(_names);
        Shuffle(_texts);
    }

    public string GetNextTitle()
    {
        string title = _titles[_currentTitlesIndex];
        _currentTitlesIndex = ++_currentTitlesIndex % _titles.Length;
        return title;
    }

    public string GetNextName()
    {
        string name = _names[_currentNamesIndex];
        _currentNamesIndex = ++_currentNamesIndex % _names.Length;
        return name;
    }

    public string GetNextText()
    {
        string text = _texts[_currentTextsIndex];
        _currentTextsIndex = ++_currentTextsIndex % _texts.Length;
        return text;
    }

    private void Shuffle(string[] records)
    {
        Random random = new Random();
        
        Double[] order = new Double[records.Length];
        for (int i = 0; i < records.Length; i++)
        {
            order[i] = random.NextDouble();
        }
        Array.Sort(order, records);
    }
}