using AppConsoleLivres;

internal class Program
{
    private static void Main(string[] args)
    {
        Revue revue1 = new Revue("Pere riche Pere pauvre", "Robert T. Kiyosaki", 332, 12, 1997);
        Revue revue2 = new Revue("Aya de Yopougon", "Marguerite Abouet", 104, 9, 2023);
        Revue revue3 = new Revue("Toujours Plus", "Lena Mahfouf", 152, 1, 2020);

        Roman roman1 = new Roman("La Nausee", "Jean Paul Sartre", 249, "Autobiographique");
        Roman roman2 = new Roman("Les Rois Maudits", "Maurice Druon", 2149, "Historique");
        Roman roman3 = new Roman("Le Horla", "Guy de Maupassant", 143, "Fantastique");
    }
}