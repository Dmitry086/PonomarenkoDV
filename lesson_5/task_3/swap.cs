class Swap
{
    string st1;
    string st2;
    public Swap(string s1, string s2)
    {
    st1 = s1;
    st2 = s2;
    }
    public bool checkSwap() 
    {
        string str1 = string.Join("", st1.OrderBy(c => c).ToArray());
        string str2 = string.Join("", st2.OrderBy(c => c).ToArray());
        return str1.Equals(str2);
    }
    public bool checkSwap1()
    {
        if (st1.Length != st2.Length)
        return false;

        char[] a = st1.ToCharArray();
        char[] b = st2.ToCharArray();

        Array.Sort(a);
        Array.Sort(b);

        return  a.SequenceEqual(b);
    }  
}