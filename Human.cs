

    internal class Human
    {
        public string _name { get; set; }
        public string _surname { get; set; }
        public int _age { get; set; }
        public Human() { }
        public Human(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;
        }
    public override string ToString()
    {
        return $"\n Имя: {_name}  фамилия: {_surname} возраст: {_age}\n";
    }
}



