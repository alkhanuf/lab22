using System;

public class Utils
{
    public static List<string> FindWords(string s1, string s2)
    {        
        string[] words1 = s1.Split(' ');
        string[] words2 = s2.Split(' ');

        List<string> res = new List<string>();


        for (int i = 0; i < words1.Length; i++)
        {
            for (int j = 0; j < words2.Length; j++)
            {
                if (words1[i] == words2[j])
                {
                    bool f = false;

                    for (int k = 0; k < res.Count; k++)
                    {
                        if (res[k] == words1[i])
                        {
                            f = true;
                            break;
                        }
                    }

                    if (!f)
                    {
                        res.Add(words1[i]);
                    }
                }
            }
        }

        return res;
    }
}