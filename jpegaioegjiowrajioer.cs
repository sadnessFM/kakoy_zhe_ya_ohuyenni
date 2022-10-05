namespace kakoy_zhe_ya_ohuyenni
{
    public class jpegaioegjiowrajioer
    {
        public jpegaioegjiowrajioer(string question, string ansewewr)
        {
            Question = question;
            Answer = ansewewr;
        }

        public string GetQuestion() => Question;
        public string GetAnswer() => Answer;
        
        public string Question { get; }
        public string Answer { get; }
    }
}