public class Main
{
    public static void main(String[] args)
    {
        //Model obj
        Student std=new Student("Yasir",23);
        //View obj
        StudentConsoleView scv=new StudentConsoleView();
        //Presenter obj
        StudentPresenter sp=new StudentPresenter(scv,std);
        //show student info
        sp.UpdateView();

        }
    }
