
//presenter
public class StudentPresenter
{
    private StudentView view;
    private Student model;
    public StudentPresenter(StudentView view, Student model)
    {
        this.view = view;
        this.model = model;
    }
    public  void  UpdateView()
    {
        view.ShowStudent(model.getName(), model.getAge());
    }

}
