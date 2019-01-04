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
    public class UniRxDoExample : MonoBehaviour
    {
        void Start()
        {
            Observable.ReturnUnit()
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Do(_ => Debug.Log("after 1 seconds"))
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Do(_ => Debug.Log("after 2 seconds"))
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Do(_ => Debug.Log("after 3 seconds"))
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Do(_ => Debug.Log("after 4 seconds"))
                      .Subscribe();
        }
    }
}