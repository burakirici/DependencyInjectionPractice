using DependencyInjectionPractice.Teacher;
using DependencyInjectionPractice;


ITeacher teacher = new Teacher("Burak", "Kýrýcý");

Classroom classRoom = new Classroom(teacher);

Console.WriteLine(classRoom.GetTeacherInfo());
