string[] list = new String[] { "hello", "2", "world", ":-)" };
string[] list2 = new String[] { };
int len = 0;

int listLength = list.Length;
for (int i = 0; i < listLength; i++)
{
    if (list[i].Length <= 3)
    {
        Array.Resize(ref list2, list2.Length + 1);
        len = list2.Length;
        list2[len - 1] = list[i];
    }
}


int list2Length = list2.Length;
for (int j = 0; j < list2Length; j++)
{
    Console.WriteLine("   [{0}] : {1}", j, list2[j]);
}
