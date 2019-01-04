/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxFirstExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                    .First(_ => Input.GetMouseButtonDown(0))
                    .Subscribe(_ => { Debug.Log("mouse down"); })
                    .AddTo(this);
        }
    }
}