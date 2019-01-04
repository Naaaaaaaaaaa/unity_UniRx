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
    public class UniRxBatchFrameExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .BatchFrame(100, FrameCountType.EndOfFrame)
                      .Subscribe(clicks =>
                      {
                          Debug.Log(clicks.Count);
                      });
        }
    }
}