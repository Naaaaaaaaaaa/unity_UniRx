/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxNeverExample : MonoBehaviour
    {
        void Start()
        {
            var never = Observable.Never<string>();

            never.Subscribe(_ => Debug.Log(_), () => { Debug.Log("completed"); });
        }
    }
}