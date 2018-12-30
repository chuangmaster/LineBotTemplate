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

                if (LineEvent.message.text == "liff")
                {
                    var LiffURL = "https://testliff.azurewebsites.net/default.html"; //測試用位置
                    //var LiffURL = "https://sweetassistant.azurewebsites.net/liff";

                    //建立LiffApp
                    //var Liff = isRock.LIFF.Utility.AddLiffApp(
                    //    ChannelAccessToken, new Uri(LiffURL), isRock.LIFF.ViewType.tall);

                    this.ReplyMessage(LineEvent.replyToken, " Liff App 已新增 : " + "line://app/1570222654-8xXLM1OL?id=123");
                }


            }
            catch (Exception ex)
            {
                Ok();
            }
            return Ok();
        }

    }
}