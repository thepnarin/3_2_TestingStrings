﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_TestingStrings.Fundamentals
{
    public class HtmlFormatter
    {
        public string FormatAsBold(string content)
        {
            return "<strong></strong>";

            return $"<strong>{content}</strong>";
        }
    }
}
