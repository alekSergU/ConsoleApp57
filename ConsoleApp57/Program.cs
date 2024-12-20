//var name = Console.ReadLine();

//var age = checked((byte)int.Parse(Console.ReadLine()));
//Console.WriteLine("Your name is {0} and age is {1} ", name, age);

//Console.Write("What is your favorite day of week? ");

//var day = (DayOfWeek)int.Parse(Console.ReadLine());
//Console.WriteLine("Your favorite day is {0}", day);


Console.Write("как зовут: ");
string name = Console.ReadLine();

Console.Write("когда день рождения: ");
DateTime dayOfBirthday = DateTime.Parse(Console.ReadLine());
//Console.WriteLine(dayOfBirthday);

DateTime wer = DateTime.Now;
//Console.WriteLine(wer.Subtract(dayOfBirthday));

//DateTime rew = dayOfBirthday;
//Console.WriteLine(rew.AddDays(wer.Subtract(dayOfBirthday)));

TimeSpan timeSpan = wer - dayOfBirthday;

Console.WriteLine(timeSpan.TotalDays);

Console.WriteLine($"\nпривет {name}!\nтебе сейчас " + (int)timeSpan.TotalDays / 365 + " лет)");   


//DateOnly dateOnly = DateOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(dateOnly);






