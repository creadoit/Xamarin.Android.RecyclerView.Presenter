﻿using System;

namespace com.exozet.recyclerview
{
    public class Item<T>
    {
        public T Model { get; set; }

        public Type PresenterType { get; set; }
    }
}