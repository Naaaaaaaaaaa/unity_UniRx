/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class LINQTakeWhileExample : MonoBehaviour
    {
        void Start()
        {
            var fruits = new[] { "apple", "mango", "orange", "banana", "melon" };

            fruits.TakeWhile(fruit => fruit != "orange")
                  .ToList()
                  .ForEach(fruit => Debug.Log(fruit));
        }
    }
}