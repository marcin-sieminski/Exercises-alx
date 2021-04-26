namespace ClassCopying
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public Person Copy =>
            new Person()
            {
                FirstName = FirstName,
                LastName = LastName
            };


        public Person CopyPerson()
        {
            return new Person()
            {
                FirstName = FirstName,
                LastName = LastName
            };
        }
    }
}
