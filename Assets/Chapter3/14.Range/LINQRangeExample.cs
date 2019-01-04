/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System.Collections.Generic;

namespace UniRxLesson
{
    public class LINQRangeExample : MonoBehaviour
    {
        void Start()
        {
            Enumerable.Range(5, 10).Select(x => x * x)
                      .ToList()
                      .ForEach(number =>
                      {
                          Debug.Log(number);
                      });
        }
    }
}