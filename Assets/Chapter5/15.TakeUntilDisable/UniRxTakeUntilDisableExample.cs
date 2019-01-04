/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxTakeUntilDisableExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Do(_=>Debug.Log("do mouse button downed"))
                      .TakeUntilDisable(this)
                      .Subscribe(_ => Debug.Log("mouse clicked"));
        }
    }
}