/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxWhereExample : MonoBehaviour
    {
        void Start()
        {
            (from updateEvent in Observable.EveryUpdate()
             where Input.GetMouseButtonDown(0)
             select updateEvent)
                .Subscribe(_ =>
                {
                    Debug.Log("mouse down");
                }).AddTo(this);
        }
    }
}