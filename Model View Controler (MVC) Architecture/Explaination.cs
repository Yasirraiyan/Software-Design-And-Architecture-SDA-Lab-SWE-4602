🔹 MVC কী?

👉 MVC মানে হলো Model – View – Controller।
এটা একটা আর্কিটেকচারাল ডিজাইন প্যাটার্ন, যেখানে প্রোগ্রামকে ৩ ভাগে আলাদা করে ফেলা হয় –

Model → ডাটা/লজিক হ্যান্ডেল করে

View → শুধু ডাটা দেখায় (UI/Console Output)

Controller → Model আর View এর মধ্যে সেতু হিসেবে কাজ করে

এতে কোড organized, maintainable আর reusable হয়।

🔹 তোমার কোডে MVC ব্যাখ্যা
1️⃣ Model Layer (Student class)
public class Student
{
    private string name;
    private int age;
    ...
}


➡ এখানে Student হলো Model।

ডাটা রাখছে (name, age)

Getter/Setter দিয়ে ডাটা অ্যাক্সেস ও আপডেট হচ্ছে।

কোনো Display/Presentation কাজ করছে না, শুধু ডাটা সম্পর্কিত কাজ করছে।

2️⃣ View Layer (StudentView class)
public class StudentView
{
    public void printStudentDetails(string name,int age)
    {
        Console.WriteLine($"Student Name:{name}");
        Console.WriteLine($"Student Age:{age}");
    }
    public void printMessage(string message)
    {
        Console.WriteLine(message);
    }
}


➡ StudentView হলো View।

শুধু ডাটা প্রিন্ট/দেখাচ্ছে (কিভাবে ইউজারকে আউটপুট দেখাতে হবে সেটা View এর দায়িত্ব)।

কোনো ডাটা চেঞ্জ করার কাজ করছে না, শুধু Display করছে।

3️⃣ Controller Layer (StudentController class)
public class StudentController
{
    private Student model;
    private StudentView sv;
    ...
}


➡ StudentController হলো Controller।

Model আর View কে কানেক্ট করছে।

Student এর ডাটা আপডেট করার কাজ করছে (setStudentName, setStudentAge)।

View এর মাধ্যমে Output দেখাচ্ছে (updateView, ShowMessage)।

4️⃣ Program/Main (Client)
class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student("Yasir", 23);
        StudentView sv = new StudentView();
        StudentController sc=new StudentController(student, sv);
        ...
    }
}


➡ এখানে আমরা

Model (Student)

View (StudentView)

Controller (StudentController)

— এগুলো একত্রে ব্যবহার করছি।

🔹 Flow (কাজ করার ধাপ)

প্রথমে Model (Student) তৈরি হলো Yasir (23) দিয়ে।

Controller Model আর View কে একত্র করলো।

updateView() → Controller View কে বললো, Model এর ডাটা দেখাতে।

এরপর setStudentName("Ali") → Controller Model এর নাম আপডেট করলো।

আবার updateView() → নতুন নাম View এ দেখানো হলো।

setStudentAge(33) দিয়ে Age আপডেট হলো।

ShowMessage("Student Details Updated Successfully") → View এর মাধ্যমে Message দেখানো হলো।

🔹 সহজ বাস্তব উদাহরণ (Real-Life Example)

ধরো তুমি একটা University System বানাচ্ছো –

Model → Student এর ডাটা (নাম, বয়স, ID, GPA ইত্যাদি রাখবে)

View → Student এর ডাটা ইউজারকে দেখাবে (Console, Webpage, Mobile Screen ইত্যাদি)

Controller → Teacher/Admin এর নির্দেশ অনুযায়ী Student এর ডাটা আপডেট বা View কে কল করবে

✅ সংক্ষেপে:

Model = ডাটা/লজিক

View = আউটপুট/UI

Controller = Model আর View এর কানেক্টর
