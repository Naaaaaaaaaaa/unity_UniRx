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
    public class CoroutineSequenceExample : MonoBehaviour
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

        IEnumerator C()
        {
            yield return new WaitForSeconds(1.0f);
            Debug.Log("C");
        }

        // Use this for initialization
        void Start()
        {
            var aStream = Observable.FromCoroutine(A);
            var bStream = Observable.FromCoroutine(B);
            var cStream = Observable.FromCoroutine(C);

            aStream.SelectMany(bStream.SelectMany(cStream))
                   .Subscribe();
        }
    }
}