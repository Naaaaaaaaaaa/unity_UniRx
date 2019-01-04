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
    public class UniRxPairwiseExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Range(0, 3)
                      .Pairwise()
                      .Subscribe(pair => Debug.LogFormat("{0}:{1}", pair.Previous, pair.Current));
        }
    }
}