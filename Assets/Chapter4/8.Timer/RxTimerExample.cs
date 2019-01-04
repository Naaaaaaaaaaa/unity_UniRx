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
    public class RxTimerExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Timer(TimeSpan.FromSeconds(1.0), TimeSpan.FromSeconds(0.1f))
                      .Subscribe(_ => Debug.Log("after 1 seconds"));
        }
    }
}