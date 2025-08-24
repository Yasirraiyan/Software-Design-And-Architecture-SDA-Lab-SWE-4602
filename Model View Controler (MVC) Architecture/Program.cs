class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student("Yasir", 23);
        StudentView sv = new StudentView();
        StudentController sc=new StudentController(student, sv);
        sc.updateView();
        sc.setStudentName("Ali");
        sc.updateView();
        sc.setStudentAge(33);
        sc.ShowMessage("Student Details Updated Successfully");
        sc.updateView();    
    }
}
