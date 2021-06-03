using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Entities;

namespace WebApplication2.Models
{
    public class ResponseStudent
    {
        public ResponseStudent(Student responseStudent)
        {
            id_Student = responseStudent.id_Student;
            Surname = responseStudent.Surname;
            Name = responseStudent.Name;
            Patronymic = responseStudent.Patronymic;
            id_Group = (int)responseStudent.id_Group;
            id_User = (int)responseStudent.id_User;
        }
        public int id_Student { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public int id_Group { get; set; }
        public int id_User { get; set; }
    }
}