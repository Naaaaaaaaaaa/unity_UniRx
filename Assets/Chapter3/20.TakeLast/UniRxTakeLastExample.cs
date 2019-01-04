/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class UniRxTakeLastExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Range(5, 5)
                      .TakeLast(3)
                      .Subscribe(number => Debug.Log(number));
        }
    }
}
