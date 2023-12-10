using WebAPIPractice.Models;

namespace WebAPIPractice.Repositories
{
    public interface IRoomRepository
    {
        Task<Room> GetRoomByName(string name);
        Task AddRoom(Room room);

        Task<Room[]> GetRooms();
    }
}
