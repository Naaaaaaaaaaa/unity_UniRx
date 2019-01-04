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
    public class UniRxSampleExample : MonoBehaviour
    {
        void Start()
        {
            int clickCount = 0;

            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Select(_ => clickCount++)
                      .Sample(TimeSpan.FromSeconds(3))
                      .Subscribe(_ => Debug.LogFormat("第 {0} 次点击", clickCount));
        }
    }
}