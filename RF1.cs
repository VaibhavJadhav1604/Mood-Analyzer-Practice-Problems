﻿using System;

namespace REFACTOR1
{
    public class RF1
    {
        public string msg;
        public RF1()
        {

        }
        public RF1(string msg)
        {
            this.msg = msg;
        }
        public string analysemood()
        {
            //if msg passed in constructor contains given value
            if (this.msg.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
    internal class REFACTOR1
    {
        public static void Main(string[] args)
        {

        }
    }
}