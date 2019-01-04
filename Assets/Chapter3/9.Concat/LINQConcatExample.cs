/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace UniRxLesson
{
    public class LINQConcatExample : MonoBehaviour
    {
        void Start()
        {
            var aClassAges = new[] { 3, 4, 5, 6 };
            var bClassAges = new[] { 1, 3, 5, 7 };

            aClassAges.Concat(bClassAges)
                      .ToList()
                      .ForEach(age =>
                      {
                          Debug.Log(age);
                      });
        }
    }
}