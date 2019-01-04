/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class LINQFirstExample : MonoBehaviour
    {
        class Student
        {
            public string Name;

            public int Age;
        }

        void Start()
        {
            var students = new List<Student>()
            {
                new Student { Name = "张三", Age = 18 },
                new Student { Name = "张三", Age = 18 },
                new Student { Name = "李四", Age = 10 },
            };

            //var newStudent = students.First(student => student.Age < 15);
            //Debug.Log(newStudent.Name);

            //var newStudent = (from student in students select student)
            //    .First(student => student.Age < 15);
            //Debug.Log(newStudent.Name);
        }
    }
}