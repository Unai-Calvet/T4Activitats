using T4Activitats;

public class ActT4 {
    public static void Main() {
//Exercici 1
        Parella <string,int> parellaStringInt = new Parella<string, int>("text", 1);
        Parella<double, string> parellaDoubleString = new Parella<double, string>(3.14, "text");
    }
}