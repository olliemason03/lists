Console.WriteLine("Enter students First Name:  ");
string firstName = Console.ReadLine();
Console.WriteLine("Enter students Surname:  ");
string surname = Console.ReadLine();
Console.WriteLine("Enter students Course:  ");
string courseName = Console.ReadLine();
Console.WriteLine("Enter students gender:  ");
string gender = Console.ReadLine();
Console.WriteLine("Enter students age:  ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter students SID:  ");
int SID = Convert.ToInt32(Console.ReadLine());







Console.Clear();

student student1 = new student(firstName,surname,courseName,SID,gender,age);

Console.WriteLine("name: " + student1.getName());
Console.WriteLine("age: " + student1.getAge());
Console.WriteLine("sex: " + student1.getGender());
Console.WriteLine("course: " + student1.getCourse());
Console.WriteLine("SID: " + student1.getSID());

Console.ReadKey();


