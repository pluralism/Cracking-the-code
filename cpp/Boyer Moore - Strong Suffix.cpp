#include <iostream>
#include <vector>
using namespace std;

void strong_suffix(string pattern)
{
    auto m = static_cast<int>(pattern.length());
    auto i = m, j = m + 1;
    vector<int> f(static_cast<unsigned long>(m + 1));
    vector<int> shift(static_cast<unsigned long>(m + 1));
    // initial value, for the empty string
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

int main(int argc, char *argv[]) {
    return 0;
}
