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
    public class LINQTakeExample : MonoBehaviour
    {
        void Start()
        {
            var urls = new string[] {
                "http://sikiedu.com",
                "http://qframeowork.io",
                "http://weibo.com",
                "http://github.com",
            };

            urls.Take(3)
                .ToList()
                .ForEach(url =>
                {
                    Debug.Log(url);
                });
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}