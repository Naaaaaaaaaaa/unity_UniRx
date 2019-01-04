/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;
using System.Threading;
using System.Collections;
using System.Linq;

namespace UniRxLesson
{
    public class LINQOfTypeExample : MonoBehaviour
    {
        void Start()
        {
            var infos = new ArrayList() { 1, 2, 3, 4, 5, "6", 7.0, 8.0f };

            infos.OfType<float>()
                 .ToList()
                 .ForEach(info => Debug.Log(info));
        }
    }
}