using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrossvertiseAppNew.Controllers
{
    public class CalenderController : Controller
    {
        private AppointmentDB db = new AppointmentDB();
        public ActionResult Index()
        {
            return View(db.Months.ToList());
        }

        public ActionResult GetMonthDetails(int monthIdValue)
        {
            List<Appointment> lstappointments = db.Appointments.Where(x => x.Month.ID == monthIdValue).ToList();
            if (lstappointments.Count > 0)
            {
                return PartialView("_monthDetails", lstappointments);
            }
            else
            {
                return View("ErrorPage");
            }
        }

        public ActionResult GetMeetingDetails(int meetingId)
        {
            var appointmentDesc = db.AppDescs.Where(x => x.AppId == meetingId).FirstOrDefault();
            if (appointmentDesc != null)
            {
                return PartialView("_meetingInfo", appointmentDesc);
            }
            else
            {
                return View("ErrorPage");
            }
        }
              
    }
}