/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class UniRxRangeExample : MonoBehaviour
    {
        void Start()
        {
            Observable.Range(5, 10).Select(x => x * x)
                      .Subscribe(number =>
                      {
                          Debug.Log(number);
                      });
        }
    }
}