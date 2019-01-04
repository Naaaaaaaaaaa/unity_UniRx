/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;

namespace UniRxLesson
{
    public class UniRxRepeatUntilDestroyExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Timer(TimeSpan.FromSeconds(1.0f))
                      .RepeatUntilDestroy(this)
                      .Subscribe(_ => Debug.Log("ticked"));
        }
    }
}