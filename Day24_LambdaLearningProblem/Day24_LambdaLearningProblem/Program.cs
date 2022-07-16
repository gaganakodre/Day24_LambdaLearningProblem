namespace Day24_LambdaLearningProblem
{
    class Program
    {
        public static void Main(string[] args)
        {//here we are createing a list which is of person type
            //uc1
            List<Person> listPersonInCity = new List<Person>();
            listPersonInCity.Add(new Person("2345671", "anu", "1st cross 8th main BNG", 55));
            listPersonInCity.Add(new Person("2345672", "anaga", "2st cross 7th main BNG", 15));
            listPersonInCity.Add(new Person("2345673", "arya", "3st cross 6th main BNG", 35));
            listPersonInCity.Add(new Person("2345674", "janu", "4st cross 5th main BNG", 65));
            listPersonInCity.Add(new Person("2345675", "anjan", "5st cross 4th main BNG", 66));
            listPersonInCity.Add(new Person("2345676", "anupama", "6st cross 3th main BNG", 55));
            listPersonInCity.Add(new Person("2345677", "shalini", "7st cross 2th main BNG", 85));
            listPersonInCity.Add(new Person("2345678", "sheela", "8st cross 1th main BNG", 25));
            listPersonInCity.Add(new Person("2345679", "asha", "9st cross 0th main BNG", 95));

            //uc2
            Console.WriteLine("\n______________________________________");
            Console.WriteLine("Retriving top 2 aged persons from the list who are below 60 years");
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age <= 60)).Take(2).ToList())//this will store the result of the take(2)method
               // it will return the boolean value but this lamba fuction will not go in any order
               // buz for example here we top 2 to be displayed
            {
                Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            //uc3
            Console.WriteLine("\n______________________________________");
            Console.WriteLine("checking for the teenagers in the city");
            foreach (Person person in listPersonInCity.FindAll(e => (e.Age >= 13 && e.Age <= 18)))
            {
                Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            //UC-4
            Console.WriteLine("\n______________________________________");
            Console.WriteLine("Getting Average Of All The Person's Age: ");
            double averageAge = listPersonInCity.Average(e => e.Age);//here we are using the average
                                                                     //method which will find
            //the average of all the ages in enumerable class
            {
                Console.WriteLine("The Average Of All The Person's Age Is: {0}", averageAge);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            //uc5
            Console.WriteLine("\n______________________________________");
            Console.WriteLine("checking wheather perosn name present in the list");
            foreach (Person person in listPersonInCity.FindAll(e => e.Name == "anjan"))
            {
                Console.WriteLine("Yes,Name exist in your list");
            }
            Console.WriteLine("________________________________________________________________________");
            //uc6
            Console.WriteLine("\n______________________________________");
            Console.WriteLine("\nSkkiping every persons whose aged is more than 60 years");
            foreach (Person person in listPersonInCity.FindAll(e => e.Age < 60))
            {
                Console.WriteLine("Name:" + person.Name + "\t\tAge:" + person.Age);
            }
            Console.WriteLine("------------------------------------------------------------------------");
            //UC7
            Console.WriteLine("\n______________________________________");
            Console.WriteLine("\nremoving the person from the list");
            listPersonInCity.RemoveAll(e => (e.Name == "anjan"));
            if (listPersonInCity.TrueForAll(e => e.Name != "anjan"))
            {
                Console.WriteLine("no person with that name ");
            }
            Console.WriteLine("------------------------------------------------------------------------");
        }
    }
}