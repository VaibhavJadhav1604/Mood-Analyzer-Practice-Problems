using System;

namespace MAPP2
{
    public class MAP2
    {
        public string analysemood(string msg)
        {
            try
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
            catch
            {
                return "HAPPY";
            }
        }
    }
    internal class MAPP2
    {
        public static void Main(string[] args)
        {

        }
    }
}