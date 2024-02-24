using MVC_Demo.Models;

namespace MVC_Demo.Methods.cs
{
    // Will perform All CRUD operations on STudent
    public class Method
    {
        static List<Student> list = new List<Student>();

        public List<Student> GetStudents()
        {
            if (list.Count==0)
            {
                list = new List<Student>()
                {
                     new Student(){Id=1, Name="Ajay", Address="Delhi"},


                     new Student(){Id=2, Name="Vijay", Address="Delhi"},

                     new Student(){Id=3, Name="Jay", Address="Delhi"}
                };
            }
            return list;

        }

        public Student AddStudent(Student student)
        {
            list.Add(student);
            return student;
        }

        public Student GetStudent(int id)
        {
            return list.FirstOrDefault(x => x.Id == id);
        }

        public bool DeleteStudent(int id)
        {
            list.RemoveAt(id);
            return true;    
        }

        public bool EditStudent(int id, Student student)
        {
            var obj = GetStudent(id);
            if (obj == null)
            {
                return false;
            }
            else
            {
                foreach (var item in list)
                {
                    if (item.Id == id)
                    {
                        item.Name = student.Name;
                    }
                    break;
                }
                    }
            return true;
                }
            }
        }

    

