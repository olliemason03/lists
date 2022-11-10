class student
{
    public string firstName;
    public string surname;
    public string courseName;
    public int SID;
    public string gender;
    public int age;


    public student(string fn, string sn, string cn, int s, string g, int a)
    {
        this.firstName = fn;
        this.surname = sn;
        this.courseName = cn;
        this.SID = s;
        this.gender = g;
        this.age = a;


    }
    public string getName()
    {
        return firstName + " " + surname;
    }
    public string getCourse()
    {
        return courseName;
    }
    public int getSID()
    {
        return SID;
    }
    public string getGender()
    {
        return gender;
    }
    public int getAge()
    {
        return age;
    }
}