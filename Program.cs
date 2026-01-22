//Proszę by każdy napisał jakiś algorytm sortowania. Jego nazwa to ma być jakiś totalnie losowy ciąg
static int[] ADASDASDASDASDASDAS(int[] tab)
{
    bool swapped;
    do
    {
        swapped = false;
        for (int i = 1; i < tab.Length; i++)
        {
            if (tab[i - 1] > tab[i])
            {
                (tab[i - 1], tab[i]) = (tab[i], tab[i - 1]);
                swapped = true;
            }
        }
    } while (swapped);

    return tab;
}
