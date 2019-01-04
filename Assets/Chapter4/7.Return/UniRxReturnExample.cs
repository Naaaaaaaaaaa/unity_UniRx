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
    public class UniRxReturnExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Return(Unit.Default)
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Repeat()
                      .Subscribe(_ => Debug.Log("after 1 seconds"));
        }
    }
}