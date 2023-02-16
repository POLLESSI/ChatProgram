namespace ChatProgram
{
    public static class Program
    {
        static List<User> users = new List<User>();
        static void Main(string[] args)
        {
            Chat chat1 = new Chat();
            User user1 = new User("Vincent-Valery", chat1);
            User user2 = new User("Patric-Stanislas", chat1);


            chat1.AddUser(user1);
            chat1.AddUser(user2);

            user1.SendMessage("Salut. TU - VAS - BIEEEN ???? (les Inconnus dans Auteil Neuilly Passy");
            user2.SendMessage("Fine, To much! Et toi??? TU - VAS - BIEEEN ???? (Idem ;-))");

            Console.ReadLine();

            //users.Add(user1);
            //users.Add(user2);

            //user1.Receive();
            //user2.Receive();   
        }
    }
}
