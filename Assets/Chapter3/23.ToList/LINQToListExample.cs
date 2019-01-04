/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class LINQToListExample : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            var fruits = new[] { "apple", "orange", "banana", "pineapple" };

            fruits.Select(fruit => fruit.Length).ToList()
                  .ForEach(fruitLength => Debug.Log(fruitLength));
        }
    }
}