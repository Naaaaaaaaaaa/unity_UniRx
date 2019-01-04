/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class UniRxRepeatUntilDisableExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Timer(TimeSpan.FromSeconds(1.0f))
                      .RepeatUntilDisable(this)
                      .Subscribe(_ => Debug.Log("clicked"), () => Debug.Log("completed"));
        }
    }
}