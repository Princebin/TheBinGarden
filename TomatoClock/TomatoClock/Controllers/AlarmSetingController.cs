using Ay.MvcFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TomatoClock.Models;

namespace TomatoClock.Controllers
{
    public class AlarmSetingController : Controller
    {
        AlarmSetingModel Model { get; set; }
        private string RoundrobinModel { get; set; }
        public AlarmSetingController()
        {
            Model = new AlarmSetingModel();
            RoundrobinModel = "一次";
            Roundrobin = inParam =>
             {
                 ChooseRoundrobin(inParam.ToObjectString());
             };
        }

        private void ChooseRoundrobin(string v)
        {
            RoundrobinModel = v;
            AYUI.Message.Send<string>(v, "ChooseRoundrobin");
        }

        public ActionResult Roundrobin { get; private set; }
    }
}
