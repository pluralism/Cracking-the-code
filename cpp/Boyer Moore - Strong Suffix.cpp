#include <iostream>
#include <vector>
using namespace std;

void strong_suffix(string pattern, vector<int> &f, vector<int> &shift)
{
    auto m = static_cast<int>(pattern.length());
    auto i = m, j = m + 1;
    f[i] = j;

    while(i > 0)
    {
        while(j <= m && pattern[i - 1] != pattern[j - 1])
        {
            if(shift[j] == 0)
                shift[j] = j - i;
            j = f[j];
        }
        f[--i] = --j;
    }
}

void strong_suffix_2(const string &pattern, vector<int> &f, vector<int> &shift)
{
    auto m = static_cast<int>(pattern.length());
    auto j = f[0];
    for(int i = 0; i <= m; i++)
    {
        if(shift[i] == 0)
            shift[i] = j;

        if(i == j)
            j = f[j];
    }
}

int main(int argc, char *argv[]) {
    return 0;
}
