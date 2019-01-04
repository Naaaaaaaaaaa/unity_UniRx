/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxTakeWhileExample : MonoBehaviour
    {
        void Start()
        {
            //Observable.EveryUpdate()
                      //.Where(_ => Input.GetMouseButton(0))

            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButton(0))
                      .TakeWhile((_, number) => !Input.GetMouseButtonUp(0) && number < 100)
                      .Subscribe(_ => Debug.Log("mouse button clicking"));
        }
    }
}