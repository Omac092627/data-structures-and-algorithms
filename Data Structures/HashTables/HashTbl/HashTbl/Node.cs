﻿using System;

namespace HashTable
{
    public class Node<T>
    {
        public string Key { get; set; }
        public T Value { get; set; }

        public Node(T value, string key)
        {
            Key = key;
            Value = value;
        }
    }
}
