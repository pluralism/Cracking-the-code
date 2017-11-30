class Program 
{
    const int MAX_COLORS = 4;
    int Code(char c)
    {
        switch(c)
        {
            case 'B':
                return 0;
            case 'G':
                return 1;
            case 'R':
                return 2;
            case 'Y':
                return 3;
            default:
                return -1;
        }
    }

    Result Estimate(string guess, string solution)
    {
        if(guess.Length != solution.Length)
        {
            return null;
        }

        Result res = new Result();
        int[] frequencies = new int[MAX_COLORS];

        for(int i = 0; i < guess.Length; i++)
        {
            if(guess[i] == solution[i])
            {
                res.Hits++;
            } else
            {
                int code = Code(solution[i]);
                frequencies[code]++;
            }
        }

        for(int i = 0; i < guess.Length; i++)
        {
            int code = Code(guess[i]);
            if(code >= 0 && frequencies[code] > 0 && guess[i] != solution[i])
            {
                res.PseudoHits++;
                frequencies[code]--;
            }
        }
        return res;
    }
}
