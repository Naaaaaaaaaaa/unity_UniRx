/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class LINQDistinctExample : MonoBehaviour
    {
        void Start()
        {
            var urls = new List<string>
            {
                "http://sikiedu.com",
                "http://sikiedu.com",
                "http://qframework.io",
                "http://qframework.io"
            };

            urls.Distinct()
                .ToList()
                .ForEach(url => Debug.Log(url));
        }
    }
}