/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class LINQEmptyExample : MonoBehaviour
    {
        void Start()
        {
            var emptyStringList = Enumerable.Empty<string>()
                                           .ToList();
            Debug.Log(emptyStringList.Count);
        }
    }
}