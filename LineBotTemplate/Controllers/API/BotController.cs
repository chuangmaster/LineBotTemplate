using isRock.LineBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LineBotTemplate.Controllers.API
{
    public class BotController : LineWebHookControllerBase
    {
        /// <summary>
        /// 機器人服務窗口
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("~/api/bot/start")]
        public IHttpActionResult Start()
        {
            try
            {
                //取得Line Event
                var LineEvent = this.ReceivedMessage.events.FirstOrDefault();
                //配合Line verify 
                if (LineEvent.replyToken == "00000000000000000000000000000000") return Ok();

                this.ReplyMessage(LineEvent.replyToken, "");


            }
            catch (Exception ex)
            {
                Ok();
            }
            return Ok();
        }

    }
}