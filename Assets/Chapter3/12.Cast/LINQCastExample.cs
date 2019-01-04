/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class LINQCastExample : MonoBehaviour
    {
        private void Start()
        {
            var infos = new List<object> { "lemon", "apple", "melon" };

            infos.Cast<string>()
                 .ToList()
                 .ForEach(fruit => Debug.Log(fruit));
        }
    }
}