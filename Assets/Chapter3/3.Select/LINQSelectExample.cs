/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class LINQSelectExample : MonoBehaviour
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

            //students.Where(student => student.Age > 10)
            //.Select(student => student.Name)
            //.ToList()
            //.ForEach(studentName =>
            //{
            //    Debug.Log(studentName);
            //});

            (from student in students where student.Age > 10 select student.Name)
                     .ToList()
                     .ForEach(studentName =>
                     {
                         Debug.Log(studentName);
                     });
        }
    }
}