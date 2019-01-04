/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class LINQLastExample : MonoBehaviour
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
                new Student { Name = "张五", Age = 18 },
                new Student { Name = "李四", Age = 10 },
            };

            var lastStudent = students.Last(student => student.Age > 10);
            Debug.Log(lastStudent.Name);
        }
    }
}