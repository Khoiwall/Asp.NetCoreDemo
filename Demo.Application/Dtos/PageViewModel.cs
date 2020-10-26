using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Application.Dtos
{
    public class PageViewModel <T>
    {
        public List<T> Items { set; get; }
        public int totalRecord { set; get; }
    }
}
