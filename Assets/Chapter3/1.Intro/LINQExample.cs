/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System;
using System.Threading;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Linq;

namespace UniRxLesson
{
    public class LINQExample : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            var urls = new List<string> { "http://sikiedu.com", "http://qframework.io","a" };

            //urls.ForEach(url => Debug.Log(url));

            //Debug.Log(urls.First());

            //urls.Where(url => url.Length > 1)
                //.ToList()
                //.ForEach(url => Debug.Log(url));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
