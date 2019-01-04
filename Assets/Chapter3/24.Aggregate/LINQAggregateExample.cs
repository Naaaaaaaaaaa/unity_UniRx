/****************************************************************************
 * http://sikiedu.com liangxie
 ****************************************************************************/

using UnityEngine;
using UniRx;
using System.Linq;
using System;

namespace UniRxLesson
{
    public class LINQAggregateExample : MonoBehaviour
    {
        // Use this for initialization
        void Start()
        {
            var ages = new[] { 80, 60, 40, 20, 55 };
            var minimalAge = ages.Aggregate((minAge, nextAge) => minAge > nextAge ? nextAge : minAge);

            Debug.Log(minimalAge);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}