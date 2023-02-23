public class SampleDataGenerator
{
    private string[] _titles =
        {
            "Oh How Come Factor", "Revelation Good Dots", "Main Charming Ranch",
            "Crystal Functions", "Unique Production Times", "Eventions Blue Feasts",
            "Little Moment", "Orion Meetings", "Engaging Nirvana",
            "Natural Time Celebration", "Matrix Now", "Kinetic Day",
            "Social New Season", "Dreams Success Details", "Meeting Science"
        };
    
    private int _currentTitlesIndex = 0;

    private string[] _descriptions =
        {
            "For vertical integration parallel path, so we need to get all stakeholders up to speed.",
            "We need to get the vernacular right translating our vision of having a market leading platfrom.",
            "Reach out we're ahead of the curve on that one in an ideal world.",
            "If you're not hurting you're not winning enough to wash your face going forward.",
            "Herding cats effort made was a lot, for technologically savvy going forward.",
            "Digital literacy slipstream, so draw a line in the sand,  those options are already baked in with this model.",
            "Cosmic ocean permanence of the stars made in the interiors of collapsing stars.",
            "Laws of physics quasar take root and flourish dispassionate extraterrestrial observer.",
            "Circumnavigated finite but unbounded citizens of distant epochs kindling the energy hidden in matter.",
            "Leverage agile frameworks to provide a robust synopsis for high level overviews.",
            "Iterative approaches to corporate strategy foster collaborative thinking .",
            "Organically grow the holistic world view of disruptive innovation."
        };

    private int _currentDescriptionsIndex = 0;
    
    private string[] _emails =
        {
            "algecir", "hosphere", "theidonial", "brochets", "examplier",
            "erneather", "crossibilia", "orangence", "germantina", "fundards",
            "lupervices", "bulgence", "haemation", "paludlow", "apparabs"
        };
    
    private int _currentEmailsIndex = 0;

    private string[] _weatherForecasts =
        {
            "Mostly dry. Very mild (max 16°C, min 7°C ). Mainly fresh winds.",
            "Mostly dry. Very mild (max 18°C, min 10°C ). Wind will be generally light.",
            "Some drizzle. Very mild (max 18°C, min 10°C ). Wind will be generally light.",
            "Light rain. Very mild (max 18°C, min 10°C ). Wind will be generally light.",
            "Light rain. Very mild (max 18°C, min 10°C ). Mainly fresh winds.",
            "Mostly dry. Freeze-thaw conditions (max 2°C , min -5°C). Wind will be generally light.",
            "Mostly dry. Very mild (max 18°C, min 10°C ). Mainly fresh winds.",
            "Mostly dry. Very mild (max 22°C, min 15°C ). Wind will be generally light."
        };

    private int _currentWeatherForecastsIndex = 0;

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
        Shuffle(_titles);
        Shuffle(_descriptions);
        Shuffle(_emails);
        Shuffle(_weatherForecasts);
        Shuffle(_names);
        Shuffle(_countries);
        Shuffle(_states);
        Shuffle(_statesUSA);
        Shuffle(_cities);
        Shuffle(_streets);
    }

    public string GetNextTitle()
    {
        string title = _titles[_currentTitlesIndex];
        _currentTitlesIndex = ++_currentTitlesIndex % _titles.Length;
        return title;        
    }
    
    public string GetNextDescription()
    {
        string description = _descriptions[_currentDescriptionsIndex];
        _currentDescriptionsIndex = ++_currentDescriptionsIndex % _descriptions.Length;
        return description;        
    }

    public string GetNextEmail()
    {
        string email = _emails[_currentEmailsIndex];
        _currentEmailsIndex = ++_currentEmailsIndex % _emails.Length;
        return email + "@greatevents.com";
    }

    public string GetNextWeatherForecast()
    {
        string weatherForecast = _weatherForecasts[_currentWeatherForecastsIndex];
        _currentWeatherForecastsIndex = ++_currentWeatherForecastsIndex % _weatherForecasts.Length;
        return weatherForecast;        
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