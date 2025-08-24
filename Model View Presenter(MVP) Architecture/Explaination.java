MVP কি?

MVP হল একটি আর্কিটেকচারাল প্যাটার্ন যা UI (User Interface) কে লজিক থেকে আলাদা করে। এতে থাকে তিনটি অংশ:

Model (মডেল) – ডেটা এবং লজিক সংরক্ষণ করে।

View (ভিউ) – UI উপাদান দেখায়, কেবলমাত্র প্রদর্শন।

Presenter (প্রেজেন্টার) – Model এবং View এর মধ্যে সংযোগকারী। View এর action ধরে Model আপডেট বা Model থেকে ডেটা নিয়ে View দেখায়।

Line-by-line Breakdown of Your Code
1️⃣ Model – Student.java
public class Student {
    private String name;
    private int age;

    public Student(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public int getAge() { return age; }
    public String getName() { return name; }
}


কি করছে:

Student এর নাম এবং বয়স সংরক্ষণ করছে।

Getter মেথড দিয়ে ডেটা বাইরে পাঠাচ্ছে।

MVP এর রোল: Data holder → Model

2️⃣ View – StudentView.java ও StudentConsoleView.java
public interface StudentView {
    void ShowStudent(String name, int age);
}

public class StudentConsoleView implements StudentView {
    @Override
    public void ShowStudent(String name,int age) {
        System.out.println("Student Info: "+name+"( Age: "+age+")");
    }
}


কি করছে:

StudentView হল Interface → যা Presenter ব্যবহার করবে UI দেখানোর জন্য।

StudentConsoleView হল Console based implementation → শুধু ডেটা Console এ দেখাচ্ছে।

MVP এর রোল: UI representation → View

3️⃣ Presenter – StudentPresenter.java
public class StudentPresenter {
    private StudentView view;
    private Student model;

    public StudentPresenter(StudentView view, Student model) {
        this.view = view;
        this.model = model;
    }

    public void UpdateView() {
        view.ShowStudent(model.getName(), model.getAge());
    }
}


কি করছে:

View এবং Model কে সংযুক্ত করছে।

UpdateView() কল করলে, Model থেকে ডেটা নিয়ে View দেখাচ্ছে।

MVP এর রোল: Middleman, Logic handler → Presenter

4️⃣ Main.java – Application Execution
public class Main {
    public static void main(String[] args) {
        Student std = new Student("Yasir", 23);          // Model তৈরি
        StudentConsoleView scv = new StudentConsoleView(); // View তৈরি
        StudentPresenter sp = new StudentPresenter(scv, std); // Presenter তৈরি
        sp.UpdateView();                                 // UI update
    }
}


কি করছে:

Model (Student) তৈরি করছে।

View (StudentConsoleView) তৈরি করছে।

Presenter (StudentPresenter) তৈরি করছে যা Model এবং View কে সংযুক্ত করছে।

Presenter এর মাধ্যমে View আপডেট হচ্ছে।

MVP Flow Diagram (বাংলা ব্যাখ্যা সহ)
[Model: Student]
   ↑      |
   |      | (ডেটা/লজিক)
   |      v
[Presenter: StudentPresenter] ---------> [View: StudentConsoleView]
        (Logic + Data flow)                 (UI display)


Presenter: Model থেকে ডেটা নিয়ে View এ দেখায়।

View: কেবল দেখায়, Model কে চেনে না।

Model: কেবল Data রাখে, View কে চেনে না।

Summary in Bangla

Model → Data রাখে, Getter/Setter আছে।

View → UI দেখায়, কেবল Display করে।

Presenter → Model & View সংযোগ করে, Logic হ্যান্ডেল করে।

Main → সব তৈরি করে এবং Presenter এর মাধ্যমে UI update করে।

এভাবে MVP কোডের মধ্যে clean separation maintain করা হয়, UI এবং logic আলাদা থাকে, এবং code reusability এবং testing সহজ হয়।
