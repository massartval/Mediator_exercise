using Mediator_exercise;

Console.WriteLine("Hello, World!");

Chat chat = new Chat();
User alice = new User("Alice Cooper", chat);
User bob = new User("Bob Marley", chat);

chat.AddUser(alice);
chat.AddUser(bob);

alice.SendMessage("Salut Bob");
bob.SendMessage("Salut, ça va?");
alice.SendMessage("Oui et toi?");
bob.SendMessage("Ihmotep, Ihmotep");

Console.ReadLine();


