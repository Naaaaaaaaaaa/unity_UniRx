/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System;

namespace UniRxLesson
{
    public class UniRxThrottleFrameExample : MonoBehaviour
    {
        void Start()
        {
            int i = 0;

            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0)).Select(_ => ++i)
                      .Do(id => Debug.LogFormat("clicked realtime:{0}", id))
                      .ThrottleFrame(100)
                      .Do(_ => Debug.Log("end 100 frame"))
                      .Subscribe(id => Debug.LogFormat("processd  {0} clicked", id));
        }
    }
}