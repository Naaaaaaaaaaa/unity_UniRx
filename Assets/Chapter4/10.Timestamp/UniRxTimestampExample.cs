/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxTimestampExample : MonoBehaviour
    {
        void Start()
        {
            Observable.EveryUpdate()
                      .Where(_ => Input.GetMouseButtonDown(0))
                      .Timestamp()
                      .Subscribe(timestamp => { Debug.LogFormat("timestamp:{0}", timestamp.Timestamp.LocalDateTime); });
        }
    }
}