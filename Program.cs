using DependencyInjectionPractice.Teacher;
using DependencyInjectionPractice;


ITeacher teacher = new Teacher("Burak", "K�r�c�");

Classroom classRoom = new Classroom(teacher);

Console.WriteLine(classRoom.GetTeacherInfo());
