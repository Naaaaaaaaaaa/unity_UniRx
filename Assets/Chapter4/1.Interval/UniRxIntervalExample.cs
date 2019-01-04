/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class UniRxIntervalExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Interval(TimeSpan.FromSeconds(0.5f))
                      .Subscribe(times => Debug.Log(times));
        }
    }
}