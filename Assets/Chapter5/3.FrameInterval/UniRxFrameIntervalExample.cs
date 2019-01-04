/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;
using UniRx.Triggers;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class UniRxFrameIntervalExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Timestamp()
                      .TimeInterval()
                      .FrameInterval()
                      .Subscribe(frameInterval => Debug.LogFormat("距离上一次点击的帧数:{0},时间间隔:{1}", frameInterval.Interval, frameInterval.Value.Interval));
        }
    }
}