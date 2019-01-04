/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxSwitchExample : MonoBehaviour
    {
        void Start()
        {
            var stateJump = Observable.Return("jump state");

            Observable.EveryUpdate()
                      .Where(_ => Input.GetKeyDown(KeyCode.Space))
                      .Select(_ => stateJump)
                      .Switch()
                      .Subscribe(stateName => Debug.Log(stateName));
        }
    }
}
