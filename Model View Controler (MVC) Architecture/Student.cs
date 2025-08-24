public class Student
{
    private string name;
    private int age;
    public Student(string name,int age)
    {
        this.name = name;
        this.age = age;
    }
    public string getname()
    {

    return name; 
    }
public int getage() 
    {
    return age;
    }
    public void setname(string name)
    {

    this.name = name;
    }
    public void setage(int age)
    { 
        this.age = age; 
    }
}
