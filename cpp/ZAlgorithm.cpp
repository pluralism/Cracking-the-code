#include <iostream>
#include <vector>
using namespace std;

void zAlgorithm(string text, vector<int> &z)
{
    auto l = 0, r = 0, k = 0;
    auto size = static_cast<int>(text.length());

    for(int i = 1; i < size; i++)
    {
        if(i > r)
        {
            l = r = i;
            while(r < size && text[r] == text[r - l])
                r++;

            z[i] = r - l;
            r--;
        } else
        {
            k = i - l;
            if(z[k] < r - i + 1)
                z[i] = z[k];
            else
            {
                l = i;
                while(r < size && text[r] == text[r - l])
                    r++;

                z[i] = r - l;
                r--;
            }
        }
    }
}

void searchText(string p, string t)
{
    string final = p + "$" + t;
    vector<int> z(final.length());
    vector<int> res(z.size());
    zAlgorithm(final, z);

    for(int i = 0; i < res.size(); i++)
        if(z[i] == p.size())
            cout << "Found a match at " << i << endl;
}
