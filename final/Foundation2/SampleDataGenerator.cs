public class SampleDataGenerator
{
    private string[] _productNames =
        {
            "Algecir", "Hosphere", "Theidonial", "Brochets", "Examplier",
            "Erneather", "Crossibilia", "Orangence", "Germantina", "Fundards",
            "Lupervices", "Bulgence", "Haemation", "Paludlow", "Apparabs"
        };
    
    private int _currentProductNamesIndex = 0;

    private string[] _names = 
        {
            "John Doe", "Shanae Adhelm", "Neptunus Magni", "Virgilius Gervasius", "Lothair Juvenal",
            "Yuri Platon", "Abital Lamech", "Avner Leia", "Maya Kama", "Ramana Rukmini",
            "Margherita Rossa", "Carmela Annabella", "Itumeleng Tariro", "Brycen Reginald", "Suzie Alissa",
            "Jesper Alf", "Viktor Torsten", "Taiwo Adisa", "Xiuying Zhi", "Lei Xinyi",
            "Yoshi Masaru", "Haruki Kyouko", "Cipriano Amadeo", "Bernardo Emilio", "Abdulaziz Qusay"
        };
    
    private int _currentNamesIndex = 0;
    
    private string[] _countries =
        {
            "Resoland", "Glacolia", "Republic of Eucon", "Livonshire Islands", "Agariastan", "Itau",
            "Genovia", "Buranda", "Drenai Empire", "Freedonia", "Laputa", "San Marcos"
        };
    
    private int _currentCountriesIndex = 0;

    private string[] _states =
        {
            "Alderney", "Calisoga", "Catawaba", "Coventry", "Delmarva", "Grojaria", 
            "Florin", "Gilead", "Ganbe Nezea", "Etotantoro", "Guacarba", "Rane"

        };
    
    private int _currentStatesIndex = 0;
    
    private string[] _statesUSA =
        {
            "Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado", "Connecticut",
            "Delaware", "District of Columbia", "Florida", "Georgia", "Hawaii", "Idaho", "Illinois",
            "Indiana", "Iowa", "Kansas", "Kentucky", "Louisiana", "Maine", "Maryland", "Massachusetts",
            "Michigan", "Minnesota", "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada",
            "New Hampshire", "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota",
            "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Rhode Island", "South Carolina",
            "South Dakota", "Tennessee", "Texas", "Utah", "Vermont", "Virginia", "Washington",
            "West Virginia", "Wisconsin", "Wyoming"
        };
    
    private int _currentStatesUSAIndex = 0;

    private string[] _cities =
        {
            "Solaris", "New Grasslands", "Crazy Town", "Pineville Wood", "Dracaris City",
            "Brilfax Village", "Tangerine Town", "Bamford City", "Jedburgh", "Penketh",
            "Farrahville", "Upper Ghyllxos", "Watford", "Kamouraska", "Eastbourne"
        };
    
    private int _currentCitiesIndex = 0; 
   
    private string[] _streets =
        {
            "Luna Street", "Lilypad Route", "Shade Lane", "Crimson Street",
            "Mason Passage", "General Boulevard", "Liberty Row", "Garden Avenue",
            "Congress Street", "College Way", "Duke Street", "Legend Street"
        };
    
    private int _currentStreetsIndex = 0;

    public SampleDataGenerator()
    {
        Shuffle(_productNames);
        Shuffle(_names);
        Shuffle(_countries);
        Shuffle(_states);
        Shuffle(_statesUSA);
        Shuffle(_cities);
        Shuffle(_streets);
    }

    public string GetNextProductName()
    {
        string productName = _productNames[_currentProductNamesIndex];
        _currentProductNamesIndex = ++_currentProductNamesIndex % _productNames.Length;
        return productName;
    }

    public string GetNextName()
    {
        string name = _names[_currentNamesIndex];
        _currentNamesIndex = ++_currentNamesIndex % _names.Length;
        return name;
    }

    public string GetNextCountry()
    {
        string country = _countries[_currentCountriesIndex];
        _currentCountriesIndex = ++_currentCountriesIndex % _countries.Length;
        return country;
    }

    public string GetNextState()
    {
        string state = _states[_currentStatesIndex];
        _currentStatesIndex = ++_currentStatesIndex % _states.Length;
        return state;
    }

    public string GetNextStateUSA()
    {
        string stateUSA = _statesUSA[_currentStatesUSAIndex];
        _currentStatesUSAIndex = ++_currentStatesUSAIndex % _statesUSA.Length;
        return stateUSA;
    }

    public string GetNextCity()
    {
        string city = _cities[_currentCitiesIndex];
        _currentCitiesIndex = ++_currentCitiesIndex % _cities.Length;
        return city;
    }

    public string GetNextStreet()
    {
        string street = _streets[_currentStreetsIndex];
        _currentStreetsIndex = ++_currentStreetsIndex % _streets.Length;
        return street;
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