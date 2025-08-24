// Console based View implementation include in view
public class StudentConsoleView implements StudentView
{
    @Override
    public void ShowStudent(String name,int age)
    {
        System.out.println("Student Info: "+name+"( Age: "+age+")");
    }
}
