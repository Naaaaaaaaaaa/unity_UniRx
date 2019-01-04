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
    public class UniRxForEachAsync : MonoBehaviour
    {
        void Start()
        {
            Observable.Range(0, 3) // 0 1 2 
                      .ForEachAsync(number => Debug.LogFormat("for each:{0}", number))
                      .Subscribe(number => Debug.LogFormat("subsrcibe:{0}", number));
        }
    }
}