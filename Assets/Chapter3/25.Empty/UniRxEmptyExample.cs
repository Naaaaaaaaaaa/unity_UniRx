/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;

namespace UniRxLesson
{
    public class UniRxEmptyExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Empty<string>()
                      .Subscribe(_ => Debug.Log("OnNext"), () => Debug.Log("OnCompleted"));
        }
    }
}