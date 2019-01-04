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
    public class UniRxDelayFrameSubscription : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(Time.frameCount);

            Observable.ReturnUnit()
                      .DelayFrameSubscription(10)
                      .Subscribe(_ => Debug.Log(Time.frameCount));

        }
    }
}