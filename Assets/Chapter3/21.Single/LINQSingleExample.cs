/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class LINQSingleExample : MonoBehaviour
    {
        void Start()
        {
            var ages = new[] { 1, 2, 3, 4, 5 };

            Debug.Log(ages.Single(age => age == 3));
        }
    }
}