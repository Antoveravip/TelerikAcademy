/* Lesson 7 - Data Structures Efficiency
 * Homework 3
 * 
 * Implement a class BiDictionary<K1,K2,T> that allows adding triples 
 * {key1, key2, value} and fast search by key1, key2 or by both key1 
 * and key2. Note: multiple values can be stored for given key.
 */

namespace BiDictionaryImplementation
{
    using System.Collections;
    using System.Collections.Generic;

    public class BiDictionary<T, K, L>
    {
        private Data<T, List<L>> firstKeyData;
        private Data<K, List<L>> secondKeyData;
        private Data<string, List<L>> bothKeysData;

        public BiDictionary()
        {
            this.firstKeyData = new Data<T, List<L>>();
            this.secondKeyData = new Data<K, List<L>>();
            this.bothKeysData = new Data<string, List<L>>();
        }

        public void Add(T firstKey, K secondKey, L value)
        {
            if (this.firstKeyData.Contain(firstKey))
            {
                this.firstKeyData[firstKey].Add(value);
            }
            else
            {
                this.firstKeyData.Add(firstKey, new List<L> { value });
            }

            if (this.secondKeyData.Contain(secondKey))
            {
                this.secondKeyData[secondKey].Add(value);
            }
            else
            {
                this.secondKeyData.Add(secondKey, new List<L> { value });
            }

            if (this.bothKeysData.Contain(firstKey.ToString() + secondKey.ToString()))
            {
                this.bothKeysData[firstKey.ToString() + secondKey.ToString()].Add(value);
            }
            else
            {
                this.bothKeysData.Add(firstKey.ToString() + secondKey.ToString(), new List<L> { value });
            }
        }

        public IEnumerable FindByFistKey(T key)
        {
            return this.firstKeyData[key];
        }

        public IEnumerable FindBySecondKey(K key)
        {
            return this.secondKeyData[key];
        }

        public IEnumerable FindByBothKeys(T firstKey, K secondKey)
        {
            return this.bothKeysData[firstKey.ToString() + secondKey.ToString()];
        }
    }
}