/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;

namespace UniRxLesson
{
    public class UniRxAmbExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Amb(
                Observable.Timer(TimeSpan.FromSeconds(4.0f)).Select(_ => "4 sec"),
                Observable.Timer(TimeSpan.FromSeconds(3.0f)).Select(_ => "3 sec"),
                Observable.Timer(TimeSpan.FromSeconds(1.0f)).Select(_ => "1 sec"),
                Observable.Timer(TimeSpan.FromSeconds(7.0f)).Select(_ => "7 sec"),
                Observable.Timer(TimeSpan.FromSeconds(9.0f)).Select(_ => "9 sec")
            ).Subscribe(observableName =>
            {
                Debug.Log(observableName);
            });
        }
    }
}