/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxSelectExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
            .Where(_ => Input.GetMouseButtonDown(0))
            .Select(_ => "mouse down")
            .Subscribe(mouseEventName =>
            {
                Debug.Log(mouseEventName);
            })
            .AddTo(this);

            //(from updateEvent in Observable.EveryUpdate() where Input.GetMouseButtonDown(0) select "mouse down")
                //.Subscribe(mouseEventName => Debug.Log(mouseEventName))
                //.AddTo(this);
        }
    }
}