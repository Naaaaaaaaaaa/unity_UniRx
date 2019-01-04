/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class UniRxThrottleFirstExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .ThrottleFirst(TimeSpan.FromSeconds(2.0))
                      .Subscribe(_ => Debug.Log("clicked!"));
        }
    }
}