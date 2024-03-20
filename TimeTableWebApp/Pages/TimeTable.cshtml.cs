using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TimeTableWebApp.Models;

namespace TimeTableWebApp.Pages
{
    public class TimeTableModel : PageModel
    {
        private PRN221_PROJECTContext _context;

        public TimeTableModel(PRN221_PROJECTContext context)
        {
            _context = context;
        }

        public List<Session> Sessions { get; set; }
        public List<Room> Rooms { get; set; }
        public List<TimeSlot> TimeSlots { get; set; }
        public void OnGet()
        {
            TimeSlots = _context.TimeSlots.ToList();
            Rooms = _context.Rooms.ToList();
            Sessions = _context.Sessions.Include(x => x.Room).Include(x => x.TimeSlot).ToList();
        }
    }
}
