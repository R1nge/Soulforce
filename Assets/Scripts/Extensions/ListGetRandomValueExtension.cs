using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace Extensions
{
    public static class ListGetRandomValueExtension
    {
        private static readonly Random Random = new();
        private static readonly List<int> UsedIndexes = new();

        public static T GetRandomElement<T>(this IList<T> list)
        {
            var randomIndex = Random.Next(list.Count);

            if (list.Count == UsedIndexes.Count)
            {
                Debug.Log(randomIndex);
                return list[randomIndex];
            }
            
            if (!UsedIndexes.Contains(randomIndex))
            {
                UsedIndexes.Add(randomIndex);
            }
            else
            {
                GetRandomElement(list);
            }

            return list[randomIndex];
        }
    }
}