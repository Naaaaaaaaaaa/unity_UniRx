/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class LINQWhereExample : MonoBehaviour
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
                    //.ToList()
                    //.ForEach(student =>
                    //{
                    //    Debug.Log(student.Name);
                    //});

            (from student in students where student.Age > 10 select student)
                 .ToList()
                 .ForEach(student =>
                 {
                     Debug.Log(student.Name);
                 });
        }
    }
}