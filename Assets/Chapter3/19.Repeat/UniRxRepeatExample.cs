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
    public class UniRxRepeatExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Timer(TimeSpan.FromSeconds(1.0f))
                      .Repeat()
                      .Subscribe(_ => Debug.Log("after 1 seconds"));


            this.UpdateAsObservable();
        }
    }
}