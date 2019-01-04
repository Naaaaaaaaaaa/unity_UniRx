/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class LINQGroupByExample : MonoBehaviour
    {
        class Student
        {
            public string Name;

            public int Age;
        }

        void Start()
        {
            var students = new List<Student>() {
                new Student(){Name="张三",Age=18},
                new Student(){Name="asd",Age=19},
                new Student(){Name="zxc",Age=120},
                new Student(){Name="qwe",Age=20},
                new Student(){Name="123",Age=18},
                new Student(){Name="aaa",Age=120},
                new Student(){Name="bbb",Age=19},
            };

            //students.GroupBy(student => student.Age)
            //.ToList()
            //.ForEach(studentGroup =>
            //{
            //    studentGroup
            //        .ToList()
            //        .ForEach(student =>
            //        {
            //            Debug.LogFormat("GroupName:{0} Name:{1} Age:{2}", studentGroup.Key, student.Name, student.Age);
            //        });
            //});

            (from student in students
            group student by student.Age into studentGroup
             select studentGroup)
                    .ToList()
                    .ForEach(studentGroup =>
                    {
                        studentGroup
                            .ToList()
                            .ForEach(student =>
                            {
                                Debug.LogFormat("GroupName:{0} Name:{1} Age:{2}", studentGroup.Key, student.Name, student.Age);
                            });
                    });
        }
    }
}