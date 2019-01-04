/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;
using UniRx.Triggers;

namespace UniRxLesson
{
    public class UniRxThrottleExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Throttle(TimeSpan.FromSeconds(1.0f))
                      .Subscribe(_ => Debug.Log("after 1 seconds"));
        }
    }
}