﻿using System;

namespace Simulator.DataObjects
{

    public interface IBaseDataObject
    {
        string Id { get; set; }
    }
    public class BaseDataObject: IBaseDataObject
    {
        public string Id { get; set; }
        public BaseDataObject()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
