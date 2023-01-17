    public class Entry
    {
        public string _date = "";
        public string _heading = "";
        public string _record = "";
   
        public Entry()
        {
        }

        public void Display()
        {
            Console.WriteLine($"Date {_date} - {_heading}");
            Console.WriteLine(_record);
            Console.WriteLine();
        }
    }