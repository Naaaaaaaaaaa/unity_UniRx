/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace UniRxLesson
{
    public class UniRxWhenAllExample : MonoBehaviour
    {
        IEnumerator A()
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("A");
        }

        IEnumerator B()
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("B");
        }

        void Start()
        {
            var leftClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(0)).Take(3).Select(_ =>
            {
                Debug.Log("left mouse clicked");
                return Unit.Default;
            });

            var rightClickStream = Observable.EveryUpdate().Where(_ => Input.GetMouseButtonDown(1)).Take(4).Select(_ =>
            {
                Debug.Log("right mouse clicked");
                return Unit.Default;
            });

            Observable.WhenAll(Observable.FromCoroutine(A),
                               Observable.FromCoroutine(B),
                               leftClickStream,
                               rightClickStream)
                      .Subscribe(_ =>
                      {
                          Debug.Log("all coroutine completed");
                      });
        }
    }
}