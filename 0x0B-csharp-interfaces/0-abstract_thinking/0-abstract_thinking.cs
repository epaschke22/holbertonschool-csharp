﻿using System;

abstract class Base
{
    public string name;

    public override string ToString()
    {
        return String.Format("{0} is a {1}", name, this.GetType());
    }
}
