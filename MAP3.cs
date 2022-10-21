using System;

namespace MAPP3
{
    public class MoodAnalysisException : Exception
    {   
        public enum ExceptionType
        {
            Null,Empty
        }

        public readonly ExceptionType type; 
        
        public MoodAnalysisException(ExceptionType type,string msg)
        : base(msg)
        {
            this.type = type;
        }
    }
    public class MAP3
    {
        public string analysemood(string msg)
        {
            try
            {
                if (msg.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Empty,"Empty Value");
                }
                if (msg.Contains("SAD"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.Null,"Null Value");
            }
        }
    }
    internal class MAPP3
    {
        public static void Main(string[] args)
        {

        }
    }
}