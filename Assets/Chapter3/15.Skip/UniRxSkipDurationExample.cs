/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;
using System;

namespace UniRxLesson
{
    public class UniRxSkipDurationExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Skip(TimeSpan.FromSeconds(5))
                      .Subscribe(_ =>
                      {
                          Debug.Log("mouse clicked");
                      });
        }
    }
}