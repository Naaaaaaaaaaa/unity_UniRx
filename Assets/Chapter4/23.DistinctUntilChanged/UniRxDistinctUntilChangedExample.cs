/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;

namespace UniRxLesson
{
    public class UniRxDistinctUntilChangedExample : MonoBehaviour
    {
        void Start()
        {
            var state = "runState";

            Observable.EveryUpdate()
                      .DistinctUntilChanged(_ => state)
                      .Subscribe(stateName => Debug.LogFormat("on state changed:{0}", state));


            Observable.ReturnUnit()
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Do(_ => state = "jumpState")
                      .Delay(TimeSpan.FromSeconds(1.0f))
                      .Do(_ => state = "idleState")
                      .Subscribe();
        }
    }
}