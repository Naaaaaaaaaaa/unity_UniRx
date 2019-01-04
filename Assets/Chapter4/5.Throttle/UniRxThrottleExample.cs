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
            //Throttle在没有接收到信息源一秒后输出“after 1 seconds”
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Throttle(TimeSpan.FromSeconds(1.0f))
                      .Subscribe(_ => Debug.Log("after 1 seconds"));
        }
    }
}