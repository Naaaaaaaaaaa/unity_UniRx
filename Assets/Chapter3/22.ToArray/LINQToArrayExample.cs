/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class LINQToArrayExample : MonoBehaviour
    {
        class Student
        {
            public string Name;
            public int Age;
        }

        void Start()
        {
            var students = new Student[]
            {
                new Student(){ Name = "张三",Age = 18},
                new Student(){ Name = "李四",Age = 19},
                new Student(){ Name = "王五",Age = 11},
            };

            var studentNames = students.Select(student => student.Name)
                                      .ToArray();

            Array.ForEach(studentNames, studentName => Debug.Log(studentName));
        }
    }
}