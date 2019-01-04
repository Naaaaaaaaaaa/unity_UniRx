/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;

namespace UniRxLesson
{
    public class UniRxTakeExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Take(2)
                      .Subscribe(_ => { Debug.Log("mouse clicked!"); });
        }

    }
}