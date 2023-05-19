namespace App_NintenShop
{
    internal interface IConsola_juegos
    {
        string TITLE { get; set; }
        string GENERE { get; set; }
        string CREATORS { get; set; }
        double PRICE { get; set; }
        int FOLDER { get; set; }
        string ToString();
        string Ticket();
    }
}