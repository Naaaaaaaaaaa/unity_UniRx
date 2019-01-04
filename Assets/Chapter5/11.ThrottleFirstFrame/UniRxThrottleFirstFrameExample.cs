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
    public class UniRxThrottleFirstFrameExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .ThrottleFirstFrame(100)
                      .Subscribe(_ => Debug.Log("clicked"));

            Observable.EveryUpdate()
                      .SampleFrame(100)
                      .Subscribe(_ => Debug.Log("frame ended"));
        }
    }
}