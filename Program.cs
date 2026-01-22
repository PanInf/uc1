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

static int[] jhszdjfaiufg(int[] array)
{

    for (int i = 1; i < array.Length; i++)
    {
        int key = array[i];
        int j = i - 1;

        
        while (j >= 0 && array[j] > key)
        {
            array[j + 1] = array[j];
            j--;
        }

        
        array[j + 1] = key;
    }
    return array;
}

//sortowanie bąbelkowe
int[] t = { 1,4,6,2,8,7 };

for (int i=0; i<t.Length-1; i++)
{
    for (int j=0; j<t.Length-1; j++)
    {
        if (t[j]>t[j+1])
        {
            int temp = t[j];
            t[j] = t[j+1];
            t[j+1] = temp;

        }
    }
}
for(int i=0; i< t.Length; i++)
{
    Console.WriteLine(t[i] +"");
}

static void ASDHJGASD(int[]T)
{
    int n = T.Length;
    bool zamiana;

    do
    {
        zamiana = false;
        for (int i = 0; i < n - 1; i++)
        {
            if (T[i] > T[i + 1])
            {
                int tmp = T[i];
                T[i] = T[i + 1];
                T[i + 1] = tmp;
                zamiana = true;
            }
        }
        n--;
    } while (zamiana);
}

void CoctailSort(int[] Ciąg)
{
    int temporary = 0;
    for (int j = 0; j < Ciąg.Length - 1; j++)
    {
        for (int i = 0; i < Ciąg.Length-1; i++)
        {
            if(Ciąg[i] > Ciąg[i+1])
            {
                temporary = Ciąg[i];
                Ciąg[i] = Ciąg[i+1];
                Ciąg[i+1] = temporary;
            }
        }
        for (int i = Ciąg.Length-1; i > 0; i--)
        {
            if(Ciąg[i] < Ciąg[i-1])
            {
                temporary = Ciąg[i];
                Ciąg[i] = Ciąg[i-1];
                Ciąg[i-1] = temporary;
            }
        }
    }
}
