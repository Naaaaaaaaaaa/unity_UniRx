/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;
using UniRx.Triggers;
using System.Collections.Generic;
using System.Collections;

namespace UniRxLesson
{
    public class UniRxNextFrameExample : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(Time.frameCount);

            StartCoroutine(NextFrame(() => Debug.Log(Time.frameCount)));

            Observable.NextFrame()
                      .Subscribe(_ => Debug.LogFormat("Observable NextFrame:{0}", Time.frameCount));
        }

        IEnumerator NextFrame(Action callback)
        {
            yield return new WaitForEndOfFrame();

            callback();
        }
    }
}