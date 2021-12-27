using System;

namespace Open_Lab_05._01
{
    public class DateTools
    {
        public string Century(int year)
        {
            int century = 0;
            string answer = "";
            century = year / 100;
                if(year % 100 > 0)
                {
                century++;


                }
            answer = century.ToString();
            if(century < 10)
            {
                if (answer.EndsWith("1"))
                {
                    answer += "st century";
                }
                else
                {
                    if (answer.EndsWith("2"))
                    {
                        answer += "nd century";
                    }
                    else
                    {
                        if (answer.EndsWith("3"))
                        {
                            answer += "rd century";
                        }
                        else
                        {
                            answer += "th century";
                        }
                    }
                }
            }
            else
            {
                if (20 > century)
                {
                    answer += "th century";
                }
                else
                {
                    if (answer.EndsWith("1"))
                    {
                        answer += "st century";
                    }
                    else
                    {
                        if (answer.EndsWith("2"))
                        {
                            answer += "nd century";
                        }
                        else
                        {
                            if (answer.EndsWith("3"))
                            {
                                answer += "rd century";
                            }
                            else
                            {
                                answer += "th century";
                            }
                        }
                    }
                }
            }
            return answer;
        }
    }
}
