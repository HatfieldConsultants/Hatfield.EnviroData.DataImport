﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hatfield.DataImport.ValueParsers
{
    public class NullableIntValueParser : IValueParser
    {
        public virtual object Parse(object value)
        {
            if (value == null)
            {
                return null;
            }
            else
            {
                try
                {
                    return Convert.ToInt32(value);
                }
                catch (Exception)
                {
                    throw new InvalidOperationException("Can not parse value to integer");
                }
            }

        }
    }
}