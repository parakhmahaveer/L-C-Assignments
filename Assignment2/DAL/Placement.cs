

namespace MoodleAssignment2_Functions.DAL
{
    public class Placement
    { 
        public string ShelfNumber { get; }
        public string RoomNumber { get; }

        public Placement(string shelf, string room)
        {
            ShelfNumber = shelf;
            RoomNumber = room;
        }

        public string GetLocation()
        {
            return $"Shelf: {ShelfNumber}, Room: {RoomNumber}";
        }
    }
}
