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
    public class UniRxDelaySubscriptionExample : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(Time.time);

            Observable.ReturnUnit()
                      .DelaySubscription(TimeSpan.FromSeconds(1.0f))
                      .Subscribe(_ => Debug.Log(Time.time));
        }
    }
}