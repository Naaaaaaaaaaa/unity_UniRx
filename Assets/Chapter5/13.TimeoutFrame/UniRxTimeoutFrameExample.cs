/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxTimeoutFrameExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Do(_ => Debug.LogFormat("clicked frame:{0}", Time.frameCount))
                      .TimeoutFrame(120)
                      .Subscribe(_ => Debug.Log("mouse clicked"), e =>
                      {
                          Debug.LogFormat("excpetion frame count:{0}", Time.frameCount);
                      });
        }
    }
}