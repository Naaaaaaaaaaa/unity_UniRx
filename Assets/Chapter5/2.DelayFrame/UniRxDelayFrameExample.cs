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
    public class UniRxDelayFrameExample : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(Time.frameCount);

            Observable.ReturnUnit()
                      .Do(_ => Debug.Log(Time.frameCount))
                      .DelayFrame(10)
                      .Do(_ => Debug.Log(Time.frameCount))
                      .Subscribe(_ => Debug.Log(Time.frameCount));
        }
    }
}