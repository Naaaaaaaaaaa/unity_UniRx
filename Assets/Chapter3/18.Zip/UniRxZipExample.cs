/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;

namespace UniRxLesson
{
    public class UniRxZipExample : MonoBehaviour
    {
        private void Start()
        {
            var leftStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0));
            var rightStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1));

            leftStream.Zip(rightStream, (left, right) => Unit.Default)
                      .Subscribe(_ => Debug.Log("ok"));
        }
    }
}