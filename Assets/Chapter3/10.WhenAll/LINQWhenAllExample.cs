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
    public class LINQWhenAllExample : MonoBehaviour
    {
        void Start()
        {
            var ages = new int[] { 18, 19, 20, 10, 50, 100 };

            Debug.Log(ages.All(age => age > 10));
        }
    }
}