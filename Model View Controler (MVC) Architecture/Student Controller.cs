   public class StudentController
    {
        private Student model;
        private StudentView sv;
        public StudentController(Student model, StudentView sv)
        {
            this.model = model;
            this.sv = sv;
        }
        public void setStudentName(string name)
        {
            model.setname(name);
        }
        public void setStudentAge(int age)
        {
            model.setage(age);
        }
        public void updateView()
        {
            sv.printStudentDetails(model.getname(),model.getage());
        }
        public void ShowMessage(string message)
        {
            sv.printMessage(message);
        }
    }
}
