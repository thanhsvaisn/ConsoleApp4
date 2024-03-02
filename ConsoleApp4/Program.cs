using ConsoleApp4;

static void PlayHello (string str)
{
    Console.WriteLine ("Hello " + str);
}
PrintfMessager pm = new PrintfMessager (PlayHello);
DemoDelegate dd = new DemoDelegate ();
pm += dd.ShowInfo;
pm("Luu quang thanh");