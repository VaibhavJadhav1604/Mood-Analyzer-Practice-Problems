using System;

namespace MAPP1
{
    public class MAP1
    {
        public string analysemood(string msg)
        {
            if (msg.Contains("SAD"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
    internal class MAPP1
    {
        public static void Main(string[] args)
        {

        }
    }
}