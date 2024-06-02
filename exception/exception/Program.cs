namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("tokyo", 24.5, 10);
            Room room2 = new Room("paris", 50, 15);
            Room room3 = new Room("budapest", 30, 3);
            Room room4 = new Room("budapest", 30, 3);
            Hotel hotel = new Hotel();
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);
            hotel.AddRoom(room3);
            try
            {
                hotel.MakeReservation(1);
                hotel.MakeReservation(2);
                hotel.MakeReservation(3);
                hotel.MakeReservation(4);
            }
            catch (NotAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("unknown error");
            }
            room1.ShowInfo();
            room2.ShowInfo();
            room3.ShowInfo();
            room4.ShowInfo();
        }
    }
}
